using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Customers;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TodoApp
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerService(IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDto> CreateAsync(CustomerDto customerDto)
        {
            var customer = await _customerRepository.InsertAsync(
                new Customer
                {
                    CustomerName = customerDto.CustomerName,
                    CustomerEmail = customerDto.CustomerEmail,
                    PhoneNumber = customerDto.PhoneNumber,
                    Address = customerDto.Address,
                    OpBalance = customerDto.OpBalance,
                    Limit = customerDto.Limit,
                    Image = customerDto.Image,
                });

            return new CustomerDto()
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,
                CustomerEmail = customer.CustomerEmail,
                PhoneNumber = customer.PhoneNumber,
                Address = customer.Address,
                OpBalance = customer.OpBalance,
                Limit = customer.Limit,
                Image = customer.Image,
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            var items = await _customerRepository.GetListAsync();
            return items
                .Select(item => new CustomerDto()
                {
                    Id = item.Id,
                    CustomerName = item.CustomerName,
                    CustomerEmail = item.CustomerEmail,
                    PhoneNumber = item.PhoneNumber,
                    Address = item.Address,
                    OpBalance = item.OpBalance,
                    Limit = item.Limit,
                    Image = item.Image,
                }).ToList();
        }
    }
}
