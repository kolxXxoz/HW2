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
    public class ReaderRegularUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var hanako = CreateTestReaderRegular();

            Assert.AreEqual("Ханако", hanako.Name);
            Assert.AreEqual("Икедзава", hanako.Surname);
            Assert.AreEqual(342233, hanako.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var hanako = CreateTestReaderRegular();
            Assert.AreEqual("Ханако Икедзава", hanako.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var hanako = CreateTestReaderRegular();
            hanako.Literature = new List<string> { "Янн Мартел. Жизнь Пи", "Фрэнк Герберт. Дюна" };
            hanako.StartDate = new DateTime(2012, 7, 10);
            hanako.Span = new TimeSpan(7, 0, 0, 0);
            hanako.Pawn = 1000;

            var info = hanako.GetInfo();
            Assert.AreEqual(info[0], "Ханако Икедзава (342233)");
            Assert.AreEqual(info[1], "Список взятой литературы:\n\tЯнн Мартел. Жизнь Пи\n\tФрэнк Герберт. Дюна");
            Assert.AreEqual(info[2], "Дата выдачи: 10.07.2012. Срок выдачи: 7 дней. Предполагаемая дата возврата: 17.07.2012. Сумма залога: 1000 йен");
            Assert.AreEqual(info[3], "Постоянный читатель. Дата записи: 29.04.2009. Адрес: Женское общежитие Акажемии Ямаку. Номер телефона: 865684.");
        }

        private Reader CreateTestReaderRegular()
        {
            return new ReaderRegular("Ханако", "Икедзава", 342233, new DateTime(2009, 4, 29), "Женское общежитие Акажемии Ямаку", 865684);
        }
    }
}
