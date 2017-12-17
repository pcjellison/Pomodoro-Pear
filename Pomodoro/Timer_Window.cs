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
        public Timer_Window(int workingMinutes, int breakMinutes, int numOfSessions)
        {
            InitializeComponent();

            sessionsRemainingTextBox.Text = Convert.ToString(numOfSessions);
        }
    }
}
