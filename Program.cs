using System;

namespace week4task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Checking");//Welcome to Number Checking App @WellaSchool
            Console.Write("Enter Your First Number: ");
            int firstNumber = int.Parse(Console.ReadLine()); //Request input from the user
            Console.Write("Enter Your Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine()); //Request input from the user
            int result = firstNumber+secondNumber;
            //Using Switch for Decision making
            switch (result)  
            {
                case int resultOfNumbers when resultOfNumbers <= 100:
                Console.WriteLine("The result is True"); // return True
                break;
                case int resultOfNumbers when resultOfNumbers >= 100:
                Console.WriteLine("The result is False"); // return False
                    break; //
                default: 
                Console.WriteLine("Try Again by Entrying Correct Number");
                    break; //End of Switch 
            }       
            
             //      (c)Daslaw
            
        }
    }
}
