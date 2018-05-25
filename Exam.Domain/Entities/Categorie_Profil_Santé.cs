using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Categorie_Profil_Santé
    {
        [Key]
        public int IdCategorieProfilSante { get; set; }
        public string  NomCategorieProfilSante { get; set; }
        public ICollection<Profil_Santé> profilsSante { get; set; }
    }
}
