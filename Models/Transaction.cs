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
        public int UserId { get; set; }  // Link transaction to a user
        public string Type { get; set; } // "Credit", "Debit", or "Debt"
        public decimal Amount { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public DateTime Date { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string Notes { get; set; }

    }

}

