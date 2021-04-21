using System;

namespace Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = 10;
            // if(number == 10)
            // {
            //     System.Console.WriteLine("Number is 10");

            // }
            // else if (number == 20)
            // {
            //     System.Console.WriteLine("number is 20");

            // }
            // else if (number == 30)
            // {
            //     System.Console.WriteLine("number is 30");

            // }
            // else
            // {
            //     System.Console.WriteLine("Pls enter a number");
            // }



            //Switch Statements
            // int number = 20;

            // switch(number)
            // {
            //     case 10:
            //     System.Console.WriteLine("Number is 10");
            //     break;

            //     case 20:
            //     System.Console.WriteLine("Number is 20");
            //     break;

            //     case 30:
            //     System.Console.WriteLine("Number is 30");
            //     break;

            //     default:
            //      System.Console.WriteLine("Invalid");
            //      break;

           // }


                  // While loop execution
                    // System.Console.WriteLine("Enter a Number");
                    // int a = int.Parse(Console.ReadLine());
                    // //int a = 10;
                    // while (a < 20){
                    //     System.Console.WriteLine("Value is {0}", a);
                    //     a++;
                    // }


                    //DO-While Loop

                    // int a = 19;
                    // do
                    // {
                    //     System.Console.WriteLine("Value is {0}", a);
                    //     a++;
                    // }
                    // while (a < 20);


                    //For Loop

                    // for (int i=0; i < 5; i++)
                    // {
                    //     System.Console.WriteLine(i);
                    // }


                    //ForEach Loop
                    string[] cars = { "Volvo", "Benz", "Mazda" };

                    foreach(var car in cars)
                    {
                        Console.WriteLine(car);
                    }

        }
    }
}
