using PustakaAntarMuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public class Pesawat : IKendaraan
    {
        private readonly MesinTerbang _mesinTerbang;
        public Pesawat()
        {
            _mesinTerbang = new MesinTerbang();
        }

        public void Jalankan()
        {
            Console.WriteLine("Menghidupkan Pesawat: ");
            _mesinTerbang.Hidupkan();
            _mesinTerbang.Picu("Tarik Tuas Pesawat ");
            Console.WriteLine("Pesawat take off");
            Console.WriteLine("Pesawat mengudara");
            Console.WriteLine("Pesawat landing dengan sempurna");
            _mesinTerbang.Matikan();
        }
    }
}
