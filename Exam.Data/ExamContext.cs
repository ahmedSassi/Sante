using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public  class ExamContext :DbContext
    {
       
        public ExamContext():base("name=BibDB")
        {

        }
        DbSet<Admin> Admin { get; set; }
        DbSet<RDV> RDV { get; set; }
        DbSet<Commentaire> Commentaire { get; set; }
        DbSet<Formation> Formation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
