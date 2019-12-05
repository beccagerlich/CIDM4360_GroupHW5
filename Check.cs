// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    class Check : Payment
    {
        string Bank; // bank name
        string custName; // customer/client name
        string accNum; // account number
        public Check(double amount, string Bank, string custName, string accNum, string paymentDate):base(amount, paymentDate)
        {
            this.Bank = Bank;
            this.custName = custName;
            this.accNum = accNum;
        }
        public override bool verify()
        {
            Console.WriteLine("Signature and Account Balance Verified");
            return true;
        }
        public override string getPaymentType()
        {
            return "Check";
        }
    }
}
