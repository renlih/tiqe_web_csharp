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
        public DbSet<UserNewsletter> UsersNewsletter { get; set; }
        //colocar as demais tabelas aqui
		
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<User>().HasKey(m => m.TiqeUserId);
            builder.Entity<UserNewsletter>().HasKey(m => m.UserNewsletterId);
            
            //Users
            //builder.Entity<User>().HasKey(m => m.TiqeUserId);
            /*builder.Entity<User>()
                .Property(t => t.Picture)
                .HasMaxLength(300);
            builder.Entity<User>()
                .Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Entity<User>()
                .Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Entity<User>()
                .Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Entity<User>()
                .Property(t => t.Pass)
                .IsRequired()
                .HasMaxLength(20);
            builder.Entity<User>()
                .Property(t => t.Birthday)
                .IsConcurrencyToken();
            builder.Entity<User>()
                .Property(t => t.UseTerms)
                .IsRequired();
            builder.Entity<User>()
                .Property(t => t.Status)
                .IsRequired();
            builder.Entity<User>()
                .Property(t => t.FirstLogin)
                .IsRequired();
            builder.Entity<User>()
                .Property(t => t.Language)
                .IsRequired()
                .HasMaxLength(5);
            builder.Entity<User>()
                .Property(t => t.SendLogError)
                .IsRequired();
            builder.Entity<User>()
                .Property(t => t.RegisterDate)
                .IsRequired()
                .IsConcurrencyToken();
            builder.Entity<User>()
                .Property(t => t.ModifyDate)
                .IsRequired()
                .IsConcurrencyToken();   */

            //UserNewsletter
            //builder.Entity<UserNewsletter>().HasKey(m => m.UserNewsletterId);
            /*builder.Entity<UserNewsletter>()
                .Property(t => t.TiqeUserId)
                .IsRequired();
            builder.Entity<UserNewsletter>()
                .Property(t => t.Receiver)
                .IsRequired();
            builder.Entity<UserNewsletter>()
                .Property(t => t.ReceiverRegisterDate)
                .IsRequired()
                .IsConcurrencyToken();
            builder.Entity<UserNewsletter>()
                .Property(t => t.ModifyDate)
                .IsRequired()
                .IsConcurrencyToken();*/
            
            //entender melhor como funciona essa parte
            //builder.Entity<User>();
            //builder.Entity<UserNewsletter>();
            
            //builder.Entity<User>().ToTable("TB_User");
            //builder.Entity<User>().HasKey(t => t.TiqeUserId);
            //builder.Entity<User>().Property(t => t.TiqeUserId); //continuar
            //colocar as demais tabelas aqui
                        
            //entender melhor como funciona essa parte
            //builder.Entity<User>().Property<DateTime>("UpdatedTimestamp");
            //builder.Entity<UserNewsletter>().Property<DateTime>("UpdatedTimestamp");
            //colocar as demais tabelas aqui
            
            base.OnModelCreating(builder);
        }
        
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
            .AddJsonFile("config.json")
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