using System.ComponentModel.DataAnnotations;

namespace eTicaretCase.ViewModel
{
    public class Kayit
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Sifre{ get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Sifre),ErrorMessage ="Şifreler Uyuşmuyor")]
        public string SifreTekrar { get; set; }
    }
}
