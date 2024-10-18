using Biomachine.DAL.Contexts;
using Biomachine.DAL.Repositiories;
using Biomachine.Domain.Entities;

namespace Biomachine.DAL.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    public readonly AppDbContext context;

    public IRepository<User> Users { get; }
    public IRepository<Product> Products { get; }

    public UnitOfWork(AppDbContext context)
    {
        this.context = context;

        Users = new Repository<User>(context);
        Products = new Repository<Product>(context);
    }
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public async ValueTask<bool> SaveAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }
}
