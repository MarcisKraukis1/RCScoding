using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
            Console.WriteLine("Lūdzu ievadiet burtus, no kuriem vēleties veidot vārdus");
            string usersLetters = Console.ReadLine();

            // ielādējam visus vārdus no vārdnīcas faila
            string[] wordsFromDictionary = File.ReadAllLines(@"C:\Users\Dators\Desktop\words.txt");

            // izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
            foreach (string wordFromDict in wordsFromDictionary)
            {
                //Pārbaudām vai visi Lietotāja ievadītie burti ir atrodami vārdnīcas vārdā
                // izveidojam mainīgo, kurā piefiksēsim to, vai vārdā ir kādi nevajadzīgi burti 
                bool hasInvalidLetterBeenFound = false;

                // izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
                foreach (char  currentSymbol in usersLetters)
                {
                    // pārbaudam, vai burts atrodas vārdnīcas vārdā
                    if (wordFromDict.Contains(currentSymbol) == false)
                    {
                        // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                        hasInvalidLetterBeenFound = true;
                    }
                }
                //Pārbaudām, vai visi vārdnīcas vārda burti atrodami lietotāja ievadītajā vārdā
                // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
                foreach(char symbol in wordFromDict)
                {
                    // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
                    if (usersLetters.Contains(symbol) == false)
                    {
                        // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                        hasInvalidLetterBeenFound = true;
                    }
                }
                // kad vārdu apstrāde pa burtiem beigusies,
                // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
                if (hasInvalidLetterBeenFound == false)
                {

                }

                // ja nav, tad izvadām vārdu uz ekrāna
                Console.WriteLine(wordFromDict);
    
            }







            
        }
    }
}
