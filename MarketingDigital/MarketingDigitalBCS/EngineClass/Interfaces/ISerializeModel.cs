using MarketingDigitalBCS.Models;
using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface ISerializeModel
    {
        string SerializeEmailTo(List<string> email);
        string SerializeCreateNewFolder(string nombreCarpeta);
        string SerializeCreateNewSender(string nombre, string email);
        string SerializeCreateNewListContact(string nombreLista, int idCarpeta);
        string SerializerDataUpdateContact(SBResponseAllContacts.Contacts contacto);
        string SerializerDataNewEmailCampaing(string tag, string nameSender, string emailSender, string nameCampaing, string htmlCode, string subject);
    }
}
