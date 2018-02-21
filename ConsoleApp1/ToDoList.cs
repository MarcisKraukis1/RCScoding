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
            todoEntries = new List<TodoListEntry>();
        }
        List<TodoListEntry> todoEntries;

        public void AddNewTodo(string task)
        {
            //Ja vizuālā studija nevar atrast klasi,
            //tad uzspiežam uz klases nosaukuma un
            //piespiežamCtrl + .
            Console.WriteLine("Uzdevums pievienots:" + task);
            TodoListEntry usersTodo = new TodoListEntry();
            //Jaunizveidotajam uzdevumam piešķiram nosaukumu, ko ievadīs lietotājs
            usersTodo.Name = task;
            //Pievienojam jaunu uzdevumu uzdevumu sarakstam
            todoEntries.Add(usersTodo);
        }

        public void ShowAllTodos()
        {
            //Izgūstam pirmo elementu no saraksta izmantojot indeksātoru(KVADRĀTIEKAVAS)
            //Skaitītājs = skaitītājs +1; Ir tas pats, kas skaitītājs +=1
            //Ir tas pats, kas skaitītājs++
            //i ir saīsinājums no vārda index(Latviski - skaitītājs)

            for (int i = 0; i < todoEntries.Count; i++)
            {
                //Izvada kārtas nummuru un uzdevuma nosaukumu, bet bez enter galā
                Console.Write((i + 1) + ".  " + todoEntries[i].Name);
                //Ja uzdevums ir pabeigts (IsCompleted == true)
                if (todoEntries[i].IsCompleted)
                {
                    //TAd uzrakstam uz ekrāna "Done(bet bez enter)
                    Console.Write(" Done");
                }
                //Nospiežam enter
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
        string pathToDoFile = @"C:\Users\Dators\Documents\ToDoApplicationSetings\todos.txt";
        public void SaveToFile()
        {    
            File.Delete(pathToDoFile);
            for (int i = 0; i < todoEntries.Count; i++)
            {
                //CTRL + .
                string nameOfTodo = todoEntries[i].Name;
                File.AppendAllText(pathToDoFile, nameOfTodo + "\r\n");
                bool isCompleted = todoEntries[i].IsCompleted;
                File.AppendAllText(pathToDoFile, isCompleted + "\r\n");
            }
        }

        
        public void LoadFromFile()
        {
            //ja funkcija, kas pārbauda vai fails eksistē atgriež false
            if(!File.Exists(pathToDoFile))
            {
                //tad pārtraucam loadFromFile un atgriežamies
                return;
            }
            //Citādāk izpilda šo funkciju
            string[] allLinesFromFile = File.ReadAllLines(pathToDoFile);

            //pirms saraksta ielādes no faila,to iztīram no vecā satura

            todoEntries.Clear();

            //dodamies cauri sarakstam ar teksta rindām, kas ir ielēdētas no faila
            for (var index = 0; index < allLinesFromFile.Length; index +=2 )
            {
                string listEntry = allLinesFromFile[index];
                //listEntry mainīgajā ir ieraksīta viena teksta rinda no faila
                //Izveidojam jaunu uzdevumu
                TodoListEntry fileTodo = new TodoListEntry();
                //Uzdevumam uzdodam par nosaukumu teksta rindu, kas nolasīta no faila
                fileTodo.Name = listEntry;
                //Uzdevumam uzdodam par izpildes stāvokli vērtību, kas nolasīta no faila
                fileTodo.IsCompleted = bool.Parse(allLinesFromFile[index + 1]);
                //Jaunizveidoto uzdevumu pievienojam kopējo uzdevumu sarakstam
                this.todoEntries.Add(fileTodo);
                
            }
            
           
        }

        internal void MarkTodosAsDone(int doneTodoIndex)
        {
            //todoEntries[donetodoIndex].IsCompleted = true; Šis ir tas pats tikai vienā rindā
            TodoListEntry doneTodo = todoEntries[doneTodoIndex];
            doneTodo.IsCompleted = true;

        }

    }
}
