namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface ICanUpdateEntiry<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}
