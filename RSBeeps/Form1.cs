using System;
using System.Media;
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
    public partial class Form1 : Form
    {
        //set to 48 so the initial beep is not followed by a beep from the timer
        private static int remainingTime = 49;
        private static bool firstbeep = true;
        static SoundPlayer beep = new SoundPlayer("C:\\Program Files (x86)\\RSBeeps\\Media\\beep.wav");

        public Form1()
        {
            InitializeComponent();

            //play an initial beep of the timer so that it beeps when started (otherwise it waits one second)
            beep.Play();

            //set the timer to tick every 1 second
            timer1.Interval = 1000;
            
            //start the timer. The timer will call the timer1_Tick event handler function every 1 second
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime == 49 && !firstbeep)
            {
                //drop the beep
                beep.Play();
            }
            //bring the beep back and shout it loud
            richTextBox1.Text = (--remainingTime).ToString();

            if (remainingTime == 0)
            {
                remainingTime = 49;
            }

            //set first beep to false
            firstbeep = false;
        }
    }
}
