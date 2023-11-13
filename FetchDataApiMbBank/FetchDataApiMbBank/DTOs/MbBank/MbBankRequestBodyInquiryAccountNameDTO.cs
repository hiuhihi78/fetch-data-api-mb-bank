using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.MbBank
{
    public class MbBankRequestBodyInquiryAccountNameDTO
    {
        public string? bankCode { get; set; }
        public string? creditAccount { get; set; }
        public string? creditAccountType { get; set; }
        public string? debitAccount { get; set; }
        public string? deviceIdCommon { get; set; }
        public string? refNo { get; set; }
        public string? remark { get; set; }
        public string? sessionId { get; set; }
        public string? type { get; set; }
    }
}
