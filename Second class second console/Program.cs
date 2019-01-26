using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_class_second_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring a variable of type human

            Human tom = new Human();
           
            

            //Populating the objects

            Console.WriteLine("Please Enter your Firstname: ");
            tom.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your Lastname: ");
            tom.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your Age: ");
            tom.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Height: ");
            tom.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Please eneter your HairColor: ");
            tom.HariColor = Console.ReadLine();
            Console.WriteLine("Please enter your Weight: ");
            tom.Weight = double.Parse(Console.ReadLine());

            //Print The data which was collected

            Console.WriteLine($"Full Name: " + tom.FullName);

            //Console.WriteLine("Your Age is " + tom.Age);
            //Console.WriteLine("Your Height is " + tom.Height);
            //Console.WriteLine("Your hairColor is " + tom.HariColor);
            //Console.WriteLine("Your Weight is " + tom.Weight);
            Console.WriteLine($"{tom.FullName}, you are  {tom.Age} years old and have {tom.HariColor} hair.");
            Console.WriteLine($"You weigh {tom.Weight} lbs and stand at {tom.Height} inches tall");

            Human Eve = new Human("Eve", "Le'Chaim");
            Console.WriteLine(Eve.FullName);

            //Like System Pause
            Console.ReadLine();


                      

        }
    }
}
