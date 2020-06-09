namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface ICanDeleteEntity<TEntity> where TEntity : class
    {
        void Remove(TEntity entity);
    }
}
