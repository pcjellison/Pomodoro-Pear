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
        public Switch_Window()
        {
            InitializeComponent();

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;    //sets dialog result to OK if user wants to continue
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    //sets dialog result to Cancel if user wants to quit
        }
    }
}
