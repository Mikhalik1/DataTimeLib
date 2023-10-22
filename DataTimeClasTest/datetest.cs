using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataTimeLib;
namespace DataTimeClasTest
{
    [TestClass]
    public class datetest
    {
        /// <summary>
        /// Проверка метода PrevDate
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_PrevDate_ReturnExpected()
        {
            //data
            DateTime date = DateTime.Now;
            DateTime expected = date.AddDays(-1);
            //act
            DateTime result = DataTimeClass.PrevDate(date);
            //assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Проверка метода NextDate
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_NextDate_ReturnExpected()
        {
            //data
            DateTime date = new DateTime(2015, 2, 28);
            DateTime expected = new DateTime(2015, 3, 1); ;
            //act
            DateTime result = DataTimeClass.NextDate(date);
            //assert
            Console.WriteLine($"{result}-{expected}");
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Проверка метода DaysUntilEndMonth
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_DaysUntilEndMonth_ReturnExpected()
        {
            //data
            DateTime date = new DateTime(2015, 2, 25);
            int expected = 3;
            //act
            int result = DataTimeClass.DaysUntilEndMonth(date);
            //assert
            Console.WriteLine($"{result}-{expected}");
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Проверка метода LeapYearCheck
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_LeapYearCheck_ReturnFalse()
        {
            //data
            DateTime date = DateTime.Now;
            //act
            bool result = DataTimeClass.LeapYearCheck(date);
            //assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Проверка метода LeapYearCheck
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_LeapYearCheck_ReturnTrue()
        {
            //data
            DateTime date = new DateTime(2024, 7, 20);
            //act
            bool result = DataTimeClass.LeapYearCheck(date);
            //assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Проверка метода FindDate
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_FindDate_ReturnExpected()
        {
            //data
            DateTime date = new DateTime(2023, 2, 25);
            int plus = 10;
            DateTime expected = new DateTime(2023, 3, 7);
            //act
            DateTime result = DataTimeClass.FindDate(date, plus);
            //assert
            Console.WriteLine($"{result}-{expected}");
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Проверка метода FindDate
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_FindDate_ReturnExpected2()
        {
            //data
            DateTime date = new DateTime(2015, 2, 25);
            int plus = -2;
            DateTime exepted = new DateTime(2015, 2, 23);
            //act
            DateTime result = DataTimeClass.FindDate(date,plus);
            //assert
            Console.WriteLine($"{result}-{exepted}");
            Assert.AreEqual(result, exepted);
        }

        /// <summary>
        /// Проверка метода NextDayOfMonth
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_NextDayOfMonth_ReturnTrue()
        {
            //data
            DateTime date = DateTime.Now;
            //act
            bool result = DataTimeClass.NextDayOfMonth(date);
            //assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Проверка метода NextDayOfMonth
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_NextDayOfMonth_ReturnFalse()
        {
            //data
            DateTime date = new DateTime(2023, 10, 31);
            //act
            bool result = DataTimeClass.NextDayOfMonth(date);
            //assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Проверка метода NextDayOfMonth
        /// </summary>
        [TestMethod]
        public void TestMDataTimeClasTest_NextDayOfMonth_ReturnFalse()
        {
            //data
            DateTime date = new DateTime(2023, 10, 31);
            //act
            bool result = DataTimeClass.NextDayOfMonth(date);
            //assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Проверка метода FirstDayOdYear
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_FirstDayOdYear_ReturnTrue()
        {
            //data
            DateTime date = new DateTime(2023, 1, 1);
            //act
            bool result = DataTimeClass.FirstDayOdYear(date);
            //assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Проверка метода FirstDayOdYear
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_FirstDayOdYear_ReturnFalse()
        {
            //data
            DateTime date = DateTime.Now;
            //act
            bool result = DataTimeClass.FirstDayOdYear(date);
            //assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Проверка метода TimeSpanPeriods
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_TimeSpanPeriods_ReturnExpected()
        {
            //data
            DateTime date1 = DateTime.Now;
            DateTime date2 = date1.AddMinutes(270);
            int time = 10;
            double expected = 27;
            //act
            double result = DataTimeClass.TimeSpanPeriods(date1, date2, time);
            //assert
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// Проверка метода TimeSpanPeriods
        /// </summary>
        [TestMethod]
        public void DataTimeClasTest_TimeSpanPeriods_ReturnExpected2()
        {
            //data
            DateTime date1 = new DateTime(2023, 10, 24, 12, 31, 00);
            DateTime date2 = new DateTime(2023, 10, 25, 20, 30, 20);
            int time = 26;
            double expected = 73.82;
            //act
            double result = DataTimeClass.TimeSpanPeriods(date1, date2, time);
            //assert
            Assert.AreEqual(result, expected);
        }
    }
}
