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

namespace Лопушок
{
    /// <summary>
    /// Логика взаимодействия для ProdListPage.xaml
    /// </summary>
    public partial class ProdListPage : Page
    {
        public ProdListPage()
        {
            InitializeComponent();
            LV.ItemsSource = DB.con.Продукты.ToList();
        }

        private void Cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cbx.SelectedIndex == 0)
            {
                LV.ItemsSource = DB.con.Продукты.ToList();

            }
            if (Cbx.SelectedIndex == 1)
            {
                string s = "Набор";
                LV.ItemsSource = DB.con.Продукты.Where(a=>a.Наименование_продукции.Contains(s)).ToList();

            }
            if (Cbx.SelectedIndex == 2)
            {
                string s = "Бумага";
                LV.ItemsSource = DB.con.Продукты.Where(a => a.Наименование_продукции.Contains(s)).ToList();

            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var prod = LV.SelectedItem as Продукты;
            NavigationService.Navigate(new AEprod(prod));

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AEprod(new Продукты()));
        }
    }
}
