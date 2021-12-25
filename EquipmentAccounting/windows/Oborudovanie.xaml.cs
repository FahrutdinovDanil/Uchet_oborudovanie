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
    /// Interaction logic for Oborudovanie.xaml
    /// </summary>
    public partial class Oborudovanie : Window
    {
        public DataGrid grid;
        public bool loaded = false;
        public Oborudovanie()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grid = dgogrenci;
            loaded = true;
            var query =
            from Equipment in bd_connection.connection.Equipment
            select new { Equipment.Id_equipment, Equipment.Name_equipment, Equipment.Id_type, Equipment.Id_plot};
            dgogrenci.ItemsSource = query.ToList();
        }
    }
}
