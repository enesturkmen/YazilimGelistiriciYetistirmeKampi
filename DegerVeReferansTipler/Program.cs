using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;

            Console.WriteLine(number1);

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };

            numbers1 = numbers2;
            numbers2[0] = 999;

            Console.WriteLine(numbers1[0]);
            // int, float, decimal, double, bool = value type
            // array, class, interface = reference type
            // deger tiplerde degere referans tiplerde adrese atama oluyor!!

        }
    }
}
