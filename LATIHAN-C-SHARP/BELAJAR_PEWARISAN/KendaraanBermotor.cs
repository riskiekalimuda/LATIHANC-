using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP.BELAJAR_PEWARISAN
{
    public class KendaraanBermotor
    {
        public int JumlahRoda { get; set; }
        public String BahanBakar { get; set; }
        public String NomorPolisi { get; set; }
        public String Transmisi { get; set; }

        public virtual void Jalan()
        {
            Console.WriteLine("Kendaraan bergerak maju");
        }
    }
}
