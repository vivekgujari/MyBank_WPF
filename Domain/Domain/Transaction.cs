using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Transaction : DomainObject
    {
        public int Amount { get; set; }
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
    }
}
