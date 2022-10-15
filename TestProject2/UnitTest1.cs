using System;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        Hesaplama.clsHesapla _hesap = new Hesaplama.clsHesapla();
        [Fact]
        public void Topla()
        { 
            int sonuc = _hesap.topla(20, 10);

            Assert.Equal(30, sonuc);
        }
        [Fact]
        public void Cikar()
        {
            int sonuc = _hesap.cikar(20, 10);

            Assert.Equal(10, sonuc);
        }
        [Fact]
        public void Carp()
        {
            int sonuc = _hesap.carp(20, 10);

            Assert.Equal(200, sonuc);
        }
        [Fact]
        public void Bol()
        {
            int sonuc = _hesap.bol(20, 10);

            Assert.Equal(2, sonuc);
        }
    }
}
