namespace Coffee_Ecommerce.WebApp.Features.Report
{
    public sealed class ReportMessage
    {
        public Guid Sender { get; set; }
        public Guid Receiver { get; set; }
        public Guid Report { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public ReportMessage(Guid sender, Guid receiver, Guid report, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentNullException("Message content cannot be empty");

            Sender = sender;
            Receiver = receiver;
            Report = report;
            Content = content;
        }
    }
}
