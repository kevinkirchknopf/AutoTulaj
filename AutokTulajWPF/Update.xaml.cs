using AutokLibary;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AutokTulajWPF
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public IAppServices _appServices;
        public Update()
        {
            InitializeComponent();
            _appServices = App.Current.Services.GetService<IAppServices>();
            ObservableCollection<Tulaj> Tulajok = _appServices.GetAllTulaj();
            this.DataContext = Tulajok;
        }

        

       

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            _appServices.UpdateTulaj((Tulaj)dgCars.SelectedItem);
        }
    }
}
