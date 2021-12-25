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
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public DataGrid grid;
        public bool loaded = false;
        public Employee()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grid = EmployeeGrid;
            loaded = true;
            var query =
            from Employee in bd_connection.connection.Employee
            select new
            {
                Employee.Id_employee,
                Employee.Name,
                Employee.Surname,
                Employee.Patronymic,
                Employee.Id_position,
                Employee.Login,
                Employee.Password
            };
            EmployeeGrid.ItemsSource = query.ToList();
        }
    }
}
