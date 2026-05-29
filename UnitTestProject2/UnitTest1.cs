using ConverterApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MetersToKilometers_1000Meters_Returns1Kilometer()
        {
            // Arrange (подготовка)
            int type = 0;
            double meters = 1000;

            // Act (действие)
            double result = ConverterLogic.Convert(type, meters);

            // Assert (проверка)
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MetersToKilometers_500Meters_Returns0_5Kilometer()
        {
            double result = ConverterLogic.Convert(0, 500);
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void MetersToKilometers_0Meters_Returns0()
        {
            double result = ConverterLogic.Convert(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void KilometersToMeters_1Kilometer_Returns1000Meters()
        {
            double result = ConverterLogic.Convert(1, 1);
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void KilometersToMeters_0_5Kilometer_Returns500Meters()
        {
            double result = ConverterLogic.Convert(1, 0.5);
            Assert.AreEqual(500, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_0Celsius_Returns32Fahrenheit()
        {
            double result = ConverterLogic.Convert(2, 0);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_100Celsius_Returns212Fahrenheit()
        {
            double result = ConverterLogic.Convert(2, 100);
            Assert.AreEqual(212, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_Minus40Celsius_ReturnsMinus40Fahrenheit()
        {
            double result = ConverterLogic.Convert(2, -40);
            Assert.AreEqual(-40, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_32Fahrenheit_Returns0Celsius()
        {
            double result = ConverterLogic.Convert(3, 32);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_212Fahrenheit_Returns100Celsius()
        {
            double result = ConverterLogic.Convert(3, 212);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Convert_MaxValue_DoesNotThrowException()
        {
            double result = ConverterLogic.Convert(0, double.MaxValue);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Convert_MinValue_DoesNotThrowException()
        {
            double result = ConverterLogic.Convert(0, double.MinValue);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void Convert_InvalidType_ThrowsExceptionWithMessage()
        {
            try
            {
                ConverterLogic.Convert(99, 100);
                Assert.Fail("Ожидалось исключение, но его не было");
            }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.Message.Contains("Неверный тип"));
            }
        }

        [TestMethod]
        public void Convert_MetersToKilometers_FormulaIsCorrect()
        {
            // Проверяем формулу: км = м / 1000
            double meters = 1234;
            double expected = meters / 1000;
            double actual = ConverterLogic.Convert(0, meters);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert_CelsiusToFahrenheit_FormulaIsCorrect()
        {
            // Проверяем формулу: °F = °C * 1.8 + 32
            double celsius = 25;
            double expected = celsius * 1.8 + 32;
            double actual = ConverterLogic.Convert(2, celsius);
            Assert.AreEqual(expected, actual);
        }
    }
}
