using FORALU;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestFORALU
{
    [TestClass]
    public class TestTexto
    {
        [TestMethod]
        public void TestTitulo()
        {
            Texto texto = new Texto(@"C:\Users\Sebastian\source\repos\FORALU\FORALU\data\lagrimas_de_luz.txt");
            string _esperado = "Lágrimas de luz";
            string _obtenido = texto.GetTitulo();
            Assert.AreEqual(_esperado, _obtenido);
        }
    }
}
