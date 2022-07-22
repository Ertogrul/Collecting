using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, adet = 0;
            int toplam = 0;
            Console.Write("Kaç tane sayı toplayacaksın= ");
            adet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". sayıyı giriniz= ");
                sayi = int.Parse(Console.ReadLine());

                toplam = toplam + sayi;
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı= " + toplam);
            Console.ReadKey();
        }
    }
}
