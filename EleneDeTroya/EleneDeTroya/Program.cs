using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Griego g1 = new Griego();
            Troyano t1 = new Troyano();

            t1.Retirarse();
            Console.ReadLine();

            g1.Retirarse("herido");

            Console.ReadLine();
        }
    }
}
