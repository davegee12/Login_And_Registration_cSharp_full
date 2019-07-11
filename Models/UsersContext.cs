using LogAndRegCSHARPfull.Models;
using Microsoft.EntityFrameworkCore;

namespace LogAndRegCSHARPfull
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options) : base(options) {}

        public DbSet<RegUser> Users {get;set;}
    }
}