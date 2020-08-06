using PustakaAntarMuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaAktor
{
    public class Pengemudi
    {
        public void Mengemudi(IKendaraan _kendaraan)
        {
            _kendaraan.Jalankan();
        }
    }
}
