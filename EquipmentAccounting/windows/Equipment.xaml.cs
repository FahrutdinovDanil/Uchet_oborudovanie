using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
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
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Configuration;

namespace EquipmentAccounting
{
    /// <summary>
    /// Interaction logic for Equipment.xaml
    /// </summary>
    public partial class Equipment : Window
    {
        public DataGrid grid;
        public bool loaded = false;

        public Equipment()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grid = EquipmentGrid;
            loaded = true;
            var query =
            from Equipment in bd_connection.connection.Equipment
            select new { Equipment.Id_equipment, Equipment.Name_equipment, Equipment.Id_type, Equipment.Id_plot};
            EquipmentGrid.ItemsSource = query.ToList();
        }

        //private void deleteButton_Click(object sender, RoutedEventArgs e)
        //{
        //    DataRowView row = (DataRowView)EquipmentGrid.SelectedItem;
        //    db.dt.Tables[0].Rows.Remove(row.Row);
        //    dt.Rows.Remove(row.Row);
        //    db.Update();
        //    EquipmentGrid.Items.Refresh();
        //}

        //public object SelectedObject
        //{
        //    get
        //    {
        //        if (EquipmentGrid.SelectedItem == null)
        //            return null;

        //        return EquipmentGrid.SelectedItem;
        //    }
        //}
    }
}
