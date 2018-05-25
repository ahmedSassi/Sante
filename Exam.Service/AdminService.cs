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
 public   class AdminService: Service<Admin>, IadminService
    {
        public AdminService():base(ut)
        {

        }
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
    }
}
