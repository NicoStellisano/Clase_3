using System;
using Testeando;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Debe instanciar el objeto Estacionamiento
        /// </summary>
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento est1 = new Estacionamiento();
            Assert.IsNotNull(est1);
        }

        [TestMethod]
        public void ListadoInstanciado()
        {
            Estacionamiento est2 = new Estacionamiento();
            Assert.IsNotNull(est2.listaVehiculos);
        }
    }
}
