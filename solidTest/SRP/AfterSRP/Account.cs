using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidTest.SRP.AfterSRP
{
    internal class Account
    {
        //every class make one job
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string email, decimal balance)
        {
            Name = name;
            Email = email;
            Balance = balance;
        }
    }
}
