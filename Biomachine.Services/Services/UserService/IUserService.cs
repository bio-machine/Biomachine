using Biomachine.Domain.Entities;

namespace Biomachine.Services.Services.UserService;

public interface IUserService
{
    public ValueTask<User> CreateAsync(User user);
    public ValueTask<User> UpdateAsync(long id, User user);
    public ValueTask<User> DeleteAsync(long id);
    public ValueTask<User> GetAsync(long id);
    public ValueTask<User> GetAllAsync();
}
