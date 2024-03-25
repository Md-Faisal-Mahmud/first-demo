using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class CustomerDto
    {
        public Guid Id { get;  set; }
        public string CustomerName { get;  set; }
        public string CustomerEmail { get;  set; }
        public string PhoneNumber { get;  set; }
        public string Address { get;  set; }
        public decimal OpBalance { get;  set; }
        public decimal Limit { get;  set; }
        public string Image { get;  set; }
    }
}
