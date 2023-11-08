using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain

{
    public enum StyleMusical {Classique,Pop,Rap,Rock }
    public class Chanson
    {
        public int ChansonId { get; set; }
        [DataType(DataType.Date)]
        public  DateTime DateSortie { get; set; }
        public int Duree {  get; set; }
        public StyleMusical StyleMusical { get; set; }
        [StringLength(12, MinimumLength = 3)]
        public  string Titre { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "La valeur doit etre Positif")]
        public int VuesYoutube { get; set; }
        [ForeignKey("Artiste")]
        public int ArtisteFk { get; set; }
        public virtual Artiste Artiste { get; set; }
        public override string ToString()
        {
            return "Id:" + ChansonId + "Date de Sortie:" + DateSortie + "Duree:" + Duree +
                "Style Musicale:" + StyleMusical + "Titre:" + Titre + "VuesYoutube" + VuesYoutube;
        }
    }
}
