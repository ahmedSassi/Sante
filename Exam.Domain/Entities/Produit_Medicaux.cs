using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Produit_Medicaux
    {
        [Key]
        public int IDProduit_Medicaux { get; set; }
        public string NomProduit_Medicaux { get; set; }
        public string Qantite { get; set; }
       
        public float Prix { get; set; }
        public Categorie_Medicaments Categorie_Medicaments { get; set; }
        public ICollection<Commentaire>Commentaires { get; set; }
        public Admin Admin { get; set; }
        public int IDAdmin { get; set; }
    }
}
