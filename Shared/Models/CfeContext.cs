using Coffee_Ecommerce.WebApp.Features.Establishment;
using Coffee_Ecommerce.WebApp.Identity;

namespace Coffee_Ecommerce.WebApp.Shared.Models
{
    public sealed class CfeContext
    {
        public AppIdentityContext Identity { get; private set; } = new();
        public EstablishmentEntity Establishment { get; private set; } = new();

        public CfeContext()
        {
        }

        public void SetEstablishment(EstablishmentEntity establishment)
        {
            if (establishment is null)
                return;
            
            Establishment = establishment;
        }
    }
}
