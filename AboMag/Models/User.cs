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

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Mail { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        public string LieuNaissance { get; set; }

        public string Password { get; set; }


    }
}
