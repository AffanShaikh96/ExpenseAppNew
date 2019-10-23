using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseApp.Entities
{
    class MaterialExpenseDetails
    {
        public int materialExpenseDetailId { get; set; }
        public MaterialExpense materialExpense { get; set; }
        public string materialExpenseDesc { get; set; }
        public string materialExpenseAmount { get; set; }
        public string materialExpenseQuantity { get; set; }
        public byte isActive { get; set; }
        public string createdDate { get; set; }
        public string createdBy { get; set; }
    }
}
