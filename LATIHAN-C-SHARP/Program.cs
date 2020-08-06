using PustakaAktor;
using PustakaAntarMuka;
using PustakaKendaraan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    //SUMBER PEMBELAJARAN INI DARI MAHIRKODING.ID
    //SENIMANKODING.BLOGSPOT.COM
    class Program
    {
        static void Main(string[] args)
        {
            IKendaraan mobil = new Mobil();
            IKendaraan motor = new Motor();
            Pengemudi pengemudi = new Pengemudi();
            pengemudi.Mengemudi(mobil);
            pengemudi.Mengemudi(motor);
        }
    }
}
