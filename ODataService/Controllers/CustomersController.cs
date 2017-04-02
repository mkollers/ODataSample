using ODataService.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using System.Web.Http.OData;
using System.Linq;

namespace ODataService.Controllers
{
	[Route("api/customers")]
	public class CustomersController : ApiController
	{
		private Context _context = new Context();

		// GET: api/Customers
		[EnableQuery]
		public IHttpActionResult Get()
		{
				var result = (from c in _context.Customers
											select c);

				return Ok(result);
		}

		// GET: api/Customers/5
		public string Get(int id)
		{
			return "value";
		}

		// POST: api/Customers
		public void Post([FromBody]string value)
		{
		}

		// PUT: api/Customers/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE: api/Customers/5
		public void Delete(int id)
		{
		}
	}
}
