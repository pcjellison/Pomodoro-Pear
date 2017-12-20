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
//-------------------GLOBAL VARIABLES----------------
        int timeLeft;   //used by both timers to track time remaining
        bool studyNow;  //used to check if study timer needs to be activated or deactivated
        int workingMin; //number of minutes user wants to spend studying/working
        int breakMin;   //number of minutes user wants to spend relaxing
        int numSessions;//number of sessions (work and break is one session) user wants to complete
   

        public Timer_Window(int workingMinutes, int breakMinutes, int numOfSessions, bool studyNowBool)
        {
            InitializeComponent();

            studyNow = studyNowBool;    //used to check if study timer needs to be activated (true) or deactivated (false)
            workingMin = workingMinutes;//number of minutes user wants to spend studying/working
            breakMin = breakMinutes;    //number of minutes user wants to spend relaxing
            numSessions = numOfSessions;//number of sessions user wants to complete
            numSessions--;  //decrements number of sessions remaining after current
            sessionsRemainingTextBox.Text = Convert.ToString(numSessions);  //displays number of sessions remaining after current
            if(studyNow) //if study timer needs to be activated
            {
                timeLeft = workingMin * 60; //sets time spent working in minutes
                studyTimer.Start(); //start study timer
            }
            else
            {
                timeLeft = breakMin * 60;   //sets time spent on break in minutes
                breakTimer.Start();         //starts break timer
            }
        }

        //This code is in thanks to Microsoft Documentation and Nomad101 on Stack overflow.
        //These guides can be found at:
        //https://msdn.microsoft.com/en-us/library/dd492144.aspx
        //https://stackoverflow.com/questions/16620234/how-to-do-a-30-minute-count-down-timer

        private void studyTimer_Tick(object sender, EventArgs e)
        {
            breakTimeLabel.Text = ("0:00");
            sessionsRemainingTextBox.Text = Convert.ToString(numSessions);  //displays number of sessions remaining after current
            if (timeLeft > 0)    //if there is no time remaining
            {
                timeLeft = timeLeft - 1;    //decrements time remaining by 1 second
                studyTimeLabel.Text = Convert.ToString(timeLeft / 60) + ":" + ((timeLeft % 60) >= 10 ? (timeLeft % 60).ToString() : "0" + timeLeft % 60);   //displays time remaining in minutes
            }
            else
            {
                studyNow = false;   //deactivates study timer
                studyTimer.Stop();  //stops study timer
                var switchWindow = new Switch_Window(); //displays window notifying user of switch
                if(switchWindow.ShowDialog() == DialogResult.OK)    //if user wants to continue
                {
                    timeLeft = breakMin * 60;   //sets time remaining in minutes
                    breakTimer.Start(); //starts break timer
                }
                else
                {
                    Application.Exit(); //if user wants to quit it closes entire application
                }
            }
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            studyTimeLabel.Text = ("0:00");
            sessionsRemainingTextBox.Text = Convert.ToString(numSessions);  //displays number of sessions remaining after current
            if (timeLeft > 0)   //if there is no time remaining
            {
                timeLeft = timeLeft - 1;    //decrement time remaining by a second
                breakTimeLabel.Text = Convert.ToString(timeLeft / 60) + ":" + ((timeLeft % 60) >= 10 ? (timeLeft % 60).ToString() : "0" + timeLeft % 60);   //displays time remaining
            }
            else if (numSessions == 0)  //if there are no sessions remaining
            {
                this.Close();   //closes current window
            }
            else
            {
                studyNow = true;    //activates study timer
                numSessions--;      //decrements number of sessions remaining
                breakTimer.Stop();  //stops break timer
                var switchWindow = new Switch_Window(); //displays window notifying user to switch timers
                if(switchWindow.ShowDialog() == DialogResult.OK)    //if user wants to continue
                {
                    timeLeft = workingMin * 60; //sets time remaining to study minutes
                    studyTimer.Start(); //starts study timer
                }
                else
                {
                    Application.Exit(); //if user doesn't want to continue, closes application
                }
            }
        }
    }
}
