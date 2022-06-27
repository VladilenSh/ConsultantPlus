using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantPlus.person
{
    internal class Client : Person
    {
        public Client(string firstName, string lastName, string patronymic, string phoneNumber, string passportData) : base(firstName, lastName, patronymic, phoneNumber, passportData)
        {
        }
    }
}
