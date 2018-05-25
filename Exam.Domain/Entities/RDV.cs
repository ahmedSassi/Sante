using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class RDV
    {
        
        

   
        [Key,Column(Order =0)]
        public DateTime DateRdv { get; set; }
        public DateTime DatePriseRdv { get; set; }
        [Key, Column(Order = 1)]
        public int IDProfilSanté { get; set; }
      
        public Profil_Santé Profil_Santé { get; set; }
        [Key, Column(Order = 2)]
        public int IDPatient { get; set; }
        public Patient Patient { get; set; }



    }
}
