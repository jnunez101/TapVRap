using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.forms;

namespace ControlTest
{
    class testcode
    {   
        public void mainoutput()
        {
            var x = randomNumber(1, 7);
            char y = buttonPressed(x);
            bool z = IsKeyDown(y);

            if (z == true)
            {
                MessageBox.Show("Button is Pressed");
                return q;
            }
            else
            {
                MessageBox.Show("Button is Not Pressed");
                return p;
            }

        }

    }
}
