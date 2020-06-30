using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.Models
{
    public class UpdateContactModel
    {
        public string email { get; set; }

        public Attributes attributes { get; set; }

        public List<int> listIds { get; set; } // Id's de las lista para agregar el contacto

        public class Attributes
        {
            public string NOMBRE { get; set; }

            public string SURNAME { get; set; }

            public string SMS { get; set; }

            public string Email { get; set; }
        }
    }
}

