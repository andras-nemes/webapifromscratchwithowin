using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomersApi.Model;

namespace CustomersApi.Service
{
	public class GetCustomersResponse
	{
		public IEnumerable<Customer> Customers { get; set; }
		public bool Success { get; set; }
		public Exception OperationException { get; set; }
	}
}