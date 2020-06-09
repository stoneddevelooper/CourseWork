namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface ICanGetEntity<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}
