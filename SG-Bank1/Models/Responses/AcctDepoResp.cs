using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Responses
{
    public class AcctDepoResp : Response
    {
        public Account Acct { get; set; }
        public decimal Amt { get; set; }
        public decimal OldBal { get; set; }
    }
}
