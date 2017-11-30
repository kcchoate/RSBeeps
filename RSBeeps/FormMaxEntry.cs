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
    public partial class FormMaxEntry : Form
    {
        MaxEntryScreen screen;
        public FormMaxEntry(MainScreen _screen, Label _time, Timer _timer)
        {
            screen = new MaxEntryScreen(_screen, _time, _timer);
            InitializeComponent();
        }

        //calls screen functionality class to update the maximum
        private void buttonSave_Click(object sender, EventArgs e)
        {
            screen.UpdateMax(numericUpDownTime);
            //hide the screen
            Hide();
        }

        //called when a key is pressed on the number entry. Checks if key was enter and if so mimics the buttonSave_Click even
        private void numericUpDownTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                screen.UpdateMax(numericUpDownTime);
                //hide the screen
                Hide();
            }
        }
    }
}
