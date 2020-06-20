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

        public Procesor(IToolApp _toolApp)
        {
            toolApp = _toolApp;
        }

        public Procesor(ISenderRepository _senderRepository)
        {
            senderRepository = _senderRepository;
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
    }
}
