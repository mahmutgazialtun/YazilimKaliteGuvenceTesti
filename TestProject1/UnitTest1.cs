using System;
using Xunit;
using uygstr;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestBilgi()
        {
            Program p = new Program();
            string isim = "Gazi";
            string soyisim = "Altun";
            string beklenen = "Gazi" + "Altun";
            string gerceklesen = p.BilgiGetir(isim, soyisim);
            Assert.Equal(beklenen, gerceklesen);
        }
    }
}
