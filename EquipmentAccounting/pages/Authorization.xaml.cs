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
using System.Collections.ObjectModel;

namespace EquipmentAccounting
{
    /// <summary>
    /// Interaction logic for author.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public static ObservableCollection<bd.Employee> masterss { get; set; }
        public static string name;
        public Authorization()
        {
            InitializeComponent();
        }
        private void autho_event(object sender, RoutedEventArgs e)
        {
            masterss = new ObservableCollection<bd.Employee>(bd_connection.connection.Employee.ToList());
            var z = masterss.Where(a => a.Login == txt_login.Text && a.Password == txt_password.Password).FirstOrDefault();
            
            if (z != null)
            {
                MessageBox.Show($"Добро пожаловать, { z.Name}");
                name = z.Name;
                if (z.Id_position == 1)
                {
                    Admin_menu menu = new Admin_menu();
                    menu.Show();
                    Application.Current.MainWindow.Close();
                }
                else
                {
                    NavigationService.Navigate(new Technic_menu(z.Id_employee));
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль неверные", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
