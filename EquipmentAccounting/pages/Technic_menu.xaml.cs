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
    /// Interaction logic for Technic_menu.xaml
    /// </summary>
    public partial class Technic_menu : Page
    {
        public static ObservableCollection<bd.Equipment_failure> state { get; set; }
        public int Id_employee;

        public Technic_menu(int Id_user)
        {
            InitializeComponent();
            Id_employee = Id_user;
            this.DataContext = this;
            state = new ObservableCollection<bd.Equipment_failure>(bd_connection.connection.Equipment_failure.ToList());
        }
        private void EndRepair_Click(object sender, RoutedEventArgs e)
        {
            var s = Status_State.SelectedItem as bd.Equipment_failure;
            var r = new bd.Technical_inspection();
            r.Id_equipment = Convert.ToInt32(ID_request.Text);

            r.Id_employee = Id_employee;
            r.Status = s.Reason;
            r.Done = true;
            r.Result = Solution.Text;
            r.Date_inspection = DateTime.Now;
            bd_connection.connection.Technical_inspection.Add(r);
            bd_connection.connection.SaveChanges();

            if (check_box.IsChecked == true)
            {
                var k = new bd.Breakdown_during_inspection();
                k.Date_breaking = DateTime.Now;
                k.Id_employee = Id_employee;
                k.Status = s.Reason;
                k.Id_inspection = r.Id_inspection;
                bd_connection.connection.Breakdown_during_inspection.Add(k);
                bd_connection.connection.SaveChanges();
            }
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Equipment menu = new Equipment();
            menu.Show();
            //Application.Current.MainWindow.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tehnical_inspection menu = new Tehnical_inspection();
            menu.Show();
        }
        void LoopVisualTree(DependencyObject obj)//обнуление текст боксов
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {

                if (obj is TextBox)
                {
                    ((TextBox)obj).Text = null;
                }
                // РЕКУРСИЯ
                LoopVisualTree(VisualTreeHelper.GetChild(obj, i));
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoopVisualTree(this);
        }
    }
}
