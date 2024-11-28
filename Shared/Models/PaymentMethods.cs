namespace Coffee_Ecommerce.WebApp.Shared.Models
{
    public static class PaymentMethods
    {
        // What was that
        public static string Method(int n)
        {
            switch (n)
            {
                case 0:
                    return "Dinheiro";
                case 1:
                    return "Cartão";
                default:
                    return "Nenhum";
            }
        }
    }
}
