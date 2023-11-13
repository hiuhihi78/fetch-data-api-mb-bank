using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.MbBank
{
    public class MbBankResponeHistoryTransactionDataDTO
    {
        public string? refNo { get; set; }
        public Result result { get; set; } = null!;
        public List<TransactionHistory>? transactionHistoryList { get; set; }
    }
}
