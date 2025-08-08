using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINCodeRetrySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctPin = "1234";
            int attemptsAllowed = 3;
            int attemptsUsed = 0;
            bool accessGranted = false;

            while (attemptsUsed < attemptsAllowed && !accessGranted)
            {
                Console.WriteLine($"Attempt {attemptsUsed + 1} of {attemptsAllowed}");
                Console.Write("Enter your 4 digit PIN: ");
                string userInput = Console.ReadLine();

                if (userInput == correctPin)
                {
                    accessGranted = true;
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    attemptsUsed++;
                    if (attemptsUsed < attemptsAllowed)
                    {
                        Console.WriteLine("Incorrect PIN try again.");
                    }
                }
            }
            if (!accessGranted)
            {
                Console.WriteLine("Access Denied.");
            }
        }
    }
}
