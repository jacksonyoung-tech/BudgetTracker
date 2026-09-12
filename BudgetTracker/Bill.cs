using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker
{
    public class Bill
    {
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; } 
    }
}
