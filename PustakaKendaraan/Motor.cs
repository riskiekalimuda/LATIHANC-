using PustakaAntarMuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaKendaraan
{
    public class Motor : IKendaraan
    {
        private readonly MesinDarat _mesinMotor;
        public Motor()
        {
            _mesinMotor = new MesinDarat();
        }

        public void Jalankan()
        {
            Console.WriteLine("Menjalankan Sepeda Motor: ");
            _mesinMotor.Hidupkan();
            _mesinMotor.Picu("Tarik tuas gas");
            _mesinMotor.Matikan();
        }
    }
}
