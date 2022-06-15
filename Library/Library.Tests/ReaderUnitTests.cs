using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;

namespace Library.Tests
{
    [TestFixture]
    public class ReaderUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var hisao = CreateTestReader();

            Assert.AreEqual("Ханако", hisao.Name);
            Assert.AreEqual("Икедзава", hisao.Surname);
            Assert.AreEqual(717171, hisao.Number);
        }

        [Test]
        public void TimeTest()
        {
            var hisao = CreateTestReader();

            hisao.StartDate = new DateTime(2012, 1, 4);
            hisao.Span = new TimeSpan(7, 0, 0, 0);

            Assert.AreEqual(hisao.EndDate, new DateTime(2012, 1, 11));
        }

        [Test]
        public void ToStringTest()
        {
            var hisao = CreateTestReader();
            Assert.AreEqual("Хисао Накай", hisao.ToString());
        }

        private Reader CreateTestReader()
        {
            return new Reader("Хисао", "Накай", 717171);
        }

    }
}
