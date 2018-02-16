using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList list = new TodoList();
            while (true)
            {
                //pievienot jaunu darāmo lietu
                Console.WriteLine("Lūdzu ievadiet darāmo lietu:");
                string todoTask = Console.ReadLine();
                list.AddNewTodo(todoTask);
                //dzēst visas darāmās lietas
                //izvadīt visas darāmās lietas uz ekrāna
                list.ShowAllTodos();

            }
        }
    }
}
