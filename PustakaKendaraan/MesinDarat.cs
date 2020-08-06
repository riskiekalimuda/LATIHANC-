using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    internal class MesinDarat : Mesin
    {
        internal override void Hidupkan()
        {
            Console.WriteLine("Menghidupkan mesin darat");
        }

        internal override void Matikan()
        {
            Console.WriteLine("Mematikan mesin darat");
        }
    }
}
