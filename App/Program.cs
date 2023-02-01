using System;
using System.Collections;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashObj = new Hashtable();
            string choice;
            do
            {
                Console.WriteLine("How many items do you want to enter ? ");
                int numOfValues = Convert.ToInt32(Console.ReadLine());
                try
                {
                    for (int i = 0; i < numOfValues; i++)
                    {
                        Console.WriteLine("Enter key: ");
                        string key = Console.ReadLine()!;
                        Console.WriteLine("Enter Value: ");
                        string value = Console.ReadLine()!;
                        hashObj.Add(key!, value);
                    }
                    foreach (string key in hashObj.Keys)
                    {
                        Console.WriteLine($"Key =  {key} , Value = {hashObj[key]}");
                    }

                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Enter 0 if you want to try again. Else press any key");
                choice = Console.ReadLine()!;

                hashObj.Clear();

            } while (choice == "0");
        }
    }
}