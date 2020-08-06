using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP.BELAJAR_PEWARISAN
{
    public class Motor:KendaraanBermotor
    {
        public Motor()
        {
            this.JumlahRoda = 2;
            this.NomorPolisi = "B 3810 XMT";
            this.BahanBakar = "Pertamax";
        }

        //public override void Jalan()
        //{
        //    Console.WriteLine("Tarik pedal rem");
        //    Console.WriteLine("Hidupkan mesin");
        //    Console.WriteLine("Tarik tuas gas");
        //}
    }
}
