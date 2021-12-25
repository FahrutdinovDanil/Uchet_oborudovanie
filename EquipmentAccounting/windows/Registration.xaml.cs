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

namespace EquipmentAccounting
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            var a = new bd.Employee();
            a.Name = txt_FName.Text;
            a.Surname = txt_SName.Text;
            a.Patronymic = txt_LName.Text;
            a.Id_position = 2;
            a.Login = txt_login.Text;
            a.Password = txt_password.Text;
            bd_connection.connection.Employee.Add(a);
            bd_connection.connection.SaveChanges();
            MessageBox.Show("Пользователь создан");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee der = new Employee();
            der.Show();
            Application.Current.MainWindow.Close();
        }
    }
}