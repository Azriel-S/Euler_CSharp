using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Euler_Library;

namespace Euler_Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Euler1_Test()
        {
            Euler1 e1 = new Euler1();

            int result = e1.FindNaturalNumbers();
            Assert.That(result, Is.EqualTo(233168));
        }
    }
}
