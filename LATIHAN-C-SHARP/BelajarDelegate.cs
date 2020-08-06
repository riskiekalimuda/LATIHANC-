using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public class BelajarDelegate
    {
        #region PenjelasanDelegate
        //Delegate adl objek yg bisa menyimpan referensi ke suatu fungsi, dengan syarat delegate dan fungsi tersebut
        //memiliki signature yg sama maksudnya adalah memiliki tipe balikan dan parameter.
        #endregion

        public delegate int Calculator(int a, int b);

        public static void Cetak(int x, int y)
        {
            int angka1 = x;
            int angka2 = y;

            Calculator calculator = Tambah;
            Console.WriteLine("Hasil penjumlahan: {0}", calculator(angka1, angka2));

            calculator = Kali;
            Console.WriteLine("Hasil perkalian: {0}", calculator(angka1, angka2));
        }


        public static int Tambah(int a, int b)
        {
            return (a + b);
        }

        public static int Kali(int a, int b)
        {
            return (a * b);
        }
    }
}
