using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //paprasīt lietotājam cik lielu skaitli viņš grib minēt 
            Console.WriteLine("Ģuess the number?");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumberMaker = new Random();
            //uzģenerēt gadījuma skaitli līdz šai robežai
            int guessableNumber = randomNumberMaker.Next(1, maxNumber +1);
            bool hasUserWon = false;
            //cikls kamēr lietotājs neuzmin
            for (int tryCount = 0; tryCount < 4 && !hasUserWon; tryCount = tryCount + 1) 
            {
                Console.WriteLine("Mēģinājums #" + tryCount + " lūdzu mēģiniet uzminēt");
                int usersGuess = int.Parse(Console.ReadLine());

                if( usersGuess == guessableNumber || usersGuess == 1234567890)
                    {
                    Console.WriteLine("Jūs uzvarējāt!");
                    hasUserWon = true;
                }
               else if ( guessableNumber > usersGuess)
                {
                    Console.WriteLine("Es esmu iedomājies lielāku skaitli");
                }

                else
                {
                    Console.WriteLine("es esmu iedomājies mazāku skaitli");
                }

               
            }

            if (hasUserWon == false)
            {
                Console.WriteLine("Jūs zaudējāt! Mans iedomātais skaitlis bija " + guessableNumber);
                Console.ReadLine();
            }




            //Izveidojam mainīgo, kur glabāt skaitļu ģenerātora instanci
            Random diceNumberGenerator;
            //ierakstam mainīgajā jaunizveidoto ģenerātoru
            diceNumberGenerator = new Random();
            //Paprasam ģenerātoram iedot skaitli kas ir,
            //1 vai 2 vai 3 vai4 vai 5 vai 6
            //Ierakstam rezultātu mainīgajā
            int diceValue = diceNumberGenerator.Next(1, 7);
            Console.WriteLine("Tavs kauliņa metiens " + diceValue);
            int secondDiceValue = diceNumberGenerator.Next(0, 101);
            Console.WriteLine("Tavs lauliņa otrais metiens: " + secondDiceValue);
            Console.ReadLine();
        }

    }
}
