using MarketingDigitalBC.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Interfaces
{
    public interface IProcesador
    {
        bool EmailValido(string email);
        Task<bool> DeleteContactAsync(string email);
        Task<SBResponseAllContacts> ObtenerAllContacts();
        Task<SBRecoverFolder> ObtenerListaCarpetasAsync();
        Task<SBRecoverSender> ObtenerListaRemitentesAsync();
        Task<SBRecoverList> ObtenerTodasListaContactoAsync();
        Task<bool> CrearNuevaCarpetaAsync(string nombreCarpeta);
        Task<SBRecoverEmailCampaing> ObtenerTodasCampanasEmailAsync();
        Task<bool> CrearNuevoRemitenteAsync(string nombre, string email);
        Task<SBResponseContactInList> ObtenerContactoEnLista(string idLista);
        Task<SBRecoverListInFolder> ObtenerListasEnCarpetas(string idCarpeta);
        Task<bool> SendEmailCampanaAsync(List<string> emailTo, string idCampaing);
        Task<bool> CrearNuevaListaContactoAsync(string nombreLista, int idCarpeta);
        Task<bool> UpdateContactAsync(string email, SBResponseAllContacts.Contacts contacto, string nuevoEmail);
        Task<bool> CrearAgregarContactoAsync(string name, string lastName, string email, string phone, int idLista, bool updateEnable);
        Task<bool> CrearNuevaCampanaEmailAsync(string tag, string nameSender, string emailSender, string nameCampaing, string htmlContent, string subject);

    }
}
