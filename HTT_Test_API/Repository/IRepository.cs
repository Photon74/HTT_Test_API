namespace HTT_Test_API.Repository
{
    public interface IRepository<TEntity, TId>
    {
        Task<IList<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task<TId> Create(TEntity data);

        Task<int> Update(TEntity data);

        Task<int> Delete(TId id);
    }
}
