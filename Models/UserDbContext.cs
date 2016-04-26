using Microsoft.Data.Entity;

namespace tiqe_web.Models
{
    //criar uma classe dessa para cada tabela
	public class UserDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		
		//protected override void OnConfiguring(DbContextOptions options)
		//{
			
		//}
	}
}