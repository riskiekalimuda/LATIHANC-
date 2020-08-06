using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    internal class MesinTerbang : Mesin
    {
        internal override void Hidupkan()
        {
            Console.WriteLine("Menghidupkan mesin terbang");
        }

        internal override void Matikan()
        {
            Console.WriteLine("Mematikan mesin terbang");
        }
    }
}
