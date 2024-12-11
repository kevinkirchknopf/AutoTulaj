using AutokLibary;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.Windows;

namespace AutokTulajWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IAppServices _appServices;
        public MainWindow()
        {
            InitializeComponent();
            _appServices = App.Current.Services.GetService<IAppServices>();
            ObservableCollection<Tulaj> Tulajok = _appServices.GetAllTulaj();
            this.DataContext = Tulajok;
        }

        private void showcarsbutton_Click(object sender, RoutedEventArgs e)
        {
          
                Update u = new Update();
            u.Show();
              
          
        }

        private void Szerk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
