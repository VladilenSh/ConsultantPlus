using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantPlus
{
    internal class Manager : Consultant
    {
        public Manager(string firstName, string lastName, string patronymic, string phoneNumber, string passportData, int salary, string dateHiring)
            : base(firstName, lastName, patronymic, phoneNumber, passportData, salary, dateHiring)
        {
        }
    }
}
