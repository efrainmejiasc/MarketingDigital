using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.Response
{
    public class SBResponseAllContacts
    {
        public List<Contacts> contacts { get; set; }
        public int count { get; set; }
        public class Attributes
        {
            public string NOMBRE { get; set; }
            public string SURNAME { get; set; }
            public string SMS { get; set; }

        }
        public class Contacts
        {
            public string email { get; set; }
            public int id { get; set; }
            public bool emailBlacklisted { get; set; }
            public bool smsBlacklisted { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime modifiedAt { get; set; }
            public List<int> listIds { get; set; }
            public Attributes attributes { get; set; }

        }
    }
}
