using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public class BelajarPengubahParameter
    {
        #region PengubahParameterREF
        public static void PengubahParameterREF(ref String a, ref String b)
        {
            String aValue = a;
            a = b;
            b = aValue;
        }

        public static void Kuadrat(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }

        public static void PembalikNilai<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region PengubahParameterOUT
        public static void PengubahParameterOUT(int a, int b, out int hasil)
        {
            hasil = a + b;
        }
        #endregion

        #region PengubahParameterParams
        public static double PengubahParameterParams(params double[] nilai)
        {
            double jumlah = 0;
            if (nilai.Length == 0)
                return jumlah;
            for (int i = 0; i < nilai.Length; i++)
            {
                jumlah += nilai[i];
            }
            return (jumlah / nilai.Length);
        }
        #endregion
    }
}
