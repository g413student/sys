using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangle;

namespace UnitTest
{
    [TestClass]
    public class Tests
    {

        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 1, 10 и 100
        /// Входные значение: 1 10 100
        /// Ожидаемый результат: не существует
        /// </summary>
        [TestMethod]
        public void Values_1_10_100_TriangleDoesntExist()
        {
            int a = 1, b = 10, c = 100;
            string expectedResult = "не существует";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 0, 0 и 0
        /// Входные значение: 0 0 0
        /// Ожидаемый результат: не существует
        /// </summary>
        [TestMethod]
        public void Values_0_0_0_TriangleDoesntExist()
        {
            int a = 0, b = 0, c = 0;
            string expectedResult = "не существует";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами -1, -1, -1
        /// Входные значение: -1, -1, -1
        /// Ожидаемый результат: не существует
        /// </summary>
        [TestMethod]
        public void ValuesMinusOne_TriangleDoesntExist()
        {
            int a = -1, b = -1, c = -1;
            string expectedResult = "не существует";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }


        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 5, 5, 5
        /// Входные значение: 5, 5, 5
        /// Ожидаемый результат: равносторонний
        /// </summary>
        [TestMethod]
        public void Values_5_5_5_AllSidesAreEqual()
        {
            int a = 5, b = 5, c = 5;
            string expectedResult = "равносторонний";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }


        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 999, 999, 999
        /// Входные значение: 999, 999, 999
        /// Ожидаемый результат: равносторонний
        /// </summary>
        [TestMethod]
        public void Values_999_999_999_AllSidesAreEqual()
        {
            int a = 999, b = 999, c = 999;
            string expectedResult = "равносторонний";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }


        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 1_000_000_000, 1_000_000_000, 1_000_000_000
        /// Входные значение: 1_000_000_000, 1_000_000_000, 1_000_000_000
        /// Ожидаемый результат: равносторонний
        /// </summary>
        [TestMethod]
        public void ValuesBillion_AllSidesAreEqual()
        {
            int a = 1_000_000_000, b = 1_000_000_000, c = 1_000_000_000;
            string expectedResult = "равносторонний";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }


        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 9, 7, 9
        /// Входные значение: 9, 7, 9
        /// Ожидаемый результат: равнобедренный
        /// </summary>
        [TestMethod]
        public void Values_9_7_9_TwoSidesAreEqual()
        {
            int a = 9, b = 7, c = 9;
            string expectedResult = "равнобедренный";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 1, 0, 1
        /// Входные значение: 1, 0, 1
        /// Ожидаемый результат: не существует, т.к. сторона не может быть 0
        /// </summary>
        [TestMethod]
        public void Values_1_0_1_TriangleDoesntExist()
        {
            int a = 1, b = 0, c = 1;
            string expectedResult = "не существует";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }


        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами -10, 1, -10
        /// Входные значение: -10, 1, -10
        /// Ожидаемый результат: не существует, т.к. стороны не могут быть отрицательными
        /// </summary>
        [TestMethod]
        public void Values_MinusTen_1_MinusTen_TriangleDoesntExist()
        {
            int a = -10, b = 1, c = -10;
            string expectedResult = "не существует";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }


        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 2, 3, 4
        /// Входные значение: 2, 3, 4
        /// Ожидаемый результат: разносторонний
        /// </summary>
        [TestMethod]
        public void Values_2_3_4_DifferentSides()
        {
            int a = 2, b = 3, c = 4;
            string expectedResult = "разносторонний";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 1, 2, 3
        /// Входные значение: 1, 2, 3
        /// Ожидаемый результат: не существует, т.к. каждая сторона треугольника должна быть строго меньше суммы двух других
        /// </summary>
        [TestMethod]
        public void Values_1_2_3_TriangleDoesntExist()
        {
            int a = 1, b = 2, c = 3;
            string expectedResult = "не существует";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Тест проверяет на существование треугольник со сторонами 98, 999, 998
        /// Входные значение: 98, 999, 998
        /// Ожидаемый результат: разносторонний
        /// </summary>
        [TestMethod]
        public void Values_98_999_998_DifferentSides()
        {
            int a = 99, b = 999, c = 998;
            string expectedResult = "разносторонний";
            string actualResult = Method.CheckTriangle(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
