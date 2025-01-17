using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project_MAUI.Components.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public DateTime Date { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string Notes { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; } = "";
        public string Title { get; set; }
        public bool IsDebt { get; internal set; }
    }

    public class MonthlyAnalysis
    {
        public DateTime Month { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal TotalDebit { get; set; }
        public decimal TotalDebt { get; set; }
        public decimal AverageTransactionAmount { get; set; }
        public int TransactionCount { get; set; }
    }

    public class DebtAnalysis
    {
        public string Source { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public DateTime NextDueDate { get; set; }
    }
}

