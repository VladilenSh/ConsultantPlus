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

        public static List<Manager> readJsonFile()
        {
            string[] tmpArray = File.ReadAllLines("Manager.json");

            foreach (string tmp in tmpArray)
            {
                Manager m = JsonConvert.DeserializeObject<Manager>(tmp);
                managers.Add(m);
            }

            return managers;
        }
    }
}
