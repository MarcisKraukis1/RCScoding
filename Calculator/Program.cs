using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersInput = "";
            while (true) 
            {
                Console.WriteLine("Please choose action");
                Console.WriteLine("a - CalculateCircleArea circle area");
                Console.WriteLine("c - count two numbers together");
                usersInput = Console.ReadLine();
                //ja atbilde ir a, tad izsaukt apļa funkciju
                //ja atbilde ir c, tad izsaukt skaitīšanas funkciju
                //Visos citos gadījumos parādīt kļūdas paziņojumu

                if (usersInput == "a")
                {
                    CalculateCircleArea();
                }

                else if (usersInput == "c")
                {
                    CountTwoNumbers();
                }

                else if (usersInput == "d")
                {
                    DoesTheNumberDivide();
                }
                else if (usersInput == "x")
                {
                    break;
                }
                                
                else
                {
                    Console.WriteLine("sorry, did not understand");
                }
            }
           


            
            //ctrl  + K un tad D (Lai sakartotu kodu pareizi)
            //Saskaitīt divus skaitļus
            
        }

        static void DoesTheNumberDivide()
        {
            double dalāmais = GetNumberFromUser("Lūdzu ievadiet dalāmo");
            double dalītājs = GetNumberFromUser("Lūdzu ievadiet dalītāju");
            double modulo = dalāmais % dalītājs;
            if (modulo == 0)
            {
                Console.WriteLine("Šie skaitļi dalās");
            }

            else
            {
                Console.WriteLine("nedalās");
            }
        }

        static void CalculateCircleArea()
        {
            //Izveidojam mainīgo, kur glabāt rādiusu
            double radius;
            //Izveidosim mainīgo, kur glabāt rezultātu
            double result;
            //Piešķirsim rādiusa mainīgajam vērtību
            radius = GetNumberFromUser("Lūdzu ievadiet rādiusu");
            //Veicam aprēķināšanas operāciju
            result = radius * radius * 3.14;
            // Parādam rezultātu lietotājam
            Console.WriteLine("Rezultāts " + result);
            Console.ReadLine();
        }


        static double GetNumberFromUser(string msg)
        {
            //Izvadam funkcijai iedoto paziņojumu
            Console.WriteLine(msg);
            //nolasām lietotāja ievadi no ekrāna un ierakstam teksta mainīgo
            string textInput = Console.ReadLine();
            // Izveidojam mainīgo, kur glabāt apaļu skaitli
            double parsedNumber;
            //Pārveidojam ievadīto tekstu par skaitli un ierakstam mainīgajā
            bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
            if (parseWasSuccess == false)
            {
                Console.WriteLine("Slikti ievadīts skaitlis " + textInput);
                Console.WriteLine("Ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg);
            }
            else
            {
                Console.WriteLine("Brīnišķīgi ievadīts skaitlis");
            }
            return parsedNumber;
        }
        //void nozīmē to, ka šī funkcija rezultātā neko neatgriež tajā vietā kur tā izsaukta
        static void CountTwoNumbers()
        {
            //Pirmais skaitlis
            double  firstNumber;
            //Izsaucam skaitļa iegūšanas funkciju rezultātu ierakstam mainīgajā
            firstNumber = GetNumberFromUser("Lūdzu ievadiet pirmo skaitli");
            //Otrais skaitlis
            double secondNumber;
            //Izsaucam skaitļa iegūšanas funkciju rezultātu ierakstam mainīgajā 
            secondNumber = GetNumberFromUser("Lūdzu ievadiet otro skaitli");
            //mainīgais, kur glabāt rezultātu
            double result;
            //Aprēķinam rezultātu un ierakstam mainīgajā
            result = firstNumber + secondNumber;
            Console.WriteLine("Rezultāts " + result);
            Console.ReadLine();
        }

        
       
    }
}
