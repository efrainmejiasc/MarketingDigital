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

        public string SerializerDataNewContact(string email, string name, string surname, string phoneNumber, int idList, bool updateEnable) 
        {
            var dataContact = new CreateContactModel()
            {
                email = email,
                updateEnabled = updateEnable,
                attributes = new CreateContactModel.Attributes()
                {
                    NOMBRE = name,
                    SURNAME = surname,
                    SMS = phoneNumber
                },
                listIds = new List<int>()
                {
                   idList
                }
            };
            return JsonConvert.SerializeObject(dataContact);
        }

        public string SerializerDataAddContact(string email) 
        {
            var dataContact = new AddContactModel();
            string resultado = string.Empty;
            dataContact.emails = new List<string>();
            dataContact.emails.Add(email.Replace("400", ""));
            return  JsonConvert.SerializeObject(dataContact);
        }

        public string SerializerDataNewEmailCampaing(string tag, string nameSender, string emailSender, string nameCampaing, string htmlCode, string subject)  
        {
            var dataCampaing = new CreateEmailCampanaModel()
            {
                tag = tag,
                sender = new CreateEmailCampanaModel.Sender()
                {
                    name = nameSender,
                    email = emailSender
                },
                name = nameCampaing,
                htmlContent = htmlCode,
                subject = subject,
                inlineImageActivation = true,
            };
            return  JsonConvert.SerializeObject(dataCampaing);
        }
    }
}
