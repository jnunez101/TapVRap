using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTest
{
    class keyboardBinding
    {
        public static bool IsKeyDown(System.Windows.Input.Key key)
        {
            if (Keyboard.IsKeyDown(Key.Return))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    