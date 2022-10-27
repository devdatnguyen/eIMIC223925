using eIMIC2325.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
     public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ExternalTransactionId { get; set; }
        public int Amount { get; set; }
        public double Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public TransactionStatus Status { get; set; }
        public string Provider { get; set; }
    }
}
