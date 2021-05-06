using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTp_Lab2.Models
{
    public class Studio
    {
        public Studio() {
            Films = new List<Film>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Info { get; set; }
        
        public virtual ICollection<Film> Films { get; set; }

    }
}
