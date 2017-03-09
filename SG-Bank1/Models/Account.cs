using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        public string Name { get; set; }
        public string AcctNum { get; set; }
        public decimal Balance { get; set; }
        public AcctType Type { get; set; }
    }
}
