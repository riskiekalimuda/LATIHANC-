using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_C_SHARP
{
    public class ToDoList<T>
    {
        List<T> todolist;
        public ToDoList()
        {
            todolist = new List<T>();
        }

        public void AddToList(T list)
        {
            todolist.Add(list);
        }

        public void DeleteList(T list)
        {
            todolist.Remove(list);
        }

        public void PrintAll()
        {
            foreach (var item in todolist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
