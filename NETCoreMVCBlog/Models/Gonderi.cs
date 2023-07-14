using System.ComponentModel.DataAnnotations;

namespace NETCoreMVCBlog.Models
{
    public class Gonderi
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Bu alana en fazla 50 karakter yazılabilir")]
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}
