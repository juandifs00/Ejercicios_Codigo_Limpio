using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using Banco_ABC;

namespace Banco_ABCTest
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod()]
        public void ConsignarTest()
        {
            //Arrange
            List<CuentaAhorros> cuentasTest = new List<CuentaAhorros>();
            cuentasTest.Add(new CuentaAhorros("123456", "Titular1", "4321", 1400000));
            cuentasTest.Add(new CuentaAhorros("147", "Titular2", "10258", 2360000));
            cuentasTest.Add(new CuentaAhorros("753598", "Titular3", "4326584", 3369524));
            cuentasTest.Add(new CuentaAhorros("5223", "Titular4", "85746", 4758968));
            cuentasTest.Add(new CuentaAhorros("1234", "Titular5", "45685", 60523874));
            cuentasTest.Add(new CuentaAhorros("176396", "Titular6", "36985", 789654));
            string cuentaATransferir = "123456";
            double valorAtransferir = 630000;
            string expected = "Valor consignado exitosamente";

            // Act
            string actual = CuentaAhorros.Consignar(cuentasTest, cuentaATransferir, valorAtransferir);

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetirarTest()
        {
            //Arrange
            List<CuentaAhorros> cuentasTest = new List<CuentaAhorros>();
            cuentasTest.Add(new CuentaAhorros("123456", "Titular1", "4321", 1400000));
            cuentasTest.Add(new CuentaAhorros("147", "Titular2", "10258", 2360000));
            cuentasTest.Add(new CuentaAhorros("753598", "Titular3", "4326584", 3369524));
            cuentasTest.Add(new CuentaAhorros("5223", "Titular4", "85746", 4758968));
            cuentasTest.Add(new CuentaAhorros("1234", "Titular5", "45685", 60523874));
            cuentasTest.Add(new CuentaAhorros("176396", "Titular6", "36985", 789654));
            string cuentaARetirar = "123456";
            double valorARetirar = 20000000;
            string expected = "Saldo insuficiente";
            // Act

            string actual = CuentaAhorros.Retirar(cuentaARetirar, valorARetirar, cuentasTest);
            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TransferenciaTest()
        {
            //Arrange
            List<CuentaAhorros> cuentasTest = new List<CuentaAhorros>();
            cuentasTest.Add(new CuentaAhorros("123456", "Titular1", "4321", 1400000));
            cuentasTest.Add(new CuentaAhorros("147", "Titular2", "10258", 2360000));
            cuentasTest.Add(new CuentaAhorros("753598", "Titular3", "4326584", 3369524));
            cuentasTest.Add(new CuentaAhorros("5223", "Titular4", "85746", 4758968));
            cuentasTest.Add(new CuentaAhorros("1234", "Titular5", "45685", 60523874));
            cuentasTest.Add(new CuentaAhorros("176396", "Titular6", "36985", 789654));
            string cuentaOrigen = "963";
            string cuentaDestino = "147";
            double valorATransferir = 200000;
            string expected = "La cuenta de origen no existe";
            // Act

            string actual = CuentaAhorros.Transferir(cuentaOrigen, cuentaDestino, valorATransferir, cuentasTest);

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
