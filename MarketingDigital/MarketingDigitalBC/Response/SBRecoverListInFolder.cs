using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.Response
{
    public class SBRecoverListInFolder
    {
        public int count { get; set; }
        public List<Lists> lists {get;set; }

        public class Lists
        {
            public int id { get; set; }
            public string name { get; set; }
            public int totalSubscribers { get; set; }
            public int totalBlacklisted { get; set; }
        }
    }
}
