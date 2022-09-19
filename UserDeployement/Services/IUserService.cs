using UserDeployement.Entities;

namespace UserDeployement.Services
{
    public interface IUserService
    {
        public Task<(bool IsSuccess, Exception Exception, User User)> CreateAsync(User user);

        public Task<(bool IsSuccess, Exception Exception)> InsertUserAsync(User user);
    }
}