using System.Threading.Tasks;

namespace UnitOfWork.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private IUserRepository _User;

        private IProductRepository _Product;
        public IUserRepository User
        {
            get
            {
                if (this._User == null)
                {
                    this._User = new UserRepository(dbContext);
                }
                return this._User;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (this._Product == null)
                {
                    this._Product = new ProductRepository(dbContext);
                }
                return this._Product;
            }
        }
        public int Complete()
        {
            return dbContext.SaveChanges();
        }
        public void Dispose() => dbContext.Dispose();
    }
}