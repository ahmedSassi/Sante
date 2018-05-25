using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Categorie_Formation
    {
        [Key]
        public int IDCategorieFormation { get; set; }
        public string NomCategorieFormation { get; set; }
        public ICollection<Formation> Formations { get; set; }

    }
}
