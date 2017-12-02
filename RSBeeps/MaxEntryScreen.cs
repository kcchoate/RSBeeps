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
    public class MaxEntryScreen
    {
        private MainScreen screen;
        private Label numberText;
        private Timer timer;

        //constructor
        public MaxEntryScreen(MainScreen _screen, Label _mainScreenText, Timer _timer)
        {
            screen = _screen;
            numberText = _mainScreenText;
            timer = _timer;
        }

        //updates the maximum number for the main screen.
        public void UpdateMax(NumericUpDown text)
        {
            int newMax;
            try
            {
                newMax = (int)text.Value;
                if (newMax < 1 || newMax > 999)
                {
                    throw new Exception();
                }

                screen.ChangeMaxTime(newMax);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid time entry. Time must be a whole value greater than 0 and less than 1000.", "Error");
            }
        }

    }
}
