using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    class Street
    {
        House[] houses;
        public int count = 0;
        public int max;
        public Street(int Mx)
        {
            max = Mx;
            houses = new House[Mx];
        }

        public Street() : this(10){}
        public void AddHouse(House h)
        {
            if (count < max) houses[count++] = h;

        }
        
        public void Draw()
        {
            for (int i=0;i<count;i++)
            {
                houses[i].Draw();
            }
        }
    }
}
