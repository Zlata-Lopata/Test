using ErrorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Mod_Test
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
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


        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Lab1;Integrated Security=True", "TestMod",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestMod1()
        {
            //Arrange
            int a = (int)TestContext.DataRow["Number_a"];
            int b = (int)TestContext.DataRow["Number_b"];
            //Expected
            int expected = (int)TestContext.DataRow["Expected"];
            //Actual
            int actual = CalcClassBr.CalcClass.Mod(a, b);

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
