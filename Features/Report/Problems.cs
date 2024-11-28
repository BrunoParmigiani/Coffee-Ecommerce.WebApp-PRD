namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public static class Problems
    {
        private static Dictionary<int, string> _problems = new()
        {
            { 0, "Pedido errado" },
            { 1, "Outros" }
        };

        public static string GetProblemName(int n)
        {
            return _problems[n];
        }

        public static Dictionary<int, string> GetProblems()
        {
            return new Dictionary<int, string>(_problems);
        }
    }
}
