using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Responses;

namespace Models.Interfaces
{
   public interface IWithdraw
   {
       AcctWithdrawResp Withdraw(Account acct, decimal amt);
   }
}
