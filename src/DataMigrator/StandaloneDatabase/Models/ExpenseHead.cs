using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class ExpenseHead
    {
        public ExpenseHead()
        {
            Expense = new HashSet<Expense>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public bool IsOneTimeEntry { get; set; }
        public string BranchId { get; set; }
        public int HeadType { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<Expense> Expense { get; set; }
    }
}
