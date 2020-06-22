﻿using MarketingDigitalBCS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface ISerializeModel
    {
        string SerializeCreateNewFolder(string nombreCarpeta);
        string SerializeCreateNewSender(string nombre, string email);
        string SerializeCreateNewListContact(string nombreLista, int idCarpeta);
        string SerializerDataNewEmailCampaing(string tag, string nameSender, string emailSender, string nameCampaing, string htmlCode, string subject);
    }
}
