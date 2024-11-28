namespace Coffee_Ecommerce.WebApp.Identity
{
    public static class Roles
    {
        public static string Owner { get; private set; } = "business_owner";
        public static string Administrator { get; private set; } = "commercial_admin";
        public static string Establishment { get; private set; } = "commercial_place";
        public static string User { get; private set; } = "customer";
        public static string SuspendedUser { get; private set; } = "suspended_account";
        public static string BlockedAccount { get; private set; } = "blocked_account";

        public static string? RoleName(int number)
        {
            switch (number)
            {
                case 0: return Owner;
                case 1: return Administrator;
                case 2: return Establishment;
                case 3: return User;
                default: return null;
            }
        }
    }
}
