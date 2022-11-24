using DotNetCoreCRUDAssign.Shared.Models;
using WaiWaiKhaingGraphql20222311.Models;

namespace WaiWaiKhaingGraphql20222311.Controllers
{
    [ExtendObjectType("Query")]
    public class BlogConstantQuery
    {
        List<BlogModel> _blog = new List<BlogModel>();
        public BlogConstantQuery()
        {
            for (int i = 0; i < 10; i++)
            {
                BlogModel blog = new BlogModel();
                blog.Blog_Id = i;
                blog.Blog_Title = "title" + i.ToString();
                blog.Blog_Author = "author" + i.ToString();
                blog.Blog_Content = "content" + i.ToString();
                blog.IsActive = true;
                blog.CreatedDateTime = DateTime.Now;
                blog.CreatedUser = "User" + i.ToString();
                _blog.Add(blog);
            }
        }

        public List<BlogModel> BlogConstantList()
        {
            return _blog;
        }
        public BlogModel BlogConstantById(string id)
        {
            int _id = Convert.ToInt32(id);
            BlogModel item = _blog.FirstOrDefault(x => x.Blog_Id == _id);
            return item;
        }




    }
}
