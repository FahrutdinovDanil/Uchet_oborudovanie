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
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.Collections.ObjectModel;

namespace EquipmentAccounting
{
    /// <summary>
    /// Interaction logic for Admin_menu.xaml
    /// </summary>
    public partial class Admin_menu : Window
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void go_Reg(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Application.Current.MainWindow.Close();
        }

        private void add_Equipment(object sender, RoutedEventArgs e)
        {
            Oborudovanie_Add der = new Oborudovanie_Add();
            der.Show();
            Application.Current.MainWindow.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
