using System;

namespace PraseodymiumTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            numbers.Remove(6);
            numbers.ToString();
            Console.WriteLine(numbers);
            Console.ReadLine();


        }
    }
}
