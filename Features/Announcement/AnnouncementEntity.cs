namespace Coffee_Ecommerce.WebApp.Features.Announcement
{
    public sealed class AnnouncementEntity
    {
        public Guid Id { get; set; }
        public Guid CreatorId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Recipients { get; set; }
    }
}
