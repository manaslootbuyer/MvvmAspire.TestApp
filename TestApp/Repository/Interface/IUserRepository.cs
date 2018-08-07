

using TestApp.Models;

namespace TestApp.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserModel Get();

        void Add(UserModel user);

        void Delete();
    }
}