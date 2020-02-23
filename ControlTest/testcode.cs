using System;
using System.Collections.Generic;
using System.Text;

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
                object q = Debug.WriteLine("Button is Pressed");
                return q;
            }
            else
            {
                object p = Debug.WriteLine("Button is Not Pressed");
                return p;
            }

        }

    }
}
