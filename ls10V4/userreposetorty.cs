public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }

    public User GetByUserNamePassword(string userName, string password)
    {
        return this._dbSet.Where(u => u.UserName == userName && u.Password == password).FirstOrDefault();
    }
}