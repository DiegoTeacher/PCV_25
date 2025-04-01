using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class ScreamOnInput : Component
    {
        public override void Update()
        {
            char pressedKey = (char)Console.Read();

            if(pressedKey == 'W')
            {
                Console.Beep();
            }
        }
    }
}
