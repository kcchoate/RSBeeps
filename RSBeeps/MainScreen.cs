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
    public class MainScreen
    {

        private int remainingTime;
        private bool firstbeep;
        private SoundPlayer soundPlayer;

        //Constructor
        public MainScreen()
        {
            //set to 48 so the initial beep is not followed by a beep from the timer
            remainingTime = 49;
            firstbeep = true;
            soundPlayer = new SoundPlayer("C:\\Program Files (x86)\\RSBeeps\\Media\\beep.wav");
        }
    
        public void TickScreenDown(RichTextBox text)
        {
            if (remainingTime == 49 && !firstbeep)
            {
                //drop the beep
                soundPlayer.Play();
            }
            //bring the beep back and shout it loud
            text.Text = (--remainingTime).ToString();

            if (remainingTime == 0)
            {
                remainingTime = 49;
            }

            //set first beep to false
            firstbeep = false;
        }


        public void InitializeScreen(Timer timer)
        {
            //play an initial beep of the timer so that it beeps when started (otherwise it waits one second)
            beep();

            //set the timer to tick every 1 second
            timer.Interval = 1000;

            //start the timer. The timer will call the timer1_Tick event handler function every 1 second
            timer.Start();
        }
        public void beep()
        {
            soundPlayer.Play();
        }

    } 
}