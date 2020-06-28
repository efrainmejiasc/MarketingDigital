using MarketingDigitalBCS.EngineClass.Interfaces;
using MarketingDigitalBCS.Response;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass
{
    public class Procesor
    {

        private readonly IToolApp toolApp;
        private readonly ISenderRepository senderRepository;
        private readonly ISerializeModel serializeModel;
        private readonly IFolderRepository folderRepository;
        private readonly IListRepository listRepository;
        private readonly IContactRepository contactRepository;
        private readonly ICampanaEmailRepository campanaEmailRepository;

        #region CONSTRUCTORES

        public Procesor(IToolApp _toolApp)
        {
            toolApp = _toolApp;
        }

        public Procesor(ISenderRepository _senderRepository)
        {
            senderRepository = _senderRepository;
        }

        public Procesor(IListRepository _listRepository)
        {
            listRepository = _listRepository;
        }

        public Procesor(IFolderRepository _folderRepository)
        {
            folderRepository = _folderRepository;
        }

        public Procesor(IContactRepository _contactRepository)
        {
            contactRepository = _contactRepository;
        }

        public Procesor(ICampanaEmailRepository _campanaEmailRepository)
        {
            campanaEmailRepository = _campanaEmailRepository;
        }

        public Procesor(ISerializeModel _serializeModel, ICampanaEmailRepository _campanaEmailRepository)
        {
            serializeModel = _serializeModel;
            campanaEmailRepository = _campanaEmailRepository;
        }

        public Procesor(ISerializeModel _serializeModel ,ISenderRepository _senderRepository)
        {
            serializeModel = _serializeModel;
            senderRepository = _senderRepository;
        }

        public Procesor(ISerializeModel _serializeModel, IFolderRepository _folderRepository)
        {
            serializeModel = _serializeModel;
            folderRepository = _folderRepository;
        }

        public Procesor(ISerializeModel _serializeModel, IListRepository _listRepository)
        {
            serializeModel = _serializeModel;
            listRepository = _listRepository;
        }

        #endregion 


        public bool EmailValido (string email)
        {
            return toolApp.EmailEsValido(email);
        }

        public async Task<bool> CreateNewSenderAsync(string nombre , string email)
        {
            var jsonContent = serializeModel.SerializeCreateNewSender(nombre, email.ToLower());
            var result = await senderRepository.CreateNewSender(jsonContent);
            return result.exception;
        }

        public async Task<SBRecoverSender> GetRecoverSender()
        {
            return await senderRepository.GetRecoverSender();
        }

        public async Task<bool> CreateNewFolderAsync(string nombreCarpeta)
        {
            var jsonContent = serializeModel.SerializeCreateNewFolder(nombreCarpeta);
            var result = await folderRepository.CreateNewFolder(jsonContent);
            return result.exception;
        }

        public async Task<SBRecoverFolder> GetRecoverFolder()
        {
            return await folderRepository.GetRecoverFolder();
        }

        public async Task<bool> CreateNewListContactAsync(string nombreLista, int idCarpeta)
        {
            var jsonContent = serializeModel.SerializeCreateNewListContact(nombreLista, idCarpeta);
            var result = await listRepository.CreateNewList(jsonContent);
            return result.exception;
        }

        public async Task<SBRecoverListInFolder> GetRecoverListInFolder(string idFolder)
        {
            return await listRepository.GetRecoverListInFolder(idFolder);
        }

        public async Task<bool> CreateAddContactAsync(string name, string lastName, string email, string phone , int idLista,bool updateEnable)
        {
           return  await contactRepository.CreateAddContactAsync(name, lastName, email.ToLower(), phone, idLista, updateEnable);
        }

        public async Task<SBResponseContactInList> GetContactInList(string idLista)
        {
           return await contactRepository.GetContactInList(idLista);
        }

        public async Task<bool> CreateNewEmailCampaing (string tag, string nameSender, string emailSender, string nameCampaing, string htmlCode, string subject)
        {
            var jsonContent = serializeModel.SerializerDataNewEmailCampaing(tag, nameSender, emailSender, nameCampaing, htmlCode, subject);
            var result = await campanaEmailRepository.CreateEmailCampana(jsonContent);
            return result.exception;
        }

        public async Task<SBRecoverEmailCampaing> GetRecoverAllCampanaEmail()
        {
            return await campanaEmailRepository.GetRecoverAllCampanaEmail();
        }

        public async Task<SBRecoverList> GetRecoverAllListContact()
        {
            return await listRepository.GetRecoverAllListContact();
        }

        public async Task<bool> SendEmailCampaing (List<string> emailTo, string idCampaing)
        {
            var to = new List<string>();
            var jsonContent = string.Empty;
            bool result = false;
            foreach(var email in emailTo)
            {
                try
                {
                    to.Clear();
                    to.Add(email);
                    jsonContent = serializeModel.SerializeEmailTo(to);
                    result = await campanaEmailRepository.SendEmailCampana(jsonContent, idCampaing);
                }
                catch {}
            }
            return false;
        }

        public async Task<bool> SendEmailCampaing2(List<string> emailTo,string idCampaing)
        {
            var jsonContent = serializeModel.SerializeEmailTo(emailTo);
            return await campanaEmailRepository.SendEmailCampana(jsonContent, idCampaing);
        }

    }
}
