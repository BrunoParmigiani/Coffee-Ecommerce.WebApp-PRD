namespace Coffee_Ecommerce.WebApp.Services
{
    public static class StringService
    {
        public static string? Cut(string s, int i)
        {
            if (i > s.Length - 1)
                return null;

            return $"{s.Substring(0, i)}...";
        }
    }
}
