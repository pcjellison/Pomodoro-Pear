using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int workingMinutes = Convert.ToInt32(studyNumericUpDown.Value); //number of minutes user wants to focus study
            int breakMinutes = Convert.ToInt32(breakNumericUpDown.Value);   //number of minutes user wants to break
            int numOfSessions = Convert.ToInt32(sessionNumericUpDown.Value);    //number of sessions user would like to study/break for
            bool studyNow = true;

            var timerWindow = new Timer_Window(workingMinutes, breakMinutes, numOfSessions, studyNow);
            timerWindow.Show();
        }
    }
}
