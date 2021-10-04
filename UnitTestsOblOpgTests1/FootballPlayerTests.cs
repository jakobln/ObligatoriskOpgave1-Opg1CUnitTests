using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsOblOpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsOblOpg.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _player;

        [TestInitialize]
        public void BeforeTest()
        {
            _player = new FootballPlayer(1, "Anders", 100, 100);
        }

        /*[TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }*/

        [TestMethod]
        public void TestNameNull()
        {
            Assert.AreEqual("Anders", _player.Name);
            Assert.ThrowsException<ArgumentNullException>(() => _player.Name = null);
            Assert.AreEqual("Anders", _player.Name);
        }

        [TestMethod]
        public void TestNameLength()
        {
            Assert.AreEqual("Anders", _player.Name);
            Assert.ThrowsException<ArgumentException>(() => _player.Name = "Jon");
            Assert.AreEqual("Anders", _player.Name);
        }

        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(100, _player.Price, 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Price = 0);
            Assert.AreEqual(100, _player.Price, 0);
        }

        [TestMethod]
        public void TestShirtNumberTooHigh()
        {
            Assert.AreEqual(100, _player.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 101);
            Assert.AreEqual(100, _player.ShirtNumber);
        }

        [TestMethod]
        public void TestShirtNumberTooLow()
        {
            _player.ShirtNumber = 1;
            Assert.AreEqual(1, _player.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 0);
            Assert.AreEqual(1, _player.ShirtNumber);
        }
    }
}