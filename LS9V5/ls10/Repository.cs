public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet;

    public Repository(DataContext context)
    {
        _dbSet = context.Set<T>();
    }
    public T Add(T entity)
    {
        _dbSet.Add(entity);
        return entity;
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public T Update(T entity)
    {
        _dbSet.Update(entity);
        return entity;
    }
}