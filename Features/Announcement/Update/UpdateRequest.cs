namespace Coffee_Ecommerce.WebApp.Features.Announcement.Update
{
    public sealed class UpdateRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public Dictionary<int, bool> Recipients { get; set; } = new Dictionary<int, bool>
        {
            { 0, false },
            { 1, false },
            { 2, false },
            { 3, false }
        };
    }
}
