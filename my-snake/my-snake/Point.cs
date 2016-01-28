using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
