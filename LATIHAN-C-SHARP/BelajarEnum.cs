using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public enum NamaBuah
    {
        None = 0,
        Apel,
        Jeruk,
        Pisang
    }
    public class BelajarEnum
    {
        #region TestEnum1
        public static void TestEnum1()
        {
            Console.Write("Pilih Buah: 1. Apel, 2. Jeruk, 3. Pisang");
            int pilihan = int.Parse(Console.ReadLine());
            switch ((NamaBuah)pilihan)
            {
                case NamaBuah.Apel:
                    Console.WriteLine("Anda memilih apel");
                    break;
                case NamaBuah.Jeruk:
                    Console.WriteLine("Anda memilih jeruk");
                    break;
                case NamaBuah.Pisang:
                    Console.WriteLine("Anda memilih pisang");
                    break;
                default:
                    Console.WriteLine("Anda tidak memilih salah satu...");
                    break;
            }
        }
        #endregion
    }
}
