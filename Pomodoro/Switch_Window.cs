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
    public partial class Switch_Window : Form
    {
        int workingMin;
        int breakMin;
        int numSessions;
        bool study;
        public Switch_Window(int workingMinutes, int breakMinutes, int numOfSessions, bool studyNowBool)
        {
            InitializeComponent();

            workingMin = workingMinutes;
            breakMin = breakMinutes;
            numSessions = numOfSessions;
            study = studyNowBool;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            
            var timerWindow = new Timer_Window(workingMin, breakMin, numSessions, study);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            var mainWindow = new Main_Window();
            mainWindow.Show();
        }
    }
}
