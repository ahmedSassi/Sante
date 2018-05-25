using Exam.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service
{
    public interface IProduitMedicaux :IService<Produit_Medicaux>
    {
        IEnumerable<Commentaire> getCommentaires(int idPrdtMedic);

    }
}
