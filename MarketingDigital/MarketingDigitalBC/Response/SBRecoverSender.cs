using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.Response
{
    public class SBRecoverSender
    {
        public int count { get; set; }
        public List<Sender> senders { get; set; }
        public class Sender
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email{ get; set; }
            public bool active { get; set; }
        }
    }
}
