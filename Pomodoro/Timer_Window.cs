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
    public partial class Timer_Window : Form
    {
        int timeLeft;   //global variable used by both timers to track time remaining
        bool studyNow;
        int workingMin;
        int breakMin;
        int numSessions;

        public Timer_Window(int workingMinutes, int breakMinutes, int numOfSessions, bool studyNowBool)
        {
            InitializeComponent();

            studyNow = studyNowBool;
            workingMin = workingMinutes;
            breakMin = breakMinutes;
            numSessions = numOfSessions;
            numSessions--;
            sessionsRemainingTextBox.Text = Convert.ToString(numSessions);
            if(studyNow)
            {
                timeLeft = workingMin * 60;
                studyTimer.Start();
            }
            else
            {
                timeLeft = breakMin * 60;
                breakTimer.Start();
            }
        }

        //This code is in thanks to Microsoft Documentation and Nomad101 on Stack overflow.
        //These guides can be found at:
        //https://msdn.microsoft.com/en-us/library/dd492144.aspx
        //https://stackoverflow.com/questions/16620234/how-to-do-a-30-minute-count-down-timer

        private void studyTimer_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                studyTimeLabel.Text = Convert.ToString(timeLeft / 60) + ":" + ((timeLeft % 60) >= 10 ? (timeLeft % 60).ToString() : "0" + timeLeft % 60);
            }
            else
            {
                studyNow = false;
                studyTimer.Stop();
                var switchWindow = new Switch_Window();
                if(switchWindow.ShowDialog() == DialogResult.OK)
                {
                    timeLeft = breakMin * 60;
                    breakTimer.Start();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                breakTimeLabel.Text = Convert.ToString(timeLeft / 60) + ":" + ((timeLeft % 60) >= 10 ? (timeLeft % 60).ToString() : "0" + timeLeft % 60);
            }
            else if (numSessions == 0)
            {
                this.Close();
            }
            else
            {
                studyNow = true;
                numSessions--;
                breakTimer.Stop();
                var switchWindow = new Switch_Window();
                if(switchWindow.ShowDialog() == DialogResult.OK)
                {
                    timeLeft = workingMin = 60;
                    studyTimer.Start();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
