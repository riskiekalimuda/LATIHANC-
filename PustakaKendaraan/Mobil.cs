using PustakaAntarMuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public class Mobil : IKendaraan
    {
        private readonly MesinDarat _mesinMobil;
        public Mobil()
        {
            _mesinMobil = new MesinDarat();
        }

        public void Jalankan()
        {
            Console.WriteLine("Menjalankan Mobil: ");
            _mesinMobil.Hidupkan();
            _mesinMobil.Picu("Injak pedal gas");
            _mesinMobil.Matikan();

        }
    }
}
