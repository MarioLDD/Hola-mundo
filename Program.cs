﻿using System; // Define the System package  
namespace ConsoleApp3 // Project name or Folder  
{
    class Program
    {
        static void Main(string[] args) // Defining the main function  
        {
            string name; // string variable name  
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine(); // takes an input from the user  
            Console.WriteLine("Hi! " + name + " Welcome to the JavaTpoint"); // print the output  
        }
    }
}