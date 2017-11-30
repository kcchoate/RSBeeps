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
    public partial class Form1 : Form
    {
        MainScreen screen;

        public Form1()
        {
            screen = new MainScreen();
            InitializeComponent();

            //initialize the screen 
            screen.InitializeScreen(timer1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            screen.TickScreenDown(richTextBox1);
        }
    }
}
