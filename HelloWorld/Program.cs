using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //izsaucam savu izveidoto funkciju
            SayHello();
            //Izsaucam otro funkciju
            SayHelloToUser();

            
        }

        static void SayHelloToUser()
        {
            //Palūdzam lietotājam ievadīt savu vārdu
            //uzrakstot lūgumu ekrānā
            Console.WriteLine("Please enter your name:");
            //izveidojam mainīgo, kur glabāt lietotāja ievadīto vērtību
            string usersName;
            //paprasam konsolei ievadīt tekstu, saglabājam rezultātu mainīgo
            usersName = Console.ReadLine();
            string age;
            Console.WriteLine("Please enter your age:");
            age = Console.ReadLine();
            Console.WriteLine("Labdien," + usersName + "!" + "Tavs vecums ir " + age); //"Labdien, Marcis"
            Console.ReadLine();
        }
       

        static void SayHello()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
  }
}
