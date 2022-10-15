using System;

namespace Hesaplama
{
    public class clsHesapla
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
