using ConsoleApp_datalagring.Entities;
using ConsoleApp_datalagring.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Services
{
    internal class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        private readonly AdressService _adressService;
        private readonly RoleService _roleService;

        public CustomerService(CustomerRepository customerRepository, AdressService adressService, RoleService roleService)
        {
            _customerRepository = customerRepository;
            _adressService = adressService;
            _roleService = roleService;
        }
        public CustomerEntity CreateCustomer(string firstName, string lastName, string email, string roleName, string streetName, string postalCode, string city)
        {
            var roleEntity = _roleService.CreateRole(roleName);
            var addressEntity = _adressService.CreateAdress(streetName, postalCode, city);

            var customerEntity = new CustomerEntity
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                RoleId = roleEntity.Id,
                AdressId = addressEntity.Id
            };

            customerEntity = _customerRepository.Create(customerEntity);

            return customerEntity;
        }




        public CustomerEntity GetCustomerByEmail(string email)
        {
            var customerEntity = _customerRepository.Get(x => x.Email == email);
            return customerEntity;
        }


        public CustomerEntity GetCustomerById(int id)
        {
            var customerEntity = _customerRepository.Get(x => x.Id == id);
            return customerEntity;
        }

        public IEnumerable<CustomerEntity> GetCustomers()
        {
            var customers = _customerRepository.GetAll();
            return customers;
        }

        public CustomerEntity UpdateCustomer(CustomerEntity customerEntity)
        {
            var updatedCustomerEntity = _customerRepository.Update(x => x.Id == customerEntity.Id, customerEntity);
            return updatedCustomerEntity;
        }


        public void DeleteCustomer(int id)
        {
            _customerRepository.Delete(x => x.Id == id);
        }
    }
}
