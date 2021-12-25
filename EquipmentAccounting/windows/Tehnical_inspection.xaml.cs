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
    /// Interaction logic for Tehnical_inspection.xaml
    /// </summary>
    public partial class Tehnical_inspection : Window
    {
        public DataGrid grid;
        public bool loaded = false;
        public Tehnical_inspection()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grid = InspectionGrid;
            loaded = true;
            var query =
            from Technical_inspection in bd_connection.connection.Technical_inspection
            select new {Technical_inspection.Id_inspection, Technical_inspection.Date_inspection, Technical_inspection.Result, Technical_inspection.Id_employee,
                Technical_inspection.Id_equipment, Technical_inspection.Done, Technical_inspection.Status};
            InspectionGrid.ItemsSource = query.ToList();
        }
    }
}
