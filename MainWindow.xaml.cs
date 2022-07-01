using ConsultantPlus.control;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        

        public MainWindow()
        {            
            InitializeComponent();
            comboBox.ItemsSource = StartAppLoadData.CreateListPersonal();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            //Manager client = new Manager("Вася","Васильев","Васильевич","123456","0101 235689",10000, DateTime.Now.ToString("dd.MM.yyyy")) {};
            //string str = JsonConvert.SerializeObject(client);
            //File.AppendAllText(@"file.json", str+"\n", Encoding.Default);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {            
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            WindowSkale.Skale1_25(this);
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowSkale.Skale1_25(this);
        }
    }
}
