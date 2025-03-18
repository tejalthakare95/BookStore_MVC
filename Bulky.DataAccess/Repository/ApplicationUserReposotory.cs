using Bulky.DataAccess;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ApplicationUserReposotory : Repository<ApplicationUser>, IApplicationUserReposotory
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserReposotory(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
      
    }
}
