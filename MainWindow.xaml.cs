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
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            //Manager client = new Manager("Вася","Васильев","Васильевич","123456","0101 235689",10000, DateTime.Now.ToString("dd.MM.yyyy")) {};
            //string str = JsonConvert.SerializeObject(client);
            //File.AppendAllText(@"file.json", str+"\n", Encoding.Default);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            List<Person> tmpList = new List<Person>();

            tmpList.AddRange(StartAppLoadData.readJsonFileManager());
            tmpList.AddRange(StartAppLoadData.readJsonFileConsultant());

            comboBox.ItemsSource = tmpList;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var scaler = mainPanel.LayoutTransform as ScaleTransform;

            if (scaler == null)
            {                
                mainPanel.LayoutTransform = new ScaleTransform(1.25, 1.25);
                this.Height = 560;
                this.Width = 1000;
            }
            else
            {
                double curZoomFactor = scaler.ScaleX;                

                if (scaler.HasAnimatedProperties)
                {                    
                    scaler.BeginAnimation(ScaleTransform.ScaleXProperty, null);
                    scaler.BeginAnimation(ScaleTransform.ScaleYProperty, null);
                }

                if (curZoomFactor == 1.0)
                {
                    scaler.ScaleX = 1.25;
                    scaler.ScaleY = 1.25;
                    this.Height = 560;
                    this.Width = 1000;
                }
                else
                {
                    scaler.ScaleX = 1.0;
                    scaler.ScaleY = 1.0;
                    this.Height = 448;
                    this.Width = 800;
                }
            }
        }
    }
}
