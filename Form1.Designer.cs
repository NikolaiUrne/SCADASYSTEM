namespace AlarmGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Alarmtxt = new System.Windows.Forms.TextBox();
            this.alarmHistoryBtn = new System.Windows.Forms.Button();
            this.Temptxt = new System.Windows.Forms.TextBox();
            this.ControlSignaltxt = new System.Windows.Forms.TextBox();
            this.Setpointtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.alarmlimitltxt = new System.Windows.Forms.TextBox();
            this.alarmlimithtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.alarmHistoryRtxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ackAlarmbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alarmtxt
            // 
            this.Alarmtxt.Location = new System.Drawing.Point(456, 112);
            this.Alarmtxt.Name = "Alarmtxt";
            this.Alarmtxt.Size = new System.Drawing.Size(100, 20);
            this.Alarmtxt.TabIndex = 3;
            // 
            // alarmHistoryBtn
            // 
            this.alarmHistoryBtn.Location = new System.Drawing.Point(226, 217);
            this.alarmHistoryBtn.Name = "alarmHistoryBtn";
            this.alarmHistoryBtn.Size = new System.Drawing.Size(121, 23);
            this.alarmHistoryBtn.TabIndex = 4;
            this.alarmHistoryBtn.Text = "Open alarm history";
            this.alarmHistoryBtn.UseVisualStyleBackColor = true;
            this.alarmHistoryBtn.Click += new System.EventHandler(this.alarmHistoryBtn_Click);
            // 
            // Temptxt
            // 
            this.Temptxt.Location = new System.Drawing.Point(238, 69);
            this.Temptxt.Name = "Temptxt";
            this.Temptxt.Size = new System.Drawing.Size(100, 20);
            this.Temptxt.TabIndex = 5;
            // 
            // ControlSignaltxt
            // 
            this.ControlSignaltxt.Location = new System.Drawing.Point(238, 112);
            this.ControlSignaltxt.Name = "ControlSignaltxt";
            this.ControlSignaltxt.Size = new System.Drawing.Size(100, 20);
            this.ControlSignaltxt.TabIndex = 6;
            // 
            // Setpointtxt
            // 
            this.Setpointtxt.Location = new System.Drawing.Point(238, 153);
            this.Setpointtxt.Name = "Setpointtxt";
            this.Setpointtxt.Size = new System.Drawing.Size(100, 20);
            this.Setpointtxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Control signal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Setpoint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "alarms to be acknowledged";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // alarmlimitltxt
            // 
            this.alarmlimitltxt.Location = new System.Drawing.Point(21, 153);
            this.alarmlimitltxt.Name = "alarmlimitltxt";
            this.alarmlimitltxt.Size = new System.Drawing.Size(100, 20);
            this.alarmlimitltxt.TabIndex = 13;
            // 
            // alarmlimithtxt
            // 
            this.alarmlimithtxt.Location = new System.Drawing.Point(21, 69);
            this.alarmlimithtxt.Name = "alarmlimithtxt";
            this.alarmlimithtxt.Size = new System.Drawing.Size(100, 20);
            this.alarmlimithtxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "AlarmHighLimit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "AlarmLowLimit";
            // 
            // alarmHistoryRtxt
            // 
            this.alarmHistoryRtxt.Location = new System.Drawing.Point(21, 246);
            this.alarmHistoryRtxt.Name = "alarmHistoryRtxt";
            this.alarmHistoryRtxt.Size = new System.Drawing.Size(535, 132);
            this.alarmHistoryRtxt.TabIndex = 17;
            this.alarmHistoryRtxt.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Alarm History";
            // 
            // ackAlarmbtn
            // 
            this.ackAlarmbtn.Location = new System.Drawing.Point(466, 139);
            this.ackAlarmbtn.Name = "ackAlarmbtn";
            this.ackAlarmbtn.Size = new System.Drawing.Size(75, 23);
            this.ackAlarmbtn.TabIndex = 19;
            this.ackAlarmbtn.Text = "ACK";
            this.ackAlarmbtn.UseVisualStyleBackColor = true;
            this.ackAlarmbtn.Click += new System.EventHandler(this.ackAlarmbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(226, 384);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(121, 23);
            this.Deletebtn.TabIndex = 20;
            this.Deletebtn.Text = "Delete History";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 423);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.ackAlarmbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.alarmHistoryRtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alarmlimithtxt);
            this.Controls.Add(this.alarmlimitltxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Setpointtxt);
            this.Controls.Add(this.ControlSignaltxt);
            this.Controls.Add(this.Temptxt);
            this.Controls.Add(this.alarmHistoryBtn);
            this.Controls.Add(this.Alarmtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Alarmtxt;
        private System.Windows.Forms.Button alarmHistoryBtn;
        private System.Windows.Forms.TextBox Temptxt;
        private System.Windows.Forms.TextBox ControlSignaltxt;
        private System.Windows.Forms.TextBox Setpointtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox alarmlimitltxt;
        private System.Windows.Forms.TextBox alarmlimithtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox alarmHistoryRtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ackAlarmbtn;
        private System.Windows.Forms.Button Deletebtn;
    }
}

