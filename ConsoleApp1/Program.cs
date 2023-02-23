using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz :");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}-0 sayıları arasındaki asal sayılar :",sayi);
            Asalsayi(sayi);
        }
        static void Asalsayi(int sayi)
        {
           int sayac = 0;
                if (sayi<=1)
                {
                    return;
                }
                else
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        if ((float)sayi % i == 0)
                        {
                            sayac++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (sayac == 2)
                    {
                        Console.WriteLine("{0}", sayi);
                    }
                    
                }
            for (int i = 0; i <= sayi; i--)
            {
                Asalsayi(sayi=sayi - 1);
            }
        }
            }
        }
    

