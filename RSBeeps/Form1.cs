﻿using System;
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
            screen = new MainScreen();
            paused = false;
            InitializeComponent();
        }

        //event handler for timer1, calls to tick down the screen if not paused
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!paused)
            {
                screen.TickScreenDown(LabelTimeText);
            }
        }

        private void buttonStartClick(object sender, EventArgs e)
        {
            ToolStripMenuItem[] toolStripItems = new ToolStripMenuItem[] { fileToolStripMenuItem, restartToolStripMenuItem, startPauseToolStripMenuItem };
            screen.TransitionScreen(buttonStart, labelInfo, LabelTimeText, timer1, toolStripItems);
        }

        //fired from File > Restart. Restarts the timer at 50.
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screen.RestartTimer(LabelTimeText, timer1);
        }

        private void startPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paused = !paused;
        }
    }
}
