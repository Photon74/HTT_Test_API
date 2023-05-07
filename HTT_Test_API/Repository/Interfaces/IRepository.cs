namespace HTT_Test_API.Repository.Interfaces
{
    public interface IRepository<TEntity, TId>
    {
        IList<TEntity> GetAll();
    }
}
