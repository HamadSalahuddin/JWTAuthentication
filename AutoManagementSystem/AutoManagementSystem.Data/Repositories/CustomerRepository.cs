using AutoManagementSystem.Data.Infrastructure;
using AutoManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data.Repositories
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory): base(dbFactory)
        {
        }

        public List<Customer> GetCustomersByFirstName(string firstName)
            =>
             DbContext.Customers
                .Where(customer => customer.FirstName.ToLower() == firstName.ToLower())
                .ToList();

        public List<Customer> GetCustomersByLastName(string lastName)
            =>
             DbContext.Customers
                .Where(customer => customer.LastName.ToLower() == lastName.ToLower())
                .ToList();
    }

    public interface ICustomerRepository: IRepository<Customer>
    {
        List<Customer> GetCustomersByFirstName(string firstName);
        List<Customer> GetCustomersByLastName(string firstName);
    }
}
