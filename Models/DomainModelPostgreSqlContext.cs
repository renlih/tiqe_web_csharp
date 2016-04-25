//apagar essa classe aqui depois. apagar tb a pasta DomainModel
using System;
using System.Linq;
using DomainModel.Model;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace tiqe_web.Models
{
	// dnx . ef migrations add testMigration
	public class DomainModelPostgreSqlContext : DbContext
	{
		public DbSet<DataEventRecord> DataEventRecords {get; set;}
		
		public DbSet<SourceInfo> SourceInfos {get; set;}
		
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<DataEventRecord>().HasKey(m => m.DataEventRecordId);
			builder.Entity<SourceInfo>().HasKey(m => m.SourceInfoId);
			
			builder.Entity<DataEventRecord>().Property<DateTime>("UpdatedTimestamp");
			builder.Entity<SourceInfo>().Property<DateTime>("UpdatedTimestamp");
			
			base.OnModelCreating(builder);	
		}
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
			.AddJsonFile("../config.json")
			.AddEnvironmentVariables();
			var configuration = builder.Build();
			
			var sqlConnectionString = configuration["DataAccessPostgreSqlProvider:ConnectionString"];
			
			optionsBuilder.UseNpgsql(sqlConnectionString);
		}
		
		public override int SaveChanges()
		{
			ChangeTracker.DetectChanges();
			
			updateUpdatedProperty<SourceInfo>();
			updateUpdatedProperty<DataEventRecord>();
			
			return base.SaveChanges();
		}
		
		private void updateUpdatedProperty<T>() where T : class
		{
			var modifiedSourceInfo = ChangeTracker.Entries<T>()
			.Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
			
			foreach (var entry in modifiedSourceInfo)
			{
				entry.Property("UpdatedTimestamp").CurrentValue = DateTime.UtcNow;
			}
		}
	}
	
	
	/*public class MyDbConfiguration : DbConfiguration
	{
		public MyDbConfiguration()
		{
			var dataSet = ConfigurationManager.GetSection("system.data") as DataSet;
			dataSet.Tables[0].Rows.Add(
				"MySql Data Provider",
				".Net Framework Data Provider for MySQL",
				"MySql.Data.MySqlClient",
				typeof(MySqlClientFactory).AssemblyQualifiedName
			);
			
			SetProviderServices("MySql.Data.MySqlClient", new MySqlProviderServices());
			SetDefaultConnectionFactory(new MySqlConnectionFactory());
		}
	}*/
}
