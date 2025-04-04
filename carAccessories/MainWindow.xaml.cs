using DataBaseAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace carAccessories
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            SqlCrud sqlDb = new SqlCrud(GetMyConnectionString());
            
            tableItem.ItemsSource = sqlDb.ReadAllStuff();           
        }
        public string GetMyConnectionString(string connectionString = "Default")
        {
            
            string output = "";
            var Builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json");

            var config = Builder.Build();

            output= config.GetConnectionString(connectionString);
            return output;
        }
    }
}
