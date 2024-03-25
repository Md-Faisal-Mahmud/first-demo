using AsyncKeyedLock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace TodoApp.Customers
{
    public class Customer : BasicAggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerEmail { get; private set; }
        public string PhoneNumber { get; private set;}
        public string Address { get; private set;}
        public decimal OpBalance { get; private set;}
        public decimal Limit { get; private set;}
        public string Image {  get; private set;}
    }
}