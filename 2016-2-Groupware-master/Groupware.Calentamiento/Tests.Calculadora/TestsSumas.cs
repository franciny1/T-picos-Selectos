using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestsSumas
    {
        [TestMethod]
        public void UnoMasCuatro()

        {

            // definicion del ecenario
            Numero elPrimerOperando = new Numero("1", 10);
            Numero elSegundoOperando = new Numero("4", 10);
            char elOperando = '+';
            Numero elResultadoEsperado = new Numero("5", 10);
            Numero elResultadoReal;

            //invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo operando
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
            

        }
    }
}
