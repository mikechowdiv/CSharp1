using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Interfaces;

namespace Data.Repo
{
    public class AcctRepo : IAcctRepo
    {
        List<Account> acctList = new List<Account>();

        private void LoadData()
        {
            using (StreamReader sr = new StreamReader(Setting.Path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Account acct = new Account();
                    string[] cols = line.Split(',');
                    acct.AcctNum = cols[0];
                    acct.Name = cols[1];
                    acct.Balance = decimal.Parse(cols[2]);
                    switch (cols[3])
                    {
                        case "F":
                            acct.Type = AcctType.Free;
                            break;
                        case "B":
                            acct.Type = AcctType.Basic;
                            break;
                        case "P":
                            acct.Type = AcctType.Premium;
                            break;
                    }
                    acctList.Add(acct);
                }
            }
        }


        public Account LoadAcct(string AcctNum)
        {
            throw new NotImplementedException();
        }

        public void SaveAcct(Account acct)
        {
            throw new NotImplementedException();
        }
    }
}
