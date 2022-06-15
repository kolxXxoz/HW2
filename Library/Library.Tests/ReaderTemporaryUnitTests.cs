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
    public class ReaderTemporaryUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var lilly = CreateTestReaderTemporary();

            Assert.AreEqual("Лилли", lilly.Name);
            Assert.AreEqual("Сато", lilly.Surname);
            Assert.AreEqual(352435, lilly.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var lilly = CreateTestReaderTemporary();
            Assert.AreEqual("Лилли Сато", lilly.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var lilly = CreateTestReaderTemporary();
            lilly.Literature = new List<string> { "Замки Шотландии (Брайль)" };
            lilly.StartDate = new DateTime(2012, 2, 7);
            lilly.Span = new TimeSpan(7, 0, 0, 0);
            lilly.Pawn = 1000;

            var info = lilly.GetInfo();
            Assert.AreEqual(info[0], "Лилли Сато (352435)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tЗамки Шотландии (Брайль)");
            Assert.AreEqual(info[2], "Дата выдачи: 07.02.2012. Срок выдачи: 7 дней. Предполагаемая дата возврата: 14.02.2012. Сумма залога: 1000 йен");
            Assert.AreEqual(info[3], "Временный читатель. Дата окончания допуска: 01.01.2013. Доступные отделы:\n\tКниги на шрифте Брайля\n\tАудиокниги");
        }

        private Reader CreateTestReaderTemporary()
        {
            return new ReaderTemporary("Лилли", "Сато", 352435, new DateTime(2013, 1, 1), new List<string> { "Книги на шрифте Брайля", "Аудиокниги" });
        }
    }
}
