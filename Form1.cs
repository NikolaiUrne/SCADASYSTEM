using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AlarmGUI
{

    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private string connectionString = "Data Source=LAPTOP-S9B2BQJO\\SQLEXPRESS;Initial Catalog=SCADASYSTEM;Integrated Security=True;TrustServerCertificate=True;";
        public double Temperature;
        public double SetPoint;
        public double ControlSignal;
        public double alarmHighLimit;
        public double alarmLowLimit;


        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000; // Set the timer to tick every second
            timer.Tick += Timer_Tick; ; // Subscribe to the Tick event
            timer.Start(); // Start the timer

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string measurementsql = "SELECT TOP 1 Value, SetPoint, ControlSignal FROM Measurement ORDER BY TimeStamp DESC";
            string alarmsql = "SELECT al.HighLimit, al.LowLimit FROM AlarmLimit al JOIN Sensor s ON al.SensorID = s.SensorID WHERE s.Name = '16-AH-194801'";
            string sqlGetAlarm = "SELECT TOP 1 AlarmID, TriggerValue, TimeStamp FROM Alarm WHERE Acknowledged = 0 ORDER BY TimeStamp ASC";

            // Hent alarm grenser
            using (SqlConnection conn = new SqlConnection(connectionString))        //Code for connecting to database and extracting the alarm limits was suggested by Claude ai
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(alarmsql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    alarmHighLimit = Convert.ToDouble(reader["HighLimit"]);
                    alarmLowLimit = Convert.ToDouble(reader["LowLimit"]);
                }
            }
            alarmlimithtxt.Text = alarmHighLimit.ToString();
            alarmlimitltxt.Text = alarmLowLimit.ToString();

            // Hent siste measurement
            using (SqlConnection conn = new SqlConnection(connectionString))        //Code for connecting to database and extracting the latest measurement was suggested by Claude ai
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(measurementsql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Temperature = Convert.ToDouble(reader["Value"]);
                    SetPoint = Convert.ToDouble(reader["SetPoint"]);
                    ControlSignal = Convert.ToDouble(reader["ControlSignal"]);
                }
            }
            Temptxt.Text = Temperature.ToString("F2");
            Setpointtxt.Text = SetPoint.ToString("F2");
            ControlSignaltxt.Text = ControlSignal.ToString("F2");

            // Sjekk og insert alarm
            if (Temperature > alarmHighLimit)
            {
                string sqlInsert = $"INSERT INTO Alarm (AlarmLimitID, TriggerValue, TimeStamp, Acknowledged) VALUES (1, {Temperature}, GETDATE(), 0)";
                using (SqlConnection conn = new SqlConnection(connectionString))        //Code for connecting to database and inserting new alarm was suggested by Claude ai    
                {
                    conn.Open();
                    new SqlCommand(sqlInsert, conn).ExecuteNonQuery();
                }
            }
            else if (Temperature < alarmLowLimit)
            {
                string sqlInsert = $"INSERT INTO Alarm (AlarmLimitID, TriggerValue, TimeStamp, Acknowledged) VALUES (1, {Temperature}, GETDATE(), 0)";
                using (SqlConnection conn = new SqlConnection(connectionString))        //Code for connecting to database and inserting new alarm was suggested by Claude ai
                {
                    conn.Open();
                    new SqlCommand(sqlInsert, conn).ExecuteNonQuery();
                }
            }

            // Vis eldste uacknowledgede alarm
            using (SqlConnection conn = new SqlConnection(connectionString))            //Code for connecting to database and extracting the oldest unacknowledged alarm was suggested by Claude ai
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlGetAlarm, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    Alarmtxt.Text = Convert.ToDouble(reader["TriggerValue"]).ToString("F2") + " °C  " + Convert.ToDateTime(reader["TimeStamp"]).ToString("HH:mm:ss");
                else
                    Alarmtxt.Text = "";
            }
        }

        private void alarmHistoryBtn_Click(object sender, EventArgs e)
        {
            string sqlHistory = "SELECT * FROM Alarm ORDER BY TimeStamp DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))                    //Solution for extracting the data from database was suggested by Claude ai
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlHistory, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                alarmHistoryRtxt.Clear();

                while (reader.Read())
                {
                    alarmHistoryRtxt.AppendText(reader["AlarmID"] + " | " + reader["TriggerValue"] + " | " + reader["TimeStamp"] + " | " + reader["Acknowledged"] + "\n");
                }
            }
        }

        private void ackBtnHigh_Click(object sender, EventArgs e)
        {
           
        }

        private void ackBtnLow_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ackAlarmbtn_Click(object sender, EventArgs e)
        {
            string sqlAck = "UPDATE Alarm SET Acknowledged = 1 WHERE AlarmID = (SELECT TOP 1 AlarmID FROM Alarm WHERE Acknowledged = 0 ORDER BY TimeStamp ASC)";
            using (SqlConnection conn = new SqlConnection(connectionString))            //Code for connecting to database and acknowledging the oldest unacknowledged alarm was suggested by Claude ai
            {
                conn.Open();
                new SqlCommand(sqlAck, conn).ExecuteNonQuery();
                Alarmtxt.Text = "";
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM Alarm";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                new SqlCommand(sqlDelete, conn).ExecuteNonQuery();
                alarmHistoryRtxt.Clear();
                Alarmtxt.Text = "";
            }
        }
    }
}
