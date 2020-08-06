using PustakaAntarMuka;
using PustakaKendaraan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFactory
{
    public class FactoryKendaraan
    {
        public IKendaraan Create(int pilihan)
        {
            IKendaraan kendaraan;
            switch (pilihan)
            {
                case 1:
                    kendaraan = new Motor();
                    break;
                case 2:
                    kendaraan = new Mobil();
                    break;
                case 3:
                    kendaraan = new Pesawat();
                    break;
                case 4:
                    kendaraan = new Becak();
                    break;
                default:
                    throw new ArgumentException();
            }
            return kendaraan;
        }
    }
}
