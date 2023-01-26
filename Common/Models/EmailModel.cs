using System.ComponentModel;

namespace Common.Models
{
    public class EmailModel
    {
        [DisplayName("Destinatarios")]
        public string email { get; set; }
    }
}