namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public static class Statuses
    {
        private static Dictionary<int, string> _statuses = new()
        {
            { 0, "Aberta" },
            { 1, "Em andamento" },
            { 2, "Fechada" }
        };

        public static string GetStatusName(int n)
        {
            return _statuses[n];
        }

        public static Dictionary<int, string> GetStatuses()
        {
            return new Dictionary<int, string>(_statuses);
        }
    }
}
