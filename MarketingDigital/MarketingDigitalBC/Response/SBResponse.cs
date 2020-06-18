using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.Response
{
    public class SBResponse
    {
        public int id { get; set; }
        public string messageId { get; set; }
        public bool exception { get; set; }
        public string messageError { get; set; }
    }
}
