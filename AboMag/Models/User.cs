using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AboMag.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un nom")]
        public string Nom { get; set; }

        [Display(Name = "Prénom"), Required(ErrorMessage = "Veuillez saisir un prénom")]
        public string Prenom { get; set; }

        [EmailAddress(ErrorMessage ="Ce mail n'est pas valide")]
        [Required(ErrorMessage = "Veuillez saisir un mail")]
        public string Mail { get; set; }

        [DataType(DataType.Date), Display(Name = "Date de naissance"), Required(ErrorMessage = "Veuillez saisir une date de naissance")]
        public DateTime DateNaissance { get; set; }

        [Display(Name ="Lieu de naissance")]
        public string LieuNaissance { get; set; }

        
        public string Password { get; set; }


    }
}
