using System;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace tiqe_web.Models
{
    public class TiqeDbContext : DbContext
	{
		//criar uma classe dessa para cada tabela. deixar essa aqui para que seja herdada.
        public DbSet<User> Users { get; set; }
        public DbSet<UserNewsletter> UserNewsletters { get; set; }
        //colocar as demais tabelas aqui
		
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(m => m.TiqeUserId);
            builder.Entity<UserNewsletter>().HasKey(m => m.UserNewsletterId);
            //colocar as demais tabelas aqui
            
            //entender melhor como funciona essa parte
            builder.Entity<User>().Property<DateTime>("UpdatedTimestamp");
            builder.Entity<UserNewsletter>().Property<DateTime>("UpdatedTimestamp");
            //colocar as demais tabelas aqui
            
            base.OnModelCreating(builder);
        }
        
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
            .AddJsonFile("../config.json")
            .AddEnvironmentVariables();
            
            var configuration = builder.Build();
            
            var sqlConnectionString = configuration["Data:DataAccessPostgreSqlProvider:ConnectionString"];
            
            optionsBuilder.UseNpgsql(sqlConnectionString);
		}
        
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            
            updateUpdatedProperty<User>();
            updateUpdatedProperty<UserNewsletter>();
            //colocar as demais tabelas aqui
            
            return base.SaveChanges();
        }
        
        private void updateUpdatedProperty<T>() where T : class
        {
            //ver direito como isso funciona. 
            var modifiedUser = ChangeTracker.Entries<T>()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            
            foreach (var entry in modifiedUser)
            {
                //aqui ele atualizaria todas as datas?? não quero assim. ver com funciona
                entry.Property("UpdatedTimestamp").CurrentValue = DateTime.UtcNow;
            }
        }
	}
}