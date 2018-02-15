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
            //paprasīt lietotājam lai viņš min kāds skaitlis 
            Console.WriteLine("Ģuess the number?");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumberMaker = new Random();
            //uzģenerēt gadījuma skaitli līdz šai robežai
            int guessableNumber = randomNumberMaker.Next(1, maxNumber);
            
            //cikls kamēr lietotājs neuzmin
            while (true)
            { }

           




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
