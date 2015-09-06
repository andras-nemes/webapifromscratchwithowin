using CustomersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CustomersApi.Service
{
	public class CustomerService : ICustomerService
	{
		private readonly ICustomerRepository _customerRepository;

		public CustomerService(ICustomerRepository customerRepository)
		{
			if (customerRepository == null) throw new ArgumentNullException("Customer repository!");
			_customerRepository = customerRepository;
		}

		public async Task<GetCustomersResponse> GetCustomersAsync()
		{
			return await Task<GetCustomersResponse>.Run(() => GetCustomers());
		}

		private GetCustomersResponse GetCustomers()
		{
			GetCustomersResponse response = new GetCustomersResponse();
			try
			{
				IEnumerable<Customer> customers = _customerRepository.FindAll();
				response.Customers = customers;
				response.Success = true;
			}
			catch (Exception ex)
			{
				response.Success = false;
				response.OperationException = ex;
			}
			return response;
		}
	}
}