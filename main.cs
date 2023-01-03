// Created by: Ekaterina
// Created on: Jan 2023
//
// This program does simple long division

using System;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static async Task Main()
    {
        string choice;
        int counter = 0;
        Console.WriteLine("Do you want to quit? ");
        Console.WriteLine(" ");
        Console.WriteLine("Type Yes or No ");
        Console.WriteLine(" ");

        choice = Console.ReadLine();
        if (choice == "no" || choice == "No")
        {
            var someText = await File.ReadAllTextAsync("LocalStorage.txt");
            counter = Convert.ToInt16(someText);
            counter++;
            await File.WriteAllTextAsync("LocalStorage.txt", counter.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(counter.ToString());
        }

        Console.WriteLine("\nDone.");
    }
}