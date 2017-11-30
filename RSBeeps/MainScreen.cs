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
        private int maxTime;
        private int remainingTime;
        private bool firstBeepPlayed;
        private SoundPlayer soundPlayer;

        //Constructor
        public MainScreen()
        {
            maxTime = 49;
            remainingTime = maxTime;
            firstBeepPlayed = true;
            soundPlayer = new SoundPlayer("C:\\Program Files (x86)\\RSBeeps\\Media\\beep.wav");
        }

        //beeps once and then configures and starts the timer.
        private void StartScreen(Timer timer)
        {
            //play an initial beep of the timer so that it beeps when started (otherwise it waits one second)
            beep();
            firstBeepPlayed = true;

            //set the timer to tick every 1 second
            timer.Interval = 1000;

            //start the timer. The timer will call the timer1_Tick event handler function every 1 second
            timer.Start();
        }

        //enables the toolbar items that are passed
        private void EnableToolbarItems(ToolStripMenuItem[] toolbaritems)
        {
            foreach (ToolStripMenuItem item in toolbaritems)
            {
                item.Enabled = true;
            }
        }

        //uses the SoundPlayer to play the .wav 
        private void beep()
        {
            soundPlayer.Play();
        }

        //disables button, displays labels, and starts timer countdown
        public void TransitionScreen(Button button, Label message, Label time, Timer timer, ToolStripMenuItem[] toolbaritems)
        {
            //disable button 
            button.Enabled = false;
            button.Visible = false;
            //enable labels and toolbar item
            message.Visible = true;
            time.Visible = true;
            EnableToolbarItems(toolbaritems);

            StartScreen(timer);
        }

        //Plays the sound once every maxTime seconds (assumes timer interval is 1000ms) and resets timer to maxTime when time is 0
        public void TickScreenDown(Label text)
        {
            if (remainingTime == maxTime && !firstBeepPlayed)
            {
                //drop the beep
                beep();
            }
            //bring the beep back and shout it loud
            text.Text = (--remainingTime).ToString();

            if (remainingTime == 0)
            {
                remainingTime = maxTime;
            }
        }

        //sets the max time and restarts the timer if it has been started
        public void ChangeMaxTime(int newTime, Label time, Timer timer)
        {
            maxTime = newTime;
            //check to see if the time is visible, if it then we've started and we want to restart the timer
            if (time.Visible == true)
            {
                RestartTimer(time, timer);
            }
        }

        //restarts the timer
        public void RestartTimer(Label time, Timer timer)
        {
            //stop the timer, reset time, then call start the screen again
            timer.Stop();
            remainingTime = maxTime;
            time.Text = maxTime.ToString();
            StartScreen(timer);
        }
       
    } 
}