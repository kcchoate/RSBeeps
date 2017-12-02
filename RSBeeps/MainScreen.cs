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
        private Label timeLabel;
        private Label infoLabel;
        private Timer timer;
        private Button goButton;
        private Button startPauseButton;
        private Button restartButton;


        //Constructor: passed by reference so that changes to a passed object appear on the screen
        public MainScreen(ref Label _time, ref Label _info, ref Timer _timer, ref Button _go, ref Button _startPause, ref Button _restart)
        {
            maxTime = 50;
            remainingTime = maxTime;
            firstBeepPlayed = false;
            soundPlayer = new SoundPlayer("C:\\Program Files (x86)\\RSBeeps\\Media\\beep.wav");
            timeLabel = _time;
            infoLabel = _info;
            timer = _timer;
            goButton = _go;
            startPauseButton = _startPause;
            restartButton = _restart;
            timeLabel.Text = maxTime.ToString();
        }

        //beeps once and then configures and starts the timer.
        private void StartScreen()
        {
            //play an initial beep of the timer so that it beeps when started (otherwise it waits one second)
            beep();

            //set the timer to tick every 1 second
            timer.Interval = 1000;

            //start the timer. The timer will call the timer1_Tick event handler function every 1 second
            timer.Start();
        }

        //enables the toolbar items that are passed
        /*private void EnableToolbarItems(ToolStripMenuItem[] toolbaritems)
        {
            foreach (ToolStripMenuItem item in toolbaritems)
            {
                item.Enabled = true;
            }
        }*/

        //uses the SoundPlayer to play the .wav 
        private void beep()
        {
            soundPlayer.Play();
        }

        //disables button, displays labels, and starts timer countdown
        public void TransitionScreen()
        {
            //enable labels and buttons
            timeLabel.Visible = true;
            infoLabel.Visible = true;
            startPauseButton.Enabled = true;
            restartButton.Enabled = true;

            //Hide start button
            goButton.Enabled = false;
            goButton.Visible = false;

            StartScreen();
        }

        //Plays the sound once every maxTime seconds (assumes timer interval is 1000ms) and resets timer to maxTime when time is 0
        public void TickScreenDown(Label text)
        {

            //bring the beep back and shout it loud
            remainingTime--;

            if (remainingTime == 0)
            {
                remainingTime = maxTime;
            }

            text.Text = remainingTime.ToString();

            if (remainingTime == maxTime && firstBeepPlayed)
            {
                //drop the beep
                beep();
            }
           
            //intentionally set to true even if the beep isn't played by this function the first run. Allows for us to avoid the
            //situation in which a beep is played when started and when this function runs for the first time a second later.
            firstBeepPlayed = true;
        }

        //sets the max time and restarts the timer if it has been started
        public void ChangeMaxTime(int newTime)
        {
            maxTime = newTime;
            //check to see if the time is visible, if it then we've started and we want to restart the timer
            if (timeLabel.Visible == true)
            {
                RestartTimer();
            }
        }

        //restarts the timer
        public void RestartTimer()
        {
            //stop the timer, reset time, reset first beep status, then call start the screen again
            timer.Stop();
            remainingTime = maxTime;
            timeLabel.Text = maxTime.ToString();
            StartScreen();
        }
       
    } 
}