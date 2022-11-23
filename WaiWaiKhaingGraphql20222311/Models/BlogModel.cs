
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WaiWaiKhaingGraphql20222311.Models
{
    [Table("Tbl_Blog")]
    public class BlogModel
    {
        [Key]
        public int Blog_Id { get; set; }
        public string? Blog_Title { get; set; }
        public string? Blog_Author { get; set; }
        public string? Blog_Content { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? CreatedUser { get; set; }
    }
    public class OurApi_BlogResponseModel : OurApi_BaseResponseModel
    {
       public List<BlogModelResponseModel> lst { get; set; }
    }

    public class OurApi_BlogResponModelByID : OurApi_BaseResponseModel
    {
        public BlogModelResponseModel lstBlog { get; set; }
    }
    public class BlogModelResponseModel
    {
        public string? Blog_Title { get; set; }
        public string? Blog_Author { get; set; }
        public string? Blog_Content { get; set; }
    }
}



