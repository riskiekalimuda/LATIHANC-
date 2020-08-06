using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public class MesinDarat : Mesin
    {
        public override void Hidupkan()
        {
            Console.WriteLine("Menghidupkan mesin darat");
        }

        public override void Matikan()
        {
            Console.WriteLine("Mematikan mesin darat");
        }
    }
}
