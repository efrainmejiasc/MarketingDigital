using MarketingDigitalBCS.EngineClass.Interfaces;
using MarketingDigitalBCS.Response;
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
            var jsonContent = serializeModel.SerializeCreateNewSender(nombre, email);
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
           return  await contactRepository.CreateAddContactAsync(name, lastName, email, phone, idLista, updateEnable);
        }

    }
}
