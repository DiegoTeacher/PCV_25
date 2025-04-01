using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class SpriteRenderer : Component
    {
        public ConsoleColor color;
        public char sprite;

        public override void Update()
        {
            Console.BackgroundColor = color;
            Console.WriteLine(sprite);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
