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

        public Customer GetCustomerByEmail(string emailAddress)
            =>
             DbContext.Customers
                .Single(customer => customer.EmailAddress == emailAddress);
    }

    public interface ICustomerRepository: IRepository<Customer>
    {
        Customer GetCustomerByEmail(string emailAdd);
    }
}
