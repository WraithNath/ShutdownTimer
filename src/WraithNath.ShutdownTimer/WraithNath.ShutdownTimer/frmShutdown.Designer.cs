namespace WraithNath.ShutdownTimer
{
    partial class frmShutdown
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudHours = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMinutes = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSeconds = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHours = new DarkUI.Controls.DarkLabel();
            this.lblMinutes = new DarkUI.Controls.DarkLabel();
            this.lblSeconds = new DarkUI.Controls.DarkLabel();
            this.btnShutdown = new DarkUI.Controls.DarkButton();
            this.btnExit = new DarkUI.Controls.DarkButton();
            this.lblTimer = new DarkUI.Controls.DarkTitle();
            this.grpInterval = new DarkUI.Controls.DarkGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.grpInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(19, 37);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(58, 20);
            this.nudHours.TabIndex = 0;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(83, 37);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(58, 20);
            this.nudMinutes.TabIndex = 1;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(147, 37);
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(58, 20);
            this.nudSeconds.TabIndex = 2;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblHours.Location = new System.Drawing.Point(16, 21);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblMinutes.Location = new System.Drawing.Point(80, 21);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(47, 13);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblSeconds.Location = new System.Drawing.Point(144, 21);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblSeconds.TabIndex = 6;
            this.lblSeconds.Text = "Seconds:";
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(12, 130);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Padding = new System.Windows.Forms.Padding(5);
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 7;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(160, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(80, 93);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(90, 25);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "00:00:00";
            // 
            // grpIntervl
            // 
            this.grpInterval.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grpInterval.Controls.Add(this.nudSeconds);
            this.grpInterval.Controls.Add(this.nudHours);
            this.grpInterval.Controls.Add(this.nudMinutes);
            this.grpInterval.Controls.Add(this.lblHours);
            this.grpInterval.Controls.Add(this.lblSeconds);
            this.grpInterval.Controls.Add(this.lblMinutes);
            this.grpInterval.Location = new System.Drawing.Point(12, 12);
            this.grpInterval.Name = "grpIntervl";
            this.grpInterval.Size = new System.Drawing.Size(223, 73);
            this.grpInterval.TabIndex = 10;
            this.grpInterval.TabStop = false;
            this.grpInterval.Text = "Interval";
            // 
            // frmShutdown
            // 
            this.AcceptButton = this.btnShutdown;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(247, 165);
            this.Controls.Add(this.grpInterval);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShutdown);
            this.Name = "frmShutdown";
            this.Text = "Shutdown Timer";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.grpInterval.ResumeLayout(false);
            this.grpInterval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkNumericUpDown nudHours;
        private DarkUI.Controls.DarkNumericUpDown nudMinutes;
        private DarkUI.Controls.DarkNumericUpDown nudSeconds;
        private DarkUI.Controls.DarkLabel lblHours;
        private DarkUI.Controls.DarkLabel lblMinutes;
        private DarkUI.Controls.DarkLabel lblSeconds;
        private DarkUI.Controls.DarkButton btnShutdown;
        private DarkUI.Controls.DarkButton btnExit;
        private DarkUI.Controls.DarkTitle lblTimer;
        private DarkUI.Controls.DarkGroupBox grpInterval;
    }
}