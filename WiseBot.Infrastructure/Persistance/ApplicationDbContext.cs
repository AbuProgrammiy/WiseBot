using Microsoft.EntityFrameworkCore;
using WiseBot.Application.Abstractions;
using WiseBot.Domain.Entities.Models;

namespace WiseBot.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }
    }
}
