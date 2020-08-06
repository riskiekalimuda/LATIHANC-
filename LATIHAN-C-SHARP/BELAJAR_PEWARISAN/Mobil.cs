using LATIHAN_C_SHARP.BELAJAR_INTERFACE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP.BELAJAR_PEWARISAN
{
    public class Mobil : KendaraanBermotor, IBisaDiChargeListrik
    {
        public override void Jalan()
        {
            Console.WriteLine("Injak pedal gas");
        }

        public String ChargeBaterai()
        {
            return "Cas baterai mobil..";
        }
    }
}
