using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Responses;

namespace Models.Interfaces
{
    public interface IDeposit
    {
        AcctDepoResp Deposit(Account acct, decimal amt);
    }
}
