using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    internal abstract class Mesin
    {
        internal abstract void Hidupkan();
        internal abstract void Matikan();
        internal void Picu(string pemicu)
        {
            Console.WriteLine(pemicu);
        }
    }
}
