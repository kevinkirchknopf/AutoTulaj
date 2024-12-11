using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokLibary
{
    public interface IAppServices
    {
        public ObservableCollection<Tulaj> GetAllTulaj();
        public void UpdateTulaj(Tulaj tulaj);
    }
}
