using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestAddition()
        {
            var x = 1;
            var y = 2;

            Assert.AreEqual(3, x + y);
        }

        [Test]
        public void TestSubtraction()
        {
            var x = 3;
            var y = 2;

            Assert.AreEqual(1, x - y);
        }

        [Test]
        public void TestFactorial()
        {
            var ft = 5;
            var x = ft;

            for(int i = 1; i < ft; i++)
            {
                x *= i;
            }

            Assert.AreEqual(120, x);
        }

        [Test]
        public void TestDivisionDetectDuplicates()
        {
            var x = 3;
            var y = 3;

            x = 3;
            y = 3;

            x = 3;
            y = 3;

            Assert.AreEqual(1, x / y);
        }
    }
}
