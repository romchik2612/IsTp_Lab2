using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTp_Lab2.Models
{
    public class Film
    {
        public Film() {
            Actors = new List<Actors>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Budget { get; set; }

        public int Mark { get; set; }

        public int CategoryId { get; set; }

        public int StudioId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Studio Studio { get; set; }

        public virtual ICollection<Actors> Actors { get; set; }
    }
}
