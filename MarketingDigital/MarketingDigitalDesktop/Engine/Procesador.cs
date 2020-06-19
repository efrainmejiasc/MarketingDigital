using MarketingDigitalBCS.EngineClass;
using System.Threading.Tasks;

namespace MarketingDigitalDesktop.Engine
{
    public class Procesador 
    {
        public bool EmailValido(string email)
        {
            var tool = new ToolApp();
            var procesor = new Procesor(tool);
            return procesor.EmailValido(email);
        }
        public async Task<bool> CrearNuevoRemitenteAsync(string nombre,string email)
        {
            var senderRepository = new SenderRepository();
            var serializeModel = new SerializeModel();
            var procesor = new Procesor(serializeModel,senderRepository);
            var result = await procesor.CreateNewSenderAsync(nombre, email);
            return result;
        }

    }
}
