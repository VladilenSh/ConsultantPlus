using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantPlus.person
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string patronymic;
        private string phoneNumber;
        private string passportData;
        private List<string> changingData;

        public Person(string firstName, string lastName, string patronymic, string phoneNumber, string passportData)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.phoneNumber = phoneNumber;
            this.passportData = passportData;
            changingData = new List<string>();
            changingData.Add($"Добавлено администратором {DateTime.Now}");
        }

        public string FirstName { get { return firstName; } set { } }
        public string LastName { get => lastName; set => lastName = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PassportData { get => passportData; set => passportData = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
