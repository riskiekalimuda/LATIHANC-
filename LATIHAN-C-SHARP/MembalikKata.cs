using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public class MembalikKata
    {
        #region Masukkan Kata/Kalimat
        public static void MasukkanKata()
        {
            Console.WriteLine("Masukkan Kata/Kalimat : ");
            Console.WriteLine("===========================");
            Console.WriteLine("\n\n");
        }
        #endregion

        #region Proses kata yg diinput
        public static void Proses(ref String[] rentetanKata)
        {
            String inputan = Console.ReadLine().ToString();
            if (!String.IsNullOrEmpty(inputan))
            {
                Int32 jumlahHuruf = inputan.Length;
                if (jumlahHuruf > 0)
                {
                    rentetanKata = new String[jumlahHuruf];
                    for (int i = 0; i < jumlahHuruf; i++)
                    {
                        rentetanKata[i] = inputan.Substring(jumlahHuruf - (i + 1), 1);
                    }
                }
            }
        }
        #endregion

        public static void Tampilkan(String[] arrKata)
        {
            Console.Write("Hasilnya adalah: ");
            for (int i = 0; i < arrKata.Length; i++)
            {
                Console.Write(arrKata[i]);
            }
            Console.ReadLine();
        }
    }
}
