using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AboMag.Models
{
    public class Publication
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Veuillez saisir un titre")]
        public string Titre { get; set; }

        [Display(Name ="Nombre de numéro à l'année")]
        public int NbNumero { get; set; }

        [Display(Name ="Photo de couverture")]
        public string Couverture { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Display(Name ="Prix à l'année"), DataType(DataType.Currency)]
        public decimal PrixAnnuel { get; set; }
    }
}
