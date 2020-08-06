using LATIHAN_C_SHARP.BELAJAR_GENERIC;
using LATIHAN_C_SHARP.BELAJAR_PEWARISAN;
using LATIHAN_C_SHARP.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    //SUMBER PEMBELAJARAN INI DARI MAHIRKODING.ID
    //SENIMANKODING.BLOGSPOT.COM
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList<String> newList = new ToDoList<String>();
            newList.AddToList("Riskie");
            newList.AddToList("Belanja");
            newList.AddToList("Babi");
            newList.DeleteList("Babi");
            newList.PrintAll();
        }
    }
}
