using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseApp.Entities
{
    class Expense
    {
        public int expenseId { get; set; }
        public string amount { get; set; }
        public string carryFwdAmount  { get; set; }
        public string  createdDate{ get; set; }
        public byte isActive { get; set; }
    }
}
