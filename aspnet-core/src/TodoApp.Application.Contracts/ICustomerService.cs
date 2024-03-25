using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TodoApp
{
    public interface ICustomerService : IApplicationService
    {
        Task<List<CustomerDto>> GetListAsync();
        Task<CustomerDto> CreateAsync(CustomerDto customerDto);
        Task DeleteAsync(Guid id);
    }
}
