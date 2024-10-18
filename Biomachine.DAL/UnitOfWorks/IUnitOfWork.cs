using Biomachine.DAL.Repositiories;
using Biomachine.Domain.Entities;

namespace Biomachine.DAL.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> Users { get; }
    IRepository<Product> Products { get; }

    ValueTask<bool> SaveAsync();
}
