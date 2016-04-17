using System.Configuration;
using System.Data;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace tiqe_web.Models
{
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
