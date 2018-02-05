using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Houses
{
    class House
    {
        public static int count = 0;
        private string color;
        public string Color {
            get{ return color; }
            set {color=value;
                GraphicsWindow.PenColor = color;
                Draw();
            } }
        int x, y, size;
        public House(int Xx, int Yy, int Size)
        {
            x = Xx; y = Yy; size = Size;
            count++;
            Console.WriteLine("There {0} houses created",count);
        }
        public void Draw()
        {
            GraphicsWindow.DrawRectangle(x, y, size, size);
            GraphicsWindow.DrawTriangle(x, y, x + size / 2, y - size / 2, x + size, y);
            GraphicsWindow.DrawRectangle(x + size / 4, y + size / 4, size / 2, size / 2);
        }
        public House() : this(300, 300, 100)
        {
            count++;
            Console.WriteLine("There {0} houses created", count);
        }
    }
}
