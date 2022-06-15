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

            Assert.AreEqual("Хисао", hisao.Name);
            Assert.AreEqual("Накай", hisao.Surname);
            Assert.AreEqual(717171, hisao.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var hisao = CreateTestReader();
            Assert.AreEqual("Хисао Накай", hisao.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var hisao = CreateTestReader();
            hisao.Literature = new List<string> { "Митио Каку. Собрание сочинений" };
            hisao.StartDate = new DateTime(2012, 1, 4);
            hisao.Span = new TimeSpan(7, 0, 0, 0);
            hisao.Pawn = 1000;

            var info = hisao.GetInfo();
            Assert.AreEqual(info[0], "Хисао Накай (717171)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tМитио Каку. Собрание сочинений");
            Assert.AreEqual(info[2], "Дата выдачи: 04.01.2012. Срок выдачи: 7 дней. Предполагаемая дата возврата: 11.01.2012. Сумма залога: 1000 йен");
        }

        private Reader CreateTestReader()
        {
            return new Reader("Хисао", "Накай", 717171);
        }
    }
}
