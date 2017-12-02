using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSBeeps
{
    public partial class FormMain : Form
    {
        MainScreen screen;
        Boolean paused;

        public FormMain()
        {
            paused = false;
            InitializeComponent();
            screen = new MainScreen(ref LabelTimeText, ref labelInfo, ref timer1, ref buttonStart, ref buttonPauseStart, ref buttonRestart);
        }

        //event handler for timer1, calls to tick down the screen if not paused
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!paused)
            {
                screen.TickScreenDown(LabelTimeText);
            }
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            screen.TransitionScreen();
        }

        //fired from File > Restart. Restarts the timer at 50.
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            screen.RestartTimer();
        }

        //starts and pauses the timer and changes the top label to provide more info
        private void buttonPauseStart_Click(object sender, EventArgs e)
        {
            paused = !paused;
            if (paused)
            {
                labelInfo.Text = "PAUSED";
                buttonPauseStart.Text = "Start";
            }
            else
            {
                labelInfo.Text = "Time to next beep";
                buttonPauseStart.Text = "Pause";
            }
        }

        //pulls up form for max timer entry
        private void buttonMaxTime_Click(object sender, EventArgs e)
        {
            FormMaxEntry newMaxScreen = new FormMaxEntry(screen, LabelTimeText, timer1);
            newMaxScreen.Show();
        }
    }
}
