using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstPro.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}
