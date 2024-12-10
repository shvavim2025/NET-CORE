public class RepositoryManager : IRepositoryManager
{
    private readonly DataContext _context;
    public IRepository<User> Users { get; }

    public RepositoryManager(DataContext context, IRepository<User> userRepository)
    {
        _context = context;
        Users = userRepository;
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}