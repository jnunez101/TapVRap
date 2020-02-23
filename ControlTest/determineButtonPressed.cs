using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTest
{
    class determineButtonPressed
    {
        public int buttonPressed(var input)
        {
            System.Windows.Input.Key button;
            if (input == 1)
            {
                // Q = Trigger + A
                button.Key = Key.Q;
            }
            else if (input == 2)
            {
                // W = Trigger + B
                button.Key = Key.W;
            }
            else if (input == 3)
            {
                // E = Trigger
                button.Key = Key.E;
            }
            else if (input == 4)
            {
                button.Key = Key.A;
            }
            else if (input == 5)
            {
                button.Key = Key.B;
            }
            else if (input == 6)
            {
                button.Key = Key.X;
            }
            else if (input == 7)
            {
                button.Key = Key.Y;
            }
            return button;
        }
    }
}
