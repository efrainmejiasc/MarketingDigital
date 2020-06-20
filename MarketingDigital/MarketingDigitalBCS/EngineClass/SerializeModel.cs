using MarketingDigitalBCS.EngineClass.Interfaces;
using MarketingDigitalBCS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.EngineClass
{
    public class SerializeModel : ISerializeModel
    {
        public string  SerializeCreateNewSender (string nombre, string email)
        {
            var model = new CreateSenderModel()
            {
                name = nombre,
                email = email
            };
            return JsonConvert.SerializeObject(model);
        }

        public string SerializeCreateNewFolder(string nombreCarpeta)
        {
            var model = new CreateFolderModel()
            {
               name = nombreCarpeta
            };
            return JsonConvert.SerializeObject(model);
        }

        public string SerializeCreateNewListContact(string nombreLista , int idCarpeta)
        {
            var model = new CreateListModel()
            {
                name = nombreLista,
                folderId = idCarpeta
            };
            return JsonConvert.SerializeObject(model);
        }
    }
}
