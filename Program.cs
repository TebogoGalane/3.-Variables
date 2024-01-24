using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variable
            string name = "Tebogo";
            int age;

            //intitialisation
            name = "Tebogo";
            age = 10;

            // what will be seen on console
            Console.WriteLine("There one was a boy called " +  name);
            Console.WriteLine(name + " was " + age + " of age.");
            Console.WriteLine(name + " really never liked his name");

            //change variable values
            age = 18;
           name = " Bonolo ";

            Console.WriteLine(" At age " +  age  + " he changed his name " + name);

            //to freeze the console
            Console.ReadLine();

            //*notes:you can also declare and intitialise variable on the same line
       

            


        }
    }
}
