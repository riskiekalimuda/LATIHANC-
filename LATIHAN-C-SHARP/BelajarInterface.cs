using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public interface ITransaction
    {
         void showTransaction();
         double getAmount();
    }
    public class BelajarInterface : ITransaction
    {
        #region PENJELASAN INTERFACE
        //Interface adalah suatu bentuk template dari class yg sifatnya hanya untuk mendeklarasikan
        //method, properties, dan event, tanpa adanya proses inisiasi
        //proses inisiasi hanya dilakukan pada class yg menggunakan interface saja.

        //Interface juga membantu agar class bisa menurunkan banyak sifat/karakter object, karena di c# hanya diperkenankan 
        //untuk mewarisi satu saja dari sifat/karakter object.

        //Sumber senimankoding.blogspot.com
        //Sumber duadualima.com
        #endregion

        private String tCode = "";
        private String date = "";
        private double amount = 0;

        public BelajarInterface(String tCode, String date, double amount)
        {
            this.tCode = tCode;
            this.date = date;
            this.amount = amount;
        }

        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Kode Transaksi = {0}", tCode);
            Console.WriteLine("Tanggal Transaksi = {0}", date);
            Console.WriteLine("Jumlah Transaksi = {0}", getAmount());
        }
    }
}
