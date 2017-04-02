using System.Data.Entity;
using System.Diagnostics;

namespace ODataService.Models
{
	public class Context : DbContext
	{
		public Context()
			: base("DefaultConnection")
		{
			Database.Log = s => Debug.WriteLine(s);
		}

		public virtual IDbSet<Customer> Customers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<Context>(null);
			base.OnModelCreating(modelBuilder);
		}
	}
}