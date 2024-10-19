using Microsoft.EntityFrameworkCore;
using WiseBot.Domain.Entities.Models;

namespace WiseBot.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
