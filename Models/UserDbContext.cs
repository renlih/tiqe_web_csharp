using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;

namespace tiqe_web.Models
{
    public class UserDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		
		//protected override void OnConfiguring(DbContextOptions options)
		//{
			
		//}
	}
}