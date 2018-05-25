using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Patient
    {
        [Key]
        public int IDPatient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public int Num_Tel { get; set; }
        public string Sexe { get; set; }
        public DateTime Date_Inscription { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public string Actif { get; set; }
        public ICollection<Commentaire> Commentaires { get; set; }
        public ICollection<RDV> RDVs { get; set; }
    }
}
