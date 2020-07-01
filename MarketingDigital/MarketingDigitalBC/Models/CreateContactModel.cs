using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.Models
{
    public class CreateContactModel
    {
        public string email { get; set; }

        public bool updateEnabled { get; set; } // Actualiza o no el contacto si existe , por defecto false

        public Attributes attributes { get; set; }

        public List<int> listIds { get; set; } // Id's de las lista para agregar el contacto

        public class Attributes
        {
            public string NOMBRE { get; set; }

            public string SURNAME { get; set; }

            public string SMS { get; set; }
        }
    }
}
