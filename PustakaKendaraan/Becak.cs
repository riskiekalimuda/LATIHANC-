using PustakaAntarMuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public class Becak : IKendaraan
    {
        public void Jalankan()
        {
            Console.WriteLine("Menjalankan Sepeda: ");
            Console.WriteLine("Mengayuh Sepeda");
        }
    }
}
