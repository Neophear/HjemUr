namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDaysText = new System.Windows.Forms.Label();
            this.lblHoursText = new System.Windows.Forms.Label();
            this.lblMinutesText = new System.Windows.Forms.Label();
            this.lblSecondsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(15, 189);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(33, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Dage";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(15, 202);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(33, 13);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "Timer";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(15, 215);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(45, 13);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "Minutter";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(15, 228);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(53, 13);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "Sekunder";
            // 
            // lblDaysText
            // 
            this.lblDaysText.AutoSize = true;
            this.lblDaysText.Location = new System.Drawing.Point(97, 189);
            this.lblDaysText.Name = "lblDaysText";
            this.lblDaysText.Size = new System.Drawing.Size(13, 13);
            this.lblDaysText.TabIndex = 8;
            this.lblDaysText.Text = "0";
            // 
            // lblHoursText
            // 
            this.lblHoursText.AutoSize = true;
            this.lblHoursText.Location = new System.Drawing.Point(97, 202);
            this.lblHoursText.Name = "lblHoursText";
            this.lblHoursText.Size = new System.Drawing.Size(13, 13);
            this.lblHoursText.TabIndex = 9;
            this.lblHoursText.Text = "0";
            // 
            // lblMinutesText
            // 
            this.lblMinutesText.AutoSize = true;
            this.lblMinutesText.Location = new System.Drawing.Point(97, 215);
            this.lblMinutesText.Name = "lblMinutesText";
            this.lblMinutesText.Size = new System.Drawing.Size(13, 13);
            this.lblMinutesText.TabIndex = 10;
            this.lblMinutesText.Text = "0";
            // 
            // lblSecondsText
            // 
            this.lblSecondsText.AutoSize = true;
            this.lblSecondsText.Location = new System.Drawing.Point(97, 228);
            this.lblSecondsText.Name = "lblSecondsText";
            this.lblSecondsText.Size = new System.Drawing.Size(13, 13);
            this.lblSecondsText.TabIndex = 11;
            this.lblSecondsText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 250);
            this.Controls.Add(this.lblSecondsText);
            this.Controls.Add(this.lblMinutesText);
            this.Controls.Add(this.lblHoursText);
            this.Controls.Add(this.lblDaysText);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblDaysText;
        private System.Windows.Forms.Label lblHoursText;
        private System.Windows.Forms.Label lblMinutesText;
        private System.Windows.Forms.Label lblSecondsText;
    }
}

