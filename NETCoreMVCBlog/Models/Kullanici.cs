using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NETCoreMVCBlog.Models
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Elektronik Posta")]
        public string Email { get; set; }
    }
}
