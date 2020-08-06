using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public class MesinTerbang : Mesin
    {
        public override void Hidupkan()
        {
            Console.WriteLine("Menghidupkan mesin terbang");
        }

        public override void Matikan()
        {
            Console.WriteLine("Mematikan mesin terbang");
        }
    }
}
