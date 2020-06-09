namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface ICanAddEntity<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
    }
}
