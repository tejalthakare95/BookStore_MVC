using BookStoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository.IRepository
{
    public interface ICategoryReposotory : IRepository<Category>
    {
        void Update(Category obj);
    }
}
