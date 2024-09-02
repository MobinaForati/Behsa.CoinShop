using Behsa.CoinShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.Context;

public partial class ApplicationUnitOfWork
{
    public DbSet<User> Users => _context.Set<User>();
}