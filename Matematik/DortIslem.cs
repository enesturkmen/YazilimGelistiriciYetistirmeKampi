using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Toplama(int number1, int number2)
        {
            int toplam = number1 + number2;
            Console.WriteLine("Sonuc : " + toplam);
        }
        public void Cikarma(int number1, int number2)
        {
            int toplam = number1 - number2;
            Console.WriteLine("Sonuc : " + toplam);
        }
        public void Carpma(int number1, int number2)
        {
            int toplam = number1 * number2;
            Console.WriteLine("Sonuc : " + toplam);
        }
        public void Bolme(double number1, double number2)
        {
            double toplam = number1 / number2;
            Console.WriteLine("Sonuc : " + toplam);
        }
    }
}
