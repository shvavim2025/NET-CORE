public interface IUserRepository
{
    User GetByUserNamePassword(string userName, string password);
}