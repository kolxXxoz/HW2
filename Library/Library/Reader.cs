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

        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = ToString() + $" ({Number})";
            info[1] = "Список взятой литературы:";

            foreach (var i in Literature)
                info[1] += $"\n\t{i}";

            info[2] = $"Дата выдачи: {StartDate:d}. Срок выдачи: {Span.Days} дней. Предполагаемая дата возврата: {EndDate:d}. Сумма залога: {Pawn} йен";
            return info;
        }
    }
}
