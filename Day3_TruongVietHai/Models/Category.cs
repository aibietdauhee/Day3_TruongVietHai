using System.ComponentModel.DataAnnotations;

namespace Day3_TruongVietHai.Models
{
    public class Category
    {
        [Required(ErrorMessage ="Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(100, MinimumLength =2, ErrorMessage = "ten danh muc phai co tu 2 den 100 ky tu")]
        public string Name { get; set; } = string.Empty;
        public List<Product>? Products { get; set; }
    }
}