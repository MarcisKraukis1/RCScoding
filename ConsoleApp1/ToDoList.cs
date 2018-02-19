using System;
using System.Collections.Generic;
using System.IO;
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
            for (int i = 0; i < todoEntries.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + todoEntries[i]);
                Console.WriteLine();
            }
            
        }

        public void DeleteTodo(int indexOfTodo)
        {
            //Neļāut izvēlēties kārtas nummuru, kurš neeksistē
            if (indexOfTodo >= this.todoEntries.Count)
            {
                //Ja sarakstā 3 indeksi, tad pēdējais indekss ir 2
                Console.WriteLine("Tāds ieraksts neeksistē");
                return;
            }
            todoEntries.RemoveAt(indexOfTodo);
        }
        
                // Lai izdzēstu visu listu
        public void DeleteAllTodos()

        {
            todoEntries.Clear();
        }

        public void SaveToFile()
        {
            for (int i = 0; i < todoEntries.Count; i++)
                //CTRL + .
                File.AppendAllText(
                    @"C:\Users\Dators\Documents\ToDoApplicationSetings\todos.txt",
                    todoEntries[i] + "\r\n");
        }
        
        public void LoadFromFile()
        {
            string[] allLinesFromFile = File.ReadAllLines(@"C:\Users\Dators\Documents\ToDoApplicationSetings\todos.txt");
            foreach (string listEntry in allLinesFromFile)
            {
                todoEntries.Add(listEntry);
            }
            
           
        }



    }
}
