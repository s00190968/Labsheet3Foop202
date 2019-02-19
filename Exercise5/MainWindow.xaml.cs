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

namespace Exercise5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student localS = new Student();

        public MainWindow()
        {        
            InitializeComponent();

            localS.Name = "Boring Name";
            localS.StudentNumber = "S1234567";
            localS.Email = "S1234567@mail.itsligo.ie";
            localS.PhoneNumber = "086 123 4567";

            MainGrid.DataContext = localS;
        }
    }
}
