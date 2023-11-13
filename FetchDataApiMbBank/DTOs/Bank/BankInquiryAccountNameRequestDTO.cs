using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Bank
{
    public class BankInquiryAccountNameRequestDTO
    {
        public string BankId { get; set; } = null!;
        public string CreditAccount { get; set; } = null!;
    }
}
