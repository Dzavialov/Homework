namespace Vote.DataAccess
{
    internal interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity Get();
        void Insert(TEntity entity);
    }
}
