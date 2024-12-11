    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AutokLibary
    {


        public class AppServices : IAppServices
        {
            public readonly AutoTulajContext _c;
            public AppServices()
            {
                _c = new AutoTulajContext();
            }
            public ObservableCollection<Tulaj> GetAllTulaj()
            {
                return new ObservableCollection<Tulaj>((from f in _c.people.Include(c => c.AutokesTulaj).ThenInclude(c =>c.car) select f));
            }

        public void UpdateTulaj(Tulaj tulaj)
        {
            var updatePost = (from x in _c.people where x.id == tulaj.id select x).FirstOrDefault();
            updatePost.first_name = tulaj.first_name; updatePost.last_name = tulaj.last_name; updatePost.email = tulaj.email; updatePost.gender = tulaj.gender; updatePost.Country = tulaj.Country; updatePost.language = tulaj.language; _c.SaveChanges();
        }
    }
    }
