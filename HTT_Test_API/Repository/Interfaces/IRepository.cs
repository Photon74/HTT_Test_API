namespace HTT_Test_API.Repository.Interfaces
{
    public interface IRepository<TEntity, TId>
    {
        IList<TEntity> GetAll();

        //TEntity GetById(TId id);

        //TId Create(TEntity data);

        //int Update(TEntity data);

        //int Delete(TId id);
    }
}
