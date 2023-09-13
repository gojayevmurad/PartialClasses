using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor_Partiall
{
    public partial class BankAccount
    {
        int Id { get; set; }
        public string? AccountName { get; set; }
        partial void ShowAccount();
        partial void UpdateAccount();
    }
}
