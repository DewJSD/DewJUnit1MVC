using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DewJUnit1MVC.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a username")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public string? Password { get; set; }

        public string? DetermineEmail()
        {
            string? str = Username;
            string? custEmail = string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString() + "@thisisfake.com";
        }
    }
}
