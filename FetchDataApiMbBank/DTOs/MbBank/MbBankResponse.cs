using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.MbBank
{
    public class MbBankResponse
    {
        public string? Code { get; set; }
        public object Result { get; set; } = null!;
    }
}
