using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryReposotory Category { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        IShoppingCartReposotory ShoppingCart { get; }
        IApplicationUserReposotory ApplicationUser { get; }
        IOrderHeaderReposotory OrderHeader { get; }
        IOrderDetailReposotory OrderDetail { get; }
        void Save();
    }
}
