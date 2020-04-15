using System;

namespace cSharpPolymorphism
{
    class Program
    {
        // Using all options negates need for if statement - catch all
        void polyPrint(int myInterger) 
        {
            Console.WriteLine("My interger is: {0}", myInterger);
        }

        void polyPrint(double myDouble) 
        {
            Console.WriteLine("My double is: {0}", myDouble);
        }

        void polyPrint(string myString) 
        {
            Console.WriteLine("My string is: {0}", myString);
        }

        void withdrawal(int bankBalance, int withdrawalAmount)
        {
            bankBalance -= withdrawalAmount;
            Console.WriteLine("My new balance is: {0}", bankBalance);
        }

        static void Main(string[] args)  // can only go in through main
        {
            Program myPoly = new Program();

            myPoly.polyPrint(500);
            myPoly.polyPrint(3.1);
            myPoly.polyPrint("Hello");
            Console.ReadKey();

            // int bankBalance = 500;
            // int withdrawalAmount = 100;
            // bankBalance -= withdrawalAmount;
            // Console.WriteLine("My new balance is: {0}", bankBalance);

            myPoly.withdrawal(500, 30);

            
        }
    }
}
