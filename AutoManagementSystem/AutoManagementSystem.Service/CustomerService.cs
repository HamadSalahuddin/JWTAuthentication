using AutoManagementSystem.Data.Infrastructure;
using AutoManagementSystem.Data.Repositories;
using AutoManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Service
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomersByFirstName(string firstName);
        IEnumerable<Customer> GetCustomersByLastName(string lastName);
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void SaveCustomer();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork
        )
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            customerRepository.Delete(customer);
        }

        public Customer GetCustomer(int id)
         => customerRepository.GetById(id);

        public IEnumerable<Customer> GetCustomers()
            => customerRepository.GetAll();
        

        public IEnumerable<Customer> GetCustomersByFirstName(string firstName)
        {
            if(string.IsNullOrWhiteSpace(firstName))
            {
                // throw data validation exception
                return new List<Customer>();
            }
            return customerRepository.GetCustomersByFirstName(firstName);
        }

        public IEnumerable<Customer> GetCustomersByLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                // throw data validation exception
                return new List<Customer>();
            }
            return customerRepository.GetCustomersByFirstName(lastName);
        }

        public void SaveCustomer()
        {
            unitOfWork.Commit();
        }

        public void UpdateCustomer(Customer customer)
        {
            customerRepository.Update(customer);
        }
    }
}
