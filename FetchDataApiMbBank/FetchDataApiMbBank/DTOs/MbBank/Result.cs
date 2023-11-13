using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.MbBank
{
    public class Result
    {
        public string? responseCode { get; set; }
        public string? message { get; set; }
        public bool ok { get; set; }
    }
}
