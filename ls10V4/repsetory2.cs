
public class Repository<T> : IRepository<T> where T : class
{
    protected readonly DbSet<T> _dbSet;

    public Repository(DataContext context)
    {
        _dbSet = context.Set<T>();
    }
