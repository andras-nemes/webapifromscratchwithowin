using CustomersApi.Model;
using CustomersApi.Repository;
using CustomersApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace CustomersApi.Controllers
{
	public class CustomersController : ApiController
	{
		private readonly ICustomerService _customerService;

		public CustomersController(ICustomerService customerService)
		{
			if (customerService == null) throw new ArgumentNullException("ICustomerService");
			_customerService = customerService;
		}

		public async Task<IHttpActionResult> Get()
		{
			GetCustomersResponse response = await _customerService.GetCustomersAsync();
			if (response.Success)
			{
				return Ok<IEnumerable<Customer>>(response.Customers);
			}

			return InternalServerError(response.OperationException);
			
		}
	}
}
