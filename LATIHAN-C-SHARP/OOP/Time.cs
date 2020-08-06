using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP.OOP
{
    public class Time
    {
        #region PENJELASAN CONSTRUCTOR
        //Constructor adl method yg paling pertama kali dipanggil saat dibuat instance dari sebuah class,
        //dimana namanya sama dengan class, dan berfungsi untuk menginisiasi variable ketika dibuat instance nya...
        #endregion

        static String date;
        Int32 jam;
        Int32 menit;
        Int32 detik;
        String tempat;

        public Time(String tanggal, Int32 jam, Int32 menit, Int32 detik)
        {
            date = tanggal;
            this.jam = jam;
            this.menit = menit;
            this.detik = detik;
        }

        public Time(String tempat)
        {
            this.tempat = tempat;
        }

        public void CetakWaktu()
        {
            Console.WriteLine("{0} {1} {2} {3}", date, jam, menit, detik);
        }

        public static void CetakTanggal()
        {
            Console.WriteLine("{0}", date);
        }

        public void CetakTempat()
        {
            Console.WriteLine("{0}", tempat);
        }
    }
}
