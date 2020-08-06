using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public abstract class Mesin
    {
        public abstract void Hidupkan();
        public abstract void Matikan();
        public void Picu(string pemicu)
        {
            Console.WriteLine(pemicu);
        }
    }
}
