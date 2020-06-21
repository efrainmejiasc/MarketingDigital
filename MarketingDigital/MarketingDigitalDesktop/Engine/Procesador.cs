using MarketingDigitalBCS.EngineClass;
using MarketingDigitalBCS.Response;
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
            return await procesor.CreateNewSenderAsync(nombre, email);
        }

        public async Task<SBRecoverSender> ObtenerListaRemitentesAsync()
        {
            var senderRepository = new SenderRepository();
            var procesor = new Procesor(senderRepository);
            return  await procesor.GetRecoverSender();
        }

        public async Task<bool> CrearNuevaCarpetaAsync(string nombreCarpeta)
        {
            var folderRepository = new FolderRepository();
            var serializeModel = new SerializeModel();
            var procesor = new Procesor(serializeModel, folderRepository);
            return await procesor.CreateNewFolderAsync(nombreCarpeta);
        }

        public async Task<SBRecoverFolder> ObtenerListaCarpetasAsync()
        {
            var FolderRepository = new FolderRepository();
            var procesor = new Procesor(FolderRepository);
            return await procesor.GetRecoverFolder();
        }

        public async Task<bool> CrearNuevaListaContactoAsync(string nombreLista, int idCarpeta)
        {
            var listRepository = new ListRepository();
            var serializeModel = new SerializeModel();
            var procesor = new Procesor(serializeModel, listRepository);
            return await procesor.CreateNewListContactAsync(nombreLista, idCarpeta);
        }

        public async Task<SBRecoverListInFolder> ObtenerListasEnCarpetas(string idCarpeta)
        {
            var listRepository = new ListRepository();
            var procesor = new Procesor(listRepository);
            return await procesor.GetRecoverListInFolder(idCarpeta);
        }

    }
}
