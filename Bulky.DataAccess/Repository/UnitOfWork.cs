using Bulky.DataAccess;
using Bulky.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryReposotory Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartReposotory ShoppingCart { get; private set; }
        public IApplicationUserReposotory ApplicationUser { get; private set; }
        public  IOrderDetailReposotory OrderDetail { get; private set; }
        public IOrderHeaderReposotory OrderHeader { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        { 
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            ApplicationUser =  new  ApplicationUserReposotory(_db);
            OrderDetail = new OrderDetailRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);

        }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
