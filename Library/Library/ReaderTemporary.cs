using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReaderTemporary : Reader
    {
        public DateTime AccessDate;
        public List<string> Sections;

        public ReaderTemporary(string name, string surname, int number, DateTime access, List<string> sections) : base(name, surname, number)
        {
            AccessDate = access;
            Sections = sections;
        }

        public override string[] GetInfo()
        {
            var info = new string[4];
            info[0] = base.GetInfo()[0];
            info[1] = base.GetInfo()[1];
            info[2] = base.GetInfo()[2];
            info[3] = $"Временный читатель. Дата окончания допуска: {AccessDate:d}. Доступные отделы:";

            foreach (var i in Sections)
                info[3] += $"\n\t{i}";

            return info;
        }
    }
}
