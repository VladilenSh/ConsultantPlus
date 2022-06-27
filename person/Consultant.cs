using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantPlus.person
{
    internal class Consultant : Person
    {
        private int salary;
        private string dateHiring;

        public Consultant(string firstName, string lastName, string patronymic, string phoneNumber, string passportData, int salary, string dateHiring) : base(firstName, lastName, patronymic, phoneNumber, passportData)
        {
            this.salary = salary;
            this.dateHiring = dateHiring;
        }

        public int Salary { get => salary; set => salary = value; }
        public string DateHiring { get => dateHiring; set => dateHiring = value; }
    }
}
