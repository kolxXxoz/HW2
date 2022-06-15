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
    public class VisitorUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var akira = CreateTestVisitor();

            Assert.AreEqual("Акира", akira.Name);
            Assert.AreEqual("Сато", akira.Surname);
            Assert.AreEqual(0, akira.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var akira = CreateTestVisitor();
            Assert.AreEqual("Акира Сато", akira.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var akira = CreateTestVisitor();
            akira.Literature = new List<string> { "На самом деле она зашла в библиотеку по ошибке..." };
            akira.StartDate = new DateTime(2012, 5, 18);
            akira.Span = new TimeSpan(0, 0, 0, 0);
            akira.Pawn = 0;

            var info = akira.GetInfo();
            Assert.AreEqual(info[0], "Акира Сато (0)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tНа самом деле она зашла в библиотеку по ошибке...");
            Assert.AreEqual(info[2], "Дата выдачи: 18.05.2012. Срок выдачи: 0 дней. Предполагаемая дата возврата: 18.05.2012. Сумма залога: 0 йен");
            Assert.AreEqual(info[3], "Посетитель. Время посещения: 14:00 - 14:15. Паспорт: 2662896189");
        }

        private Reader CreateTestVisitor()
        {
            return new Visitor("Акира", "Сато", 0, new DateTime(2012, 5, 18, 14, 0, 0), new DateTime(2012, 5, 18, 14, 15, 0), "Паспорт", 2662896189);
        }
    }
}
