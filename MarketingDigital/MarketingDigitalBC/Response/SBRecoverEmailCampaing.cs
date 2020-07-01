using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.Response
{
    public class SBRecoverEmailCampaing
    {
        public int count { get; set; }

        public List<Campaigns> campaigns { get; set; }
        public class Campaigns
        {
            public int id { get; set; }
            public string name { get; set; }
            public string tag { get; set; }
            public string subject { get; set; }
        }
    }
}
