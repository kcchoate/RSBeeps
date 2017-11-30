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
        
        //Plays the sound once every 50 seconds (assumes timer interval is 1000ms) and resets timer to 49 when time is 0
        public void TickScreenDown(Label text)
        {
            if (remainingTime == 49 && !firstbeep)
            {
                //drop the beep
                beep();
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

        //disables button, displays labels, and starts timer countdown
        public void TransitionScreen(Button button, Label message, Label time, Timer timer)
        {
            //disable button
            button.Enabled = false;
            button.Visible = false;
            //enable labels
            message.Visible = true;
            time.Visible = true;

            StartScreen(timer);
        }
        
        //beeps once and then configures and starts the timer.
        public void StartScreen(Timer timer)
        {
            //play an initial beep of the timer so that it beeps when started (otherwise it waits one second)
            beep();

            //set the timer to tick every 1 second
            timer.Interval = 1000;

            //start the timer. The timer will call the timer1_Tick event handler function every 1 second
            timer.Start();
        }

        //uses the SoundPlayer to play the .wav 
        private void beep()
        {
            soundPlayer.Play();
        }

    } 
}