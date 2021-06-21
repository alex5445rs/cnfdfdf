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
    /// Логика взаимодействия для AEprod.xaml
    /// </summary>
    public partial class AEprod : Page
    {
        public AEprod(Продукты _pro)
        {
            InitializeComponent();
            
            this.DataContext = this;
            prod = _pro;
            cbType.ItemsSource = DB.con.Тип_продукции.ToList();
        }
        public Продукты prod { get; set; }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (prod.ИД==0)
            {
                DB.con.Продукты.Add(prod);

            }
            DB.con.SaveChanges();
            MessageBox.Show("Информация сохранена");

        }
    }
}
