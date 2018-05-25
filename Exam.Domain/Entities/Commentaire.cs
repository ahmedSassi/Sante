using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
   public  class Commentaire
    {
        [Key, Column(Order = 0)]
        public int IDPatient { get; set; }

        [Key, Column(Order = 1)]
        public int IDProduit_Medicaux { get; set; }
        [Key, Column(Order = 2)]
        public string Description { get; set; }
        public DateTime datecommentaire { get; set; }
        public Produit_Medicaux pdtsMedic { get; set; }
        public Patient Patient { get; set; }

    }
}
