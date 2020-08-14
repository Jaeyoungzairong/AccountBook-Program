using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AccountBookProgram
{
    public class AccountData
    {
        public readonly static AccountData Instance = new AccountData();

        public AccountData()
        {

        }

        public string BackName { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string Capital { get; set; }
        public string Country { get; set; }
        public string Date { get; set; }
        public string Expense { get; set; }
        public string HouseRent { get; set; }
    }
}
