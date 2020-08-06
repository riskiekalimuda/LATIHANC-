using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public class BelajarGenerik<U,T>
    {
        #region PENJELASAN GENERIK
        //METODE GENEERIK adl metode yg balikan dan tipe parameternya sudah ditentukan saat
        //pemanggilan metode tersebut.

        //untuk kelas generik, tipe data variable dan metodenya mengikuti tipe data dari kelas generik;
        #endregion

        U genericVariable;

        public T GenericMethod<T>(T a)
        {
            Console.WriteLine(a.GetType());
            Console.WriteLine(genericVariable.GetType());
            Console.ReadKey();
            return a;
        }
    }
}
