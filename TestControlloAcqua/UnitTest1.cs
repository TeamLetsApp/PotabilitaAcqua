using MetodiLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestControlloAcqua
{
    [TestClass]
    public class TestControlloAcqua
    {
        [TestMethod]
        public void TestTemperatura()
        {
            double temp = 20;
            bool risp = true;
            bool ritorno = Metodi.ControlloTemperatura(temp);
            Assert.AreEqual(risp, ritorno);
        }
        [TestMethod]
        public void TestControlloPH()
        {
            double ph = 9.6;
            bool risp = false;
            bool ritorno = Metodi.ControlloPh(ph);
            Assert.AreEqual(risp, ritorno);
        }
        [TestMethod]
        public void TestControlloResiduo()
        {
            double litro = 2;
            double residuo = 400;
            bool risp = true;
            bool ritorno = Metodi.Residuo(residuo , litro);
            Assert.AreEqual(risp, ritorno);
        }
        [TestMethod]
        public void TestControlloAmmoniaca()
        {
            double litro = 7;
            double ammo = 1.4;
            bool risp = false;
            bool ritorno = Metodi.ControlloAmmoniaca(ammo , litro );
            Assert.AreEqual(risp, ritorno);
        }
        [TestMethod]
        public void TestControlloNitriti()
        {
            
            double nitriti = 0;
            bool risp = true;
            bool ritorno = Metodi.ControlloNitriti(nitriti);
            Assert.AreEqual(risp, ritorno);
        }
        [TestMethod]
        public void TestControlloNitrati()
        {
            double litro = 7;
            double nitrati = 35;
            bool risp = true;
            bool ritorno = Metodi.ControlloNitrati(nitrati, litro);
            Assert.AreEqual(risp, ritorno);
        }
        [TestMethod]
        public void TestControlloCloruri()
        {
            double litro = 7;
            double cloruri =175;
            bool risp = true;
            bool ritorno = Metodi.ControlloCloruri(cloruri, litro);
            Assert.AreEqual(risp, ritorno);
        }
    }
}
