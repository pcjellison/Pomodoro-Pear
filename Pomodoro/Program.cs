using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Window());
        }
    }
}

/*The icon photo was created by PixelKit on veryicon.com
 *The photo has been listed as free for non-commercial use by the author
 * Source: https://m.veryicon.com/icons/system/swanky-outlines/15-light-bulb.html
 */
