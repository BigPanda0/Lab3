using System;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            double radius = 5;
            double radiusKonusa = 3;
            var expected = 224.10000000000002;
            var result = Area.PloshadShara(radius, radiusKonusa);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test1()
        {
            double radius = 6;
            double radiusKonusa = 0;

            Assert.Throws<ArgumentException>(() => Area.PloshadShara(radius, radiusKonusa));

        }
    }
}