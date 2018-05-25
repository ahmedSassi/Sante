using Exam.Data.Infrastructure;
using Exam.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service
{
    public class ProduitMedicauxServices : Service<Produit_Medicaux>, IProduitMedicaux
    {

        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ProduitMedicauxServices()
           : base(ut)
        {
        }

        public IEnumerable<Commentaire> getCommentaires(int idPrdtMedic)
        {
            return ut.getRepository<Commentaire>().GetAll().Where(t => t.IDProduit_Medicaux == idPrdtMedic);
        }
    }
}
