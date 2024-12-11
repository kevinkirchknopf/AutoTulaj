using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokLibary
{
    public class Tulaj
    {
        public int id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }
        public string?  gender { get; set; }
        public string? Country { get; set; }
        public string? language { get; set; }
        public string? picture { get; set; }
        
        public List<AutoEsTulaj> AutokesTulaj  { get; set; }
    }
}
