using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Users_big_Task.Model
{
    public class Users
    {
        public int Id { get; set; }
        public Guid GUId { get; set; }
        public bool Status { get; set; }
        public int LanguageId { get; set; }
        public int CountryId { get; set; }
    }
}
