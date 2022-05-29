using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task13;
using NUnit.Framework;

namespace task13.tests
{
    [TestFixture]
    public class StierlitzTests
    {
        [Test]
        public void EncryptionDecryptionTest()
        {
            var test1 = TestInput1();
            var test2 = TestInput2();

            Assert.AreEqual(test1.Encrypt().Decrypt().Message, "stierlitz");
            Assert.AreEqual(test2.Encrypt().Decrypt().Message, "alitlebe");
        }

        private Stierlitz TestInput1()
        {
            return new Stierlitz("stierlitz");
        }

        private Stierlitz TestInput2()
        {
            return new Stierlitz("A little bee");
        }
    }
}
