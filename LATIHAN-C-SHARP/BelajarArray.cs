using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public class BelajarArray
    {
        #region ARRAY SATU DIMENSI
        public static void ArraySatuDimensi()
        {
            Int32[] varArray = { 2, 4, 5, 1, 8, 9 };
            foreach (var item in varArray)
            {
                varArray[2] = 100;
                Console.WriteLine(item);
            }
        }
        #endregion

        #region ARRAY MULTIDIMENSI
        public static void ArrayMultidimensi()
        {
            int[,] arrDuaDimensi = {
                                       {1,3,5},
                                       {5,7,2},
                                       {8,9,3}
                                   };

            for (int i = 0; i < arrDuaDimensi.GetLength(0); i++)
            {
                for (int j = 0; j < arrDuaDimensi.GetLength(1); j++)
                {
                    Console.WriteLine("Baris {0}, Kolom {1}, Nilai = {2}", i, j, arrDuaDimensi[i, j]);
                }
            }
        }
        #endregion

        #region JAGGED ARRAY
        public static void JaggedArray()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[6] { 3, 4, 5, 6, 7, 8 };
            jaggedArray[2] = new int[3] { 9, 10, 11 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
