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
        public Guid Id { get;  set; }
        public string CustomerName { get;  set; }
        public string CustomerEmail { get;  set; }
        public string PhoneNumber { get;  set;}
        public string Address { get;  set;}
        public decimal OpBalance { get;  set;}
        public decimal Limit { get;  set;}
        public string Image {  get;  set;}
    }
}