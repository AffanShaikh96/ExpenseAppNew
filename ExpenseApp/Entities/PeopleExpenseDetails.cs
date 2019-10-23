using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseApp.Entities
{
    class PeopleExpenseDetails
    {
        public int peopleExpenseDetailId { get; set; }
        public PeopleExpense peopleExpense { get; set; }
        public string peopleExpenseDesc { get; set; }
        public string peopleExpenseAmount { get; set; }
        public string peopleExpenseQuantity { get; set; }
        public byte isActive { get; set; }
        public string createdDate { get; set; }
        public string createdBy { get; set; }
    }
}
