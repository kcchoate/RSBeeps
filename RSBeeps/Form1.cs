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

        public FormMain()
        {
            screen = new MainScreen();
            InitializeComponent();
        }

        //event handler for timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            screen.TickScreenDown(LabelTimeText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screen.TransitionScreen(buttonStart, labelInfo, LabelTimeText, timer1);
        }
    }
}
