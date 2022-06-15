using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReaderRegular : Reader
    {
        public DateTime RegistrationDate;
        public string Adress;
        public long PhoneNumber;

        public ReaderRegular(string name, string surname, int number, DateTime registration, string adress, long phone) : base(name, surname, number)
        {
            RegistrationDate = registration;
            Adress = adress;
            PhoneNumber = phone;
        }

        public override string[] GetInfo()
        {
            var info = new string[4];
            info[0] = base.GetInfo()[0];
            info[1] = base.GetInfo()[1];
            info[2] = base.GetInfo()[2];
            info[3] = $"Постоянный читатель. Дата записи: {RegistrationDate:d}. Адрес: {Adress}. Номер телефона: {PhoneNumber}.";
            return info;
        }
    }
}
