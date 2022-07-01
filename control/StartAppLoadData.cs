using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantPlus.control
{
    internal class StartAppLoadData
    {
        static List<Manager> managers = new List<Manager>();
        static List<Consultant> consultants = new List<Consultant>();
        static List<Client> clients = new List<Client>();

        public static List<Person> CreateListPersonal()
        {
            List<Person> tmpList = new List<Person>();

            tmpList.AddRange(StartAppLoadData.readJsonFileManager());
            tmpList.AddRange(StartAppLoadData.readJsonFileConsultant()); 
            
            return tmpList;
        }

        public static List<Manager> readJsonFileManager()
        {
            string[] tmpArray = File.ReadAllLines("Manager.json");

            foreach (string tmp in tmpArray)
            {
                Manager m = JsonConvert.DeserializeObject<Manager>(tmp);
                managers.Add(m);
            }

            return managers;
        }

        public static List<Consultant> readJsonFileConsultant()
        {
            string[] tmpArray = File.ReadAllLines("Consultant.json");

            foreach (string tmp in tmpArray)
            {
                Consultant m = JsonConvert.DeserializeObject<Consultant>(tmp);
                consultants.Add(m);
            }

            return consultants;
        }

        public static List<Client> readJsonFileClient()
        {
            string[] tmpArray = File.ReadAllLines("Client.json");

            foreach (string tmp in tmpArray)
            {
                Client m = JsonConvert.DeserializeObject<Client>(tmp);
                clients.Add(m);
            }

            return clients;
        }

    }
}
