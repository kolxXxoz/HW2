using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
    {
        public string Name;
        public string Surname;
        public readonly int Number;

        public List<string> Literature;
        public DateTime StartDate;
        public TimeSpan Span;
        public int Pawn;

        public DateTime EndDate
        {
            get
            {
                DateTime temp = StartDate + Span;
                return temp.Date;
            }
        }

        public Reader(string name, string surname, int number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{this} ({Number})\nСписок взятой литературы:");

            foreach (var i in Literature)
                Console.WriteLine($"\t{i}");

            Console.WriteLine($"Дата выдачи: {StartDate}. Срок выдачи: {Span}. Предполагаемая дата возврата: {EndDate}. Сумма залога: {Pawn}");
        }
    }
}
