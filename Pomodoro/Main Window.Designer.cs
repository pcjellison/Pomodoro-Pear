namespace Pomodoro
{
    partial class Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.breakNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sessionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.studyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of minutes working:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of break minutes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of session:";
            // 
            // studyNumericUpDown
            // 
            this.studyNumericUpDown.AutoSize = true;
            this.studyNumericUpDown.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.studyNumericUpDown.Location = new System.Drawing.Point(512, 45);
            this.studyNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.studyNumericUpDown.Name = "studyNumericUpDown";
            this.studyNumericUpDown.Size = new System.Drawing.Size(105, 26);
            this.studyNumericUpDown.TabIndex = 3;
            // 
            // breakNumericUpDown
            // 
            this.breakNumericUpDown.AutoSize = true;
            this.breakNumericUpDown.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakNumericUpDown.Location = new System.Drawing.Point(512, 115);
            this.breakNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.breakNumericUpDown.Name = "breakNumericUpDown";
            this.breakNumericUpDown.Size = new System.Drawing.Size(104, 26);
            this.breakNumericUpDown.TabIndex = 4;
            // 
            // sessionNumericUpDown
            // 
            this.sessionNumericUpDown.AutoSize = true;
            this.sessionNumericUpDown.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionNumericUpDown.Location = new System.Drawing.Point(512, 189);
            this.sessionNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.sessionNumericUpDown.Name = "sessionNumericUpDown";
            this.sessionNumericUpDown.Size = new System.Drawing.Size(104, 26);
            this.sessionNumericUpDown.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.startButton.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(111, 261);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(400, 103);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sessionNumericUpDown);
            this.Controls.Add(this.breakNumericUpDown);
            this.Controls.Add(this.studyNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study and Work with Pomodoro";
            ((System.ComponentModel.ISupportInitialize)(this.studyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown studyNumericUpDown;
        private System.Windows.Forms.NumericUpDown breakNumericUpDown;
        private System.Windows.Forms.NumericUpDown sessionNumericUpDown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.HelpProvider help;
    }
}

