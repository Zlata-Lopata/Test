using ErrorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Mod_Test
{
    [TestClass]
    public class UnitTest1
    {
        //Функція має викликати виняток, коли значення a є більше за межі типу int,
        //а значення результату операції може виходити за ці межі
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMod()
        {
            //arrange
            long a = long.MaxValue; long b = 2;
            CalcClassBr.CalcClass.Mod(a, b);
        }
       
        [TestMethod]
        public void TestMod1()
        {
            //arrange
            long a = 3; long b = 2;
          int actual=  CalcClassBr.CalcClass.Mod(a, b);
            int expected=1;
            Assert.AreEqual(expected, actual);
        }

        //ділення на нуль
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMod2()
        {
            // arrange
            long a = 3; long b = 0;
            // act
            CalcClassBr.CalcClass.Mod(a, b);
        }

        //Перевірка повідомлення про помилку при ділені на нуль
        [TestMethod]
        public void TestMod_DivideByZeroErrorMessage()
        {
            // arrange
            long a = 3; long b = 0;
            try
            {
                // act
                CalcClassBr.CalcClass.Mod(a, b);
            }
            catch (DivideByZeroException x)
            {
                // assert
                Assert.AreEqual(ErrorsExpression.ERROR_09, x.Message);
            }
        }

    }
}
