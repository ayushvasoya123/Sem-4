using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Rectangle
    {
        public int l;
        public int w;

        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }

        public void AreaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is : " + (l * w)+" Here length is : "+l+" and width is : "+w);
        }
    }
}
