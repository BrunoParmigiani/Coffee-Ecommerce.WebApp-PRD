using System.ComponentModel.DataAnnotations;

namespace Coffee_Ecommerce.WebApp.Features.Announcement.Create
{
    public sealed class CreateRequest
    {
        [Required(ErrorMessage = "Insira um nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Escreva uma mensagem")]
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
