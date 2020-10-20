namespace UnitOfWork.UOW
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        int Complete();
        void Dispose();
    }
}