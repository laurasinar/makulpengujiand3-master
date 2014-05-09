using System;
using System.Collections.Generic;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Testpenjumlahan()
        {
            var MyCalculatorv1 = new MainWindow();
            double expected = 9;
            double actual = MyCalculatorv1.penjumlahan(6, 3);
            Assert.AreEqual<double>(expected, actual, "Try again");
        }


        [TestMethod]
        public void Testpengurangan()
        {
            var MyCalculatorv1 = new MainWindow();
            double expected = 3;
            double actual = MyCalculatorv1.pengurangan(6, 3);
            Assert.AreEqual<double>(expected, actual, "Try again");
        }

        [TestMethod]
        public void Testperkalian()
        {
            var MyCalculatorv1 = new MainWindow();
            double expected = 18;
            double actual = MyCalculatorv1.perkalian(6, 3);
            Assert.AreEqual<double>(expected, actual, "Try again");
        }

        [TestMethod]
        public void Testpembagian()
        {
            var MyCalculatorv1 = new MainWindow();
            double expected = 2;
            double actual = MyCalculatorv1.pembagian(6, 3);
            Assert.AreEqual<double>(expected, actual, "Try again");
        }


    }
}
