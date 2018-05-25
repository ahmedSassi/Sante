using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
   public  class Categorie_Medicaments
    {
        [Key]
        public int IDCategorieMedicament { get; set; }
        public string NomCategorieMedicament { get; set; }
        public ICollection<Produit_Medicaux> pdtmedicaux { get; set; }
    }
}
