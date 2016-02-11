using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Plooder.Unit.Test
{
    [TestFixture]
    public class PlooderTest
    {
        private PlooderLibClass _plooder;

        [SetUp]
        public void Setup()
        {
            _plooder = new PlooderLibClass();
        }

        [Test]
        public void Add_2and2_Equals4()
        {
            Assert.That(_plooder.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Subtract_4from3_Equals1()
        {
            Assert.That(_plooder.Subtract(4, 3), Is.EqualTo(1));
        }
    }
}
