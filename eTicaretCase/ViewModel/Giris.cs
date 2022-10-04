using System.ComponentModel.DataAnnotations;

namespace eTicaretCase.ViewModel
{
    public class Giris
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        public bool BeniHatirla { get; set; }
    }
}
