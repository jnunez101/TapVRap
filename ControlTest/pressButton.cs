using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTest
{
    class pressButton
    {
        public int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
