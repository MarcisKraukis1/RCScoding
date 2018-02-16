using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TodoList
    {
        //šīs ir konstruktors, kurš tiek izsaukts, kad tiek izveidots objekts
        //konstruktors nekad neko neatgriež un vienmēr saucas tāpat kā klase
        public TodoList()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;

        public void AddNewTodo(string task)
        {
            
            
            //Ja vizuālā studija nevar atrast klasi,
            //tad uzspiežam uz klases nosaukuma un
            //piespiežamCtrl + .
            Console.WriteLine("Uzdevums pievienots:" + task);
            todoEntries.Add(task);
        }

        public void ShowAllTodos()
        {
            //Izgūstam pirmo elementu no saraksta izmantojot indeksātoru(KVADRĀTIEKAVAS)
            //Skaitītājs = skaitītājs +1; Ir tas pats, kas skaitītājs +=1
            //Ir tas pats, kas skaitītājs++
            //i ir saīsinājums no vārda index(Latviski - skaitītājs)
            for (int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs = skaititajs + 1)
            {
                Console.WriteLine("Your todo list entry is " + todoEntries[skaititajs]);
            }
            
        }

    }
}
