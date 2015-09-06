using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApi.Service
{
	public interface ICustomerService
	{
		Task<GetCustomersResponse> GetCustomersAsync();
	}
}
