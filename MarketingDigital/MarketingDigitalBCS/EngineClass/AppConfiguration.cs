using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.EngineClass
{
    public class AppConfiguration
    {
        public static string SbApiKey = "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";
        public static string SbSmtpKey = "UPDbq2sVG50yWQkA";

        public static string EndPointCreateSender = "https://api.sendinblue.com/v3/senders";

        public static string EndPointRecoverSender = "https://api.sendinblue.com/v3/senders";

        public static string EndPointCreateFolder = "https://api.sendinblue.com/v3/contacts/folders";

        public static string EndPointRecoverFolder = "https://api.sendinblue.com/v3/contacts/folders";

        public static string EndPointRecoverListInFolder = "https://api.sendinblue.com/v3/contacts/folders/ID/lists"; //Remplazar ID por id de la carpeta

        public static string EndPointCreateRecipientList = "https://api.sendinblue.com/v3/contacts/lists";

        public static string EndPointRecoverList = "https://api.sendinblue.com/v3/contacts/lists";

        public static string EndPointRecoverListId = "https://api.sendinblue.com/v3/contacts/lists/ID"; //Remplazar ID por id de la lista

        public static string EndPointCreateContact = "https://api.sendinblue.com/v3/contacts";

        public static string EndPointRecoverContactInList = "https://api.sendinblue.com/v3/contacts/lists/ID/contacts";//Remplazar ID por id de la lista

        public static string EndPointGetInformationContact = "https://api.sendinblue.com/v3/contacts/EMAIL"; //Remplazar EMAIL por direccion de correo electronico(email)

        public static string EndPointAddContactToList = "https://api.sendinblue.com/v3/contacts/lists/ID/contacts/add"; //Remplazar ID por id de la lista

        public static string EndPointCreateEmailCampaing = "https://api.sendinblue.com/v3/emailCampaigns";

        public static string EndPointSendEmailCampaing = "https://api.sendinblue.com/v3/emailCampaigns/ID/sendTest"; //Remplazar ID por id de la campaña a enviar

        public static string EndPointSendEmailTransaccional = "https://api.sendinblue.com/v3/smtp/email";

        public static string EndPointRecoverEmailCampaing = "https://api.sendinblue.com/v3/emailCampaigns";

    }
}
