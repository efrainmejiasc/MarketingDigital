using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.Models
{
    public class UpdateContactModel
    {
        public string email { get; set; }

        public Attributes attributes { get; set; }

        public List<int> listIds { get; set; }

        public List<int> unlinkListIds { get; set; }

        public List<string> smtpBlacklistSender { get; set; }

        public bool emailBlacklisted { get; set; }

        public bool smsBlacklisted { get; set; }

        public class Attributes
        {
            public string NOMBRE { get; set; }

            public string SURNAME { get; set; }

            public string SMS { get; set; }

            public string Email { get; set; }
        }
    }
}

