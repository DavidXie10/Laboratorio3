using Laboratorio3.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace Laboratorio3.Tests.Controllers {
    [TestClass]
    public class CalculadoraIMCControllerTest {
        [TestMethod]
        public void TestResultadoIMCViewResult() {
            // Arrange
            CalculadoraIMCController calculadoraController = new CalculadoraIMCController();
            // Act
            ViewResult vista = calculadoraController.ResultadoIMC() as ViewResult;
            // Assert
            Assert.AreEqual("ResultadoIMC", vista.ViewName);
        }

        [TestMethod]
        public void ListadoDeResultadosImcCantidadDePersonasEsCorrecta() {
            // Arrange
            int numeroPersonas = 8;
            CalculadoraIMCController calculadoraController = new CalculadoraIMCController();

            // Act
            ViewResult vista = calculadoraController.ResultadosAleatoriosIMC() as ViewResult;

            // Assert
            Assert.AreEqual(numeroPersonas, vista.ViewBag.personas.Count);
        }
    }
}
