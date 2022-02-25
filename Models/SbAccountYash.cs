using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class SbAccountYash
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
