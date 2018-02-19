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
                Console.WriteLine("Lūdzu izvēlēties darbību");
                Console.WriteLine("a - pievienot");
                Console.WriteLine("p - parādīt");
                Console.WriteLine("d - dzēst");
                Console.WriteLine("da - dzēst visu");
                Console.WriteLine("l - Ielādēt toDoList");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "a":
                        //pievienot jaunu darāmo lietu
                        Console.WriteLine("Lūdzu ievadiet darāmo lietu:");
                        string todoTask = Console.ReadLine();
                        list.AddNewTodo(todoTask);
                        break;

                    case "p":
                        //izvadīt visas darāmās lietas uz ekrāna
                        list.ShowAllTodos();
                        break;

                    case "d":
                        //dzēst konkrētu darāmo lietu
                        Console.WriteLine("Lūdzu ievadi kārtas nummuru");
                        list.ShowAllTodos();
                        int index = int.Parse(Console.ReadLine());
                        list.DeleteTodo(index - 1);
                        break;

                    case "da":
                        list.DeleteAllTodos();
                        break;

                    case "s":
                        //saglabājam saturu failā
                        list.SaveToFile();
                        break;

                    case "l":
                        list.LoadFromFile();
                        break;

                        //implementējam ielādi no faila izmantojot funkciju
                        //File.ReadAllLines(path)

                }
                //lai ērti orientētos pa kodu nospied F12
                //pievienot jaunu darāmo lietu
                //dzēst visas darāmās lietas
                //izvadīt visas darāmās lietas uz ekrāna
                list.ShowAllTodos();

            }
        }
    }
}
