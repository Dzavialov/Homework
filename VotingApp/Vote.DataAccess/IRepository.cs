namespace Vote.DataAccess
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity Get(int id);
        void Create(TEntity entity);
    }
}
