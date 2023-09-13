using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor_Partiall
{
    public partial class BankAccount
    {
        public string AccountSwift { get; } = "IBAZA";
        public const string DefaultCode = "DATA12";
    }
}
