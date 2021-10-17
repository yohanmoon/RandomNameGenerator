using System;
using System.Collections.Generic;
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
using System.Collections;


namespace RandomNameGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        



        private void btnPickName_Click(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            int result = ran.Next(0, 14);

            List<object> randomList = new List<object>
            {
                Name1.Content,Name2.Content,Name3.Content,
                Name4.Content,Name5.Content, Name6.Content, 
                Name7.Content, Name8.Content, Name9.Content, 
                Name10.Content,Name11.Content, Name12.Content, 
                Name13.Content, Name14.Content

            };
            List<string> randomListString =
                randomList.Select(s => (string)s).ToList();
            string name = randomListString[result];
            textRandomName.Text = name;

            
        }

        
    }
}
