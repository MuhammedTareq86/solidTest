using System;
using System.Diagnostics.Metrics;


namespace solidTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            //TestWithoutSRP();
            //TestWithSRP(); 
            #endregion
            #region OCP

            //TestOcp();
            #endregion
            #region LSP
            //TestLsp();
            #endregion
            #region ISP
            TestIcp();
            #endregion

            Console.ReadKey();
        }
        #region SRPTest
        private static void TestWithoutSRP()
        {
            var account =
                new SRP.BeforeSRP.Account("Reem", "reem@example.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }
        private static void TestWithSRP()
        {
            var account =
                new SRP.AfterSRP.Account("Reem", "reem@example.com", 10000m);

            var accountService = new SRP.AfterSRP.AccountService();
            accountService.Deposit(account, 500);
            accountService.WithDraw(account, 11000);
        }
        #endregion
        #region testOCP
        private static void TestOcp()
        {
            var quiz =
                new SOLID.OCP.After.Quiz(SOLID.OCP.After.QuestionBank.Generate());
            quiz.Print();

        }
        #endregion
        #region TestLSP
        private static void TestLsp()
        {
            //var account = new SOLID.LSP.Before.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000);

            var account = new SOLID.LSP.After.CheckingAccount("Issam", 10_000);
            account.Withdraw(5000m);
            Console.WriteLine("success");

            //var account = new After.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000); // won't work

        }
        #endregion
        #region TestISp
        private static void TestIcp()
        {
            var employees = SOLID.ISP.After.Repository.LoadEmployees();

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
        }

        #endregion
    }
}