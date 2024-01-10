using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Instructing the studnets to capture their details
                Console.WriteLine("Hello, Enter Your Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your weight");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your height in cms");
                double height = double.Parse(Console.ReadLine());

                //Creating /registering my students details
                Student student1 = new Student(name, age, weight,height);
                Student Student2 = new Student("Jimmy", 23, 70.6,145);

                //Prints the results to the Console
                Console.WriteLine("Robot Is " + name + " obese? " +"\n" +student1.IsObese());
                Console.WriteLine("Based On Your Height, Your  Ideal Body Weight is : " + "\n" + student1.Idealbw +"Kg");
                
                Console.WriteLine("Robot Is Jimmy Obese?  " + "\n" + Student2.IsObese());


                

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}" + "Try again FOOL!!");
            }

            Console.Read();
        }
    }
}
