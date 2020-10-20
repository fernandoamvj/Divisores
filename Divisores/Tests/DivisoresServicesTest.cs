using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class DivisoresServicesTest
    {
        [TestMethod]
        public void TesteDivisores25()
        {
            var divisoresService = new DivisoresService();

            var divisores = divisoresService.ListarDivisores(25);

            var resultado = new List<int> { 1, 5, 25 };

            CollectionAssert.AreEqual(resultado, divisores);
        }

        [TestMethod]
        public void TesteDivisores36()
        {
            var divisoresService = new DivisoresService();

            var divisores = divisoresService.ListarDivisores(36);

            var resultado = new List<int> { 1, 2, 3, 4, 6, 9, 12, 18, 36 };

            CollectionAssert.AreEqual(resultado, divisores);
        }


        [TestMethod]
        public void TesteDivisores100()
        {
            var divisoresService = new DivisoresService();

            var divisores = divisoresService.ListarDivisores(100);

            var resultado = new List<int> { 1, 2, 4, 5, 10, 20, 25, 50, 100 };

            CollectionAssert.AreEqual(resultado, divisores);
        }

        [TestMethod]
        public void TesteDivisoresPrimos25()
        {
            var divisoresService = new DivisoresService();

            var divisores = divisoresService.ListarDivisoresPrimos(25).ToList();

            var resultado = new List<int> {5};

            CollectionAssert.AreEqual(resultado, divisores);
        }

        [TestMethod]
        public void TesteDivisoresPrimos36()
        {
            var divisoresService = new DivisoresService();

            var divisores = divisoresService.ListarDivisoresPrimos(36).ToList();

            var resultado = new List<int> {2, 3};

            CollectionAssert.AreEqual(resultado, divisores);
        }


        [TestMethod]
        public void TesteDivisoresPrimos100()
        {
            var divisoresService = new DivisoresService();

            var divisores = divisoresService.ListarDivisoresPrimos(100).ToList();

            var resultado = new List<int> { 2, 5 };

            CollectionAssert.AreEqual(resultado, divisores);
        }
    }
}
