using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Users_big_Task.Request
{
    public class CompanyRequest
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public bool Status { get; set; }
    }
}
