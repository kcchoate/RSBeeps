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
    public class MainScreen
    {

        //Constructor
        public MainScreen()
        {
         
        }

        
        

        public void TickDown()
        {
            if (remainingTime == 49 && !firstbeep)
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

            //set first beep to false
            firstbeep = false;
        }

    }
    

    
}