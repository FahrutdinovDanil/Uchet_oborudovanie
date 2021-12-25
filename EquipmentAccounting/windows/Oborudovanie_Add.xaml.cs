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
using System.Collections.ObjectModel;

namespace EquipmentAccounting
{
    /// <summary>
    /// Interaction logic for Oborudovanie_Add.xaml
    /// </summary>
    public partial class Oborudovanie_Add : Window
    {
        public static ObservableCollection<bd.Equipment_type> type { get; set; }
        public static ObservableCollection<bd.Production_plot> plot { get; set; }
        public Oborudovanie_Add()
        {
            InitializeComponent();
            this.DataContext = this;
            type = new ObservableCollection<bd.Equipment_type>(bd_connection.connection.Equipment_type.ToList());
            plot = new ObservableCollection<bd.Production_plot>(bd_connection.connection.Production_plot.ToList());
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            var t = Type.SelectedItem as bd.Equipment_type;
            var p = Plot.SelectedItem as bd.Production_plot;
            var eq = new bd.Equipment();
            eq.Name_equipment = Name_equipment.Text;
            eq.Id_type = t.Id_type;
            eq.Id_plot = p.Id_plot;
            bd_connection.connection.Equipment.Add(eq);
            bd_connection.connection.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Oborudovanie menu = new Oborudovanie();
            menu.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
