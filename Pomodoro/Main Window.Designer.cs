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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.breakNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sessionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of minutes working:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of break minutes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of session:";
            // 
            // studyNumericUpDown
            // 
            this.studyNumericUpDown.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyNumericUpDown.Location = new System.Drawing.Point(341, 39);
            this.studyNumericUpDown.Name = "studyNumericUpDown";
            this.studyNumericUpDown.Size = new System.Drawing.Size(70, 22);
            this.studyNumericUpDown.TabIndex = 3;
            // 
            // breakNumericUpDown
            // 
            this.breakNumericUpDown.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakNumericUpDown.Location = new System.Drawing.Point(341, 100);
            this.breakNumericUpDown.Name = "breakNumericUpDown";
            this.breakNumericUpDown.Size = new System.Drawing.Size(69, 22);
            this.breakNumericUpDown.TabIndex = 4;
            // 
            // sessionNumericUpDown
            // 
            this.sessionNumericUpDown.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionNumericUpDown.Location = new System.Drawing.Point(341, 164);
            this.sessionNumericUpDown.Name = "sessionNumericUpDown";
            this.sessionNumericUpDown.Size = new System.Drawing.Size(69, 22);
            this.sessionNumericUpDown.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(74, 226);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(267, 75);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 313);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sessionNumericUpDown);
            this.Controls.Add(this.breakNumericUpDown);
            this.Controls.Add(this.studyNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main_Window";
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
    }
}

