using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseApp.Entities
{
    class PeopleExpense
    {
        public int peopleExpID { get; set; }
        public string peopleName { get; set; }
        public string peopleCode { get; set; }
        public string peopleContact { get; set; }
        public List<PeopleExpenseDetails> peopleExpenseDetails { get; set; }
        public byte isActive { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
    }
}
