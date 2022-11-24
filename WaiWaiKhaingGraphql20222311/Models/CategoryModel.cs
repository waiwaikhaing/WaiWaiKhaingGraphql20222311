using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreCRUDAssign.Shared.Models
{
   // [Table("Tbl_Category")]
    public class CategoryModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryCode { get; set; }
        public string? CategoryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? CreatedUserId { get; set; }
    }
}
