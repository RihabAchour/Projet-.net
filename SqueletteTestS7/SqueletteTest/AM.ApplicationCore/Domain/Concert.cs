using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Concert
    {
        public double Cachet {  get; set; }
      
        public DateTime DateConcert { get; set; }
        public int Duree {  get; set; }
        [ForeignKey("Artiste")]
        public int ArtisteFk { get; set; }
        public virtual Artiste Artiste { get; set; }
        [ForeignKey("Festival")]
        public int Festivalfk { get; set; }
        public Festival Festival { get; set; }
    }
}
