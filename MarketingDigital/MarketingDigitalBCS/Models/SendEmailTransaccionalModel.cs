using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.Models
{
    public class SendEmailTransaccionalModel
    {
        public Sender sender { get; set; }
        public List<To> to { get; set; }
        public string htmlContent { get; set; }
        public string subject { get; set; }
        public class Sender
        {
            public string name { get; set; }
            public string email { get; set; }

        }
        public class To
        {
            public string email { get; set; }
            public string name { get; set; }
        }
    }
}
