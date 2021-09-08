using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Account
    {
        public string Account_Number { get; set; }
        public int Balance { get; set; }
        public User AccountHolder { get; set; }
    }
}
