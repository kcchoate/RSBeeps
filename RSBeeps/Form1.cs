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
        private static int remainingTime = 49;

        public Form1()
        {
            InitializeComponent();

            //set the timer to tick every 1 second
            timer1.Interval = 1000;

            //start the timer. The timer will call the timer1_Tick event handler function every 1 second
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer beep = new SoundPlayer("..\\..\\beep.wav");
            if (remainingTime == 49)
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
        }
    }
}
