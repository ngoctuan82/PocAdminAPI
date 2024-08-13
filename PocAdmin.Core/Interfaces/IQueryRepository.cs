namespace PocAdmin.Core.Interfaces
{
    public interface IQueryRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetById(int id);
    }

}
