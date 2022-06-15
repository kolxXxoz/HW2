using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Visitor : Reader
    {
        public DateTime StartTime;
        public DateTime EndTime;
        public string Document;
        public long DocumentNumber;

        public Visitor(string name, string surname, int number, DateTime start, DateTime end, string doc, long docNumber) : base(name, surname, number)
        {
            StartTime = start;
            EndTime = end;
            Document = doc;
            DocumentNumber = docNumber;
        }

        public override string[] GetInfo()
        {
            var info = new string[4];
            info[0] = base.GetInfo()[0];
            info[1] = base.GetInfo()[1];
            info[2] = base.GetInfo()[2];
            info[3] = $"Посетитель. Время посещения: {StartTime:t} - {EndTime:t}. {Document}: {DocumentNumber}";
            return info;
        }
    }
}
