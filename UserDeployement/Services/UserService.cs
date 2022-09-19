using UserDeployement.DataDb;
using UserDeployement.Entities;

namespace UserDeployement.Services
{
    public class UserService : IUserService
    {
        private readonly UserDbContext _ctx;

        public UserService(UserDbContext context)
        {
            _ctx = context;
        }

        public async Task<(bool IsSuccess, Exception Exception, User User)> CreateAsync(User user)
        {
            try
            {
                await _ctx.Users.AddAsync(user);
                await _ctx.SaveChangesAsync();

                return (true, null, user);
            }
            catch(Exception e)
            {
                return (false, e, null);
            }
        }

        public async Task<(bool IsSuccess, Exception Exception)> InsertUserAsync(User user)
        {
            try
            {
                await _ctx.Users.AddAsync(user);
                await _ctx.SaveChangesAsync();
                return (true, null);
            }
            catch(Exception e)
            {
                return (false, e);
            }
        }
    }
}
