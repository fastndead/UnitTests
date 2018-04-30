using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Практикум1010;

namespace Задание_10_Практикум_10.Tests
{
    [TestClass]
    public class DateTimeTests
    {
        [TestMethod]
        public void TestMGetDaysTillEndOfMonth_01012016_30returned()
        {
            //arrange
            DateTime date = new DateTime(2016, 1, 1);
            int expected = 30;

            //act
            _DateTime x = new _DateTime(date);
            int actual = x.GetDaysTillEndOfMonth();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
