using Microsoft.Data.Entity;

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