// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5
{
    abstract class Payment
    {
        private double amount; //amount of this payment
        string paymentDate; //date of this payment
        public Payment(double amount, string paymentDate)
        {
            this.amount = amount;
            this.paymentDate = paymentDate;
        }

        public double getAmount()
        {
            return this.amount;
        }
        public string getPaymentDate()
        {
            return this.paymentDate;
        }
        public virtual bool verify()
        {
            Console.WriteLine("Payment Verified");
            return true;
        }
        public abstract string getPaymentType();
    }
}