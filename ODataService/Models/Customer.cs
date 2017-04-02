using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
	[Table("Customer")]
	public class Customer
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime Created { get; set; }
	}
}