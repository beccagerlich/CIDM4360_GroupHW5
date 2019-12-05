// CIDM4360: Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework5 {
    class Bill {
        string billDate;
        string description;
        double amount; //bill total amount
        List<Payment> ListofPayments = new List<Payment> (); //HAS-A relationship aggregation 

        public Bill (string billDate, string description, double amount) {
            this.billDate = billDate;
            this.description = description;
            this.amount = amount;

        }

        public string getBillInfo() {
           string info = $"Date: {billDate}\nDescription: {description}\nAmount Due: {(amount.ToString("C0"))}";
           foreach(var p in ListofPayments) {
                info+=$"\nOn {p.getPaymentDate()} payment with {p.getPaymentType()} the amount {p.getAmount().ToString("C0")} was processed";
            }
           info+=$"\nTotal payed: {getAmountPayed()}\nRemaining Balance: {getBalance()}";
           return info;
        
        }
        public double getBalance () {
            double Total = 0;
            foreach (var a in ListofPayments) {
                Total = Total + a.getAmount ();
            }
            return amount - getAmountPayed ();
        }
        public double getAmountPayed () {
            double Total = 0;
            foreach (var a in ListofPayments) {
                Total = Total + a.getAmount ();
            }
            return Total;
        }

        public bool addPayment (Payment p) {
            if (p.verify () == true) {
                ListofPayments.Add (p);
                return true;
            }
            return false;
        }

    }
}