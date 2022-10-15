using System;

namespace uygstr
{
    public class Program
    {
        public string BilgiGetir(string isim, string soyisim)
        {
            return string.Concat(isim,"", soyisim);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
