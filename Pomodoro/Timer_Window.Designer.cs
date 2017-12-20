namespace Pomodoro
{
    partial class Timer_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer_Window));
            this.studyTimer = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sessionsRemainingTextBox = new System.Windows.Forms.TextBox();
            this.studyTimeLabel = new System.Windows.Forms.Label();
            this.breakTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studyTimer
            // 
            this.studyTimer.Interval = 750;
            this.studyTimer.Tick += new System.EventHandler(this.studyTimer_Tick);
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 750;
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Study: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Break:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of session remaining: ";
            // 
            // sessionsRemainingTextBox
            // 
            this.sessionsRemainingTextBox.BackColor = System.Drawing.Color.White;
            this.sessionsRemainingTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.sessionsRemainingTextBox.Location = new System.Drawing.Point(327, 425);
            this.sessionsRemainingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sessionsRemainingTextBox.Name = "sessionsRemainingTextBox";
            this.sessionsRemainingTextBox.ReadOnly = true;
            this.sessionsRemainingTextBox.Size = new System.Drawing.Size(75, 22);
            this.sessionsRemainingTextBox.TabIndex = 3;
            this.sessionsRemainingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // studyTimeLabel
            // 
            this.studyTimeLabel.AutoSize = true;
            this.studyTimeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.studyTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyTimeLabel.Location = new System.Drawing.Point(95, 86);
            this.studyTimeLabel.Name = "studyTimeLabel";
            this.studyTimeLabel.Size = new System.Drawing.Size(0, 91);
            this.studyTimeLabel.TabIndex = 4;
            // 
            // breakTimeLabel
            // 
            this.breakTimeLabel.AutoSize = true;
            this.breakTimeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.breakTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakTimeLabel.Location = new System.Drawing.Point(95, 287);
            this.breakTimeLabel.Name = "breakTimeLabel";
            this.breakTimeLabel.Size = new System.Drawing.Size(0, 91);
            this.breakTimeLabel.TabIndex = 5;
            // 
            // Timer_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(419, 455);
            this.Controls.Add(this.breakTimeLabel);
            this.Controls.Add(this.studyTimeLabel);
            this.Controls.Add(this.sessionsRemainingTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timer_Window";
            this.Text = "Study and Work with Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer studyTimer;
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sessionsRemainingTextBox;
        private System.Windows.Forms.Label studyTimeLabel;
        private System.Windows.Forms.Label breakTimeLabel;
    }
}