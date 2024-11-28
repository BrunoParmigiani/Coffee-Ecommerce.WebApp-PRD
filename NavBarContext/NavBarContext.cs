using BlazorBootstrap;
using Coffee_Ecommerce.WebApp.Identity;
using Coffee_Ecommerce.WebApp.Shared.Models;
using Microsoft.AspNetCore.Components.Routing;

namespace Coffee_Ecommerce.WebApp.NavBarContext
{
    public class NavBarContext
    {
        private readonly AppIdentityContext _identity;

        public NavBarContext(CfeContext context)
        {
            _identity = context.Identity;
        }

        public IEnumerable<NavItem> GetItems()
        {
            if (_identity.Role == null)
                return new List<NavItem>();

            switch (_identity.Role)
            {
                case "business_owner":
                    return GetOwnerItems();
                case "commercial_admin":
                    return GetAdminItems();
                case "commercial_place":
                    return GetEstablishmentItems();
                case "customer":
                    return GetCustomerItems();
                default:
                    return new List<NavItem>();
            }
        }

        private IEnumerable<NavItem> GetOwnerItems()
        {
            return new List<NavItem>
            {
                new NavItem { Id = "1", Href = "/home", IconName = IconName.HouseDoorFill, Text = "Home", Match=NavLinkMatch.All},
                new NavItem { Id = "2", Href = "/admins", IconName = IconName.ShieldFill, Text = "Administradores", Match=NavLinkMatch.All},
                new NavItem { Id = "3", Href = "/announcements", IconName = IconName.ExclamationDiamondFill, Text = "Anúncios", Match=NavLinkMatch.All},
                new NavItem { Id = "4", Href = "/resumes", IconName = IconName.PersonVCardFill, Text = "Currículos", Match=NavLinkMatch.All},
                new NavItem { Id = "5", Href = "/establishments", IconName = IconName.HouseFill, Text = "Estabelecimentos", Match=NavLinkMatch.All},
                new NavItem { Id = "6", Href = "/footeritems", IconName = IconName.List, Text = "Rodapé", Match=NavLinkMatch.All}
            };
        }

        private IEnumerable<NavItem> GetAdminItems()
        {
            return new List<NavItem>
            {
                new NavItem { Id = "1", Href = "/home", IconName = IconName.HouseDoorFill, Text = "Home", Match=NavLinkMatch.All},
                new NavItem { Id = "2", Href = "/announcements", IconName = IconName.ExclamationDiamondFill, Text = "Anúncios", Match=NavLinkMatch.All},
                new NavItem { Id = "3", Href = "/products", IconName = IconName.Basket2Fill, Text = "Catálogo", Match=NavLinkMatch.All},
                new NavItem { Id = "4", Href = "/resumes", IconName = IconName.PersonVCardFill, Text = "Currículos", Match=NavLinkMatch.All},
                new NavItem { Id = "5", Href = "/reports", IconName = IconName.ExclamationOctagonFill, Text = "Reclamações", Match=NavLinkMatch.All},
                new NavItem { Id = "6", Href = "/orders", IconName = IconName.Receipt, Text = "Pedidos", Match=NavLinkMatch.All}
            };
        }

        private IEnumerable<NavItem> GetEstablishmentItems()
        {
            return new List<NavItem>
            {
                new NavItem { Id = "1", Href = "/home", IconName = IconName.HouseDoorFill, Text = "Home", Match=NavLinkMatch.All},
                new NavItem { Id = "2", Href = "/announcements", IconName = IconName.ExclamationDiamondFill, Text = "Anúncios", Match=NavLinkMatch.All},
                new NavItem { Id = "3", Href = "/products", IconName = IconName.Basket2Fill, Text = "Catálogo", Match=NavLinkMatch.All},
                new NavItem { Id = "4", Href = "/reports", IconName = IconName.ExclamationOctagonFill, Text = "Reclamações", Match=NavLinkMatch.All},
                new NavItem { Id = "5", Href = "/orders/new", IconName = IconName.CupHotFill, Text = "Novos Pedidos", Match=NavLinkMatch.All},
                new NavItem { Id = "6", Href = "/orders", IconName = IconName.Receipt, Text = "Pedidos", Match=NavLinkMatch.All}
            };
        }

        private IEnumerable<NavItem> GetCustomerItems()
        {
            return new List<NavItem>
            {
                new NavItem { Id = "1", Href = "/home", IconName = IconName.HouseDoorFill, Text = "Home", Match=NavLinkMatch.All},
                new NavItem { Id = "2", Href = "/announcements", IconName = IconName.ExclamationDiamondFill, Text = "Anúncios", Match=NavLinkMatch.All},
                new NavItem { Id = "3", Href = "/products", IconName = IconName.Basket2Fill, Text = "Catálogo", Match=NavLinkMatch.All},
                new NavItem { Id = "4", Href = "/reports", IconName = IconName.ExclamationOctagonFill, Text = "Reclamações", Match=NavLinkMatch.All},
                new NavItem { Id = "5", Href = "/favorites", IconName = IconName.StarFill, Text = "Favoritos", Match=NavLinkMatch.All},
                new NavItem { Id = "6", Href = "/orders", IconName = IconName.Receipt, Text = "Pedidos", Match=NavLinkMatch.All},
                new NavItem { Id = "7", Href = "/resumes/user", IconName = IconName.PersonVCardFill, Text = "Trabelhe conosco", Match=NavLinkMatch.All}
            };
        }
    }
}
