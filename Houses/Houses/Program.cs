using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Houses
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            var s = new Street();
           s.AddHouse( new House(100, 100, 50));
            s.Draw();
           s.AddHouse( new House(200, 200, 100));
            
            s.AddHouse(  new House());
            s.Draw();
            //h1.Color="red";
            //h2.Color="green";
            //h3.Color="cyan";
        }
       
    }
}
