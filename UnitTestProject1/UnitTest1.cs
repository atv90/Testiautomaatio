using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xamarin_day4_webapplication.Utilities;

namespace UnitTestProject1
{
    [TestClass]
    //testimetodien täytyy olla julkisia ja merkitty [TestMethod]
    public class UnitTest1
    {
        [TestMethod]
        public void PäivämääräTestit()
        {
            //kelvollinen pvm
            string syöte = "4.6.2018";
            DateTime tulos = DateParsing.ParseFinnishDate(syöte);
            DateTime odotettu = new DateTime(2018, 6, 4);
            Assert.AreEqual(odotettu, tulos);

            //karkauspvm
             syöte = "29.2.2016";
             tulos = DateParsing.ParseFinnishDate(syöte);
             odotettu = new DateTime(2016, 2, 29);
            Assert.AreEqual(odotettu, tulos);

            //virheellinen syöte
            syöte = "";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            //virheellinen syöte 2
            syöte = null;
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            //virheellinen pvm
            syöte = "4/26/2018";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);


        }

        [TestMethod]
        public void ViikkonumeroTesti()
        {
            DateTime pvm = new DateTime(2018, 6, 4);
            int tulos = DateParsing.GetWeekNumber(pvm);
            int odotettu = 23;
            Assert.AreEqual(odotettu, tulos);
        }
    }
}
