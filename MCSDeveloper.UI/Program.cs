using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace MCSDeveloper.UI
{
    class Program
    {
        //162

        static void Main(string[] args)
        {
            Thread thread = new(() =>
            {
                int counter = 1;
                while (counter <= 5)
                {
                    Console.Write(counter + " ");
                    //Thread.Sleep(10);
                    counter++;
                }
                Console.WriteLine("End of my Custom Thread.");
            });
            thread.Start();
            Console.WriteLine("Back inside the main Thread...");

            Console.ReadLine();
        }


    }






}
