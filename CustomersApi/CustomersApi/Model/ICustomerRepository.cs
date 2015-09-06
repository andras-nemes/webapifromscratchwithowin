using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApi.Model
{
	public interface ICustomerRepository
	{
		IEnumerable<Customer> FindAll();
	}
}
