using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConsultantPlus
{

    

    public partial class MainWindow : Window
    {
        List<Manager> managers = new List<Manager>();
        List<Consultant> consultants = new List<Consultant>();
        List<Client> clients = new List<Client>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client("Вася","Васильев","Васильевич","123456","0101 235689") {};
            string str = JsonConvert.SerializeObject(client);
            File.AppendAllText(@"file.json", str, Encoding.Default);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
