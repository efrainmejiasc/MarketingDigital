using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.Response
{
    public class SBRecoverFolder
    {
        public int count { get; set; }
        public List<Folders> folders { get; set; }
        public class Folders
        {
            public int id { get; set; }
            public string name { get; set; }
            public int totalBlacklisted { get; set; }
            public int totalSubscribers { get; set; }
            public int uniqueSubscribers { get; set; }
        }
    }
}
