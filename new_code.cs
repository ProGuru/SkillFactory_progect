using System;

class Program
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string hello2 = "������";

        Print(hello);

        void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}