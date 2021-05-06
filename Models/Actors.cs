using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTp_Lab2.Models
{
    public class Actors
    {
        public Actors() {
  
        }

        public int Id { get; set; }
       //[Required(ErrorMessage = "")]
        public string Name { get; set; }

        public int FilmId { get; set; }

        public virtual Film Film { get; set; }

      


    }
}
