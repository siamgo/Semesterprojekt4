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
        [Test]
        public void Add_2and2_Equals4()
        {
            PlooderLibClass plooder = new PlooderLibClass();
            Assert.That(plooder.Add(2,2), Is.EqualTo(4));
        }
    }
    /*
    Making a conflict to demonstrate Git
    */
}
