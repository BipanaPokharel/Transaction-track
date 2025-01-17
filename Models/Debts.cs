﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAUI.Components.Model
        
{

    public class Debt

    {

        public int Id { get; set; }

        public int UserId { get; set; }  // Make sure this property exists

        public string Source { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public DateTime? DueDate { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal RemainingAmount { get; set; }
        public string PaymentMethod { get; set; }

        public string Status { get; set; }

        public List<string> Tags { get; set; } = new List<string>();

        public string Notes { get; set; }

    }

}
