// See https://aka.ms/new-console-template for more information
using MonkeyAPI7;

Console.WriteLine("Hello, World!");


foreach (var monkey in Monkey.SeedMonkeys())
    Console.WriteLine(monkey.Name);

Console.ReadLine();
