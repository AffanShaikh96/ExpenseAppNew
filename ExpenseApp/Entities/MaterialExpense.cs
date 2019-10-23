using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseApp.Entities
{
    class MaterialExpense
    {
        public int materialExpID { get; set; }
        public string materialName { get; set; }
        public string materialCode { get; set; }
        public string materialSize { get; set; }
        public List<MaterialExpenseDetails> materialExpenseDetails { get; set; }
        public byte isActive { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
    }
}
