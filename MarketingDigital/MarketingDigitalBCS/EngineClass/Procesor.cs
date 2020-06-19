using MarketingDigitalBCS.EngineClass.Interfaces;
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

        public Procesor(IToolApp _toolApp)
        {
            toolApp = _toolApp;
        }

        public Procesor(ISerializeModel _serializeModel ,ISenderRepository _senderRepository)
        {
            serializeModel = _serializeModel;
            senderRepository = _senderRepository;
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
    }
}
