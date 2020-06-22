using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.Models
{
    public class CreateEmailCampanaModel
    {
        public string tag { get; set; } 

        public Sender sender { get; set; }

        public string name { get; set; } 

        public string htmlContent { get; set; } 

        public string subject { get; set; } 

        public bool inlineImageActivation { get; set; } 

        public bool sendAtBestTime { get => false; }

        public bool abTesting { get => false; }


        public class Sender
        {
            public string name { get; set; } 
            public string email { get; set; } 
        }
    }
}
