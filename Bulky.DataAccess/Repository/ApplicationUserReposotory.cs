using BookStoreWeb.DataAccess;
using BookStoreWeb.DataAccess.Repository.IRepository;
using BookStoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository
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
