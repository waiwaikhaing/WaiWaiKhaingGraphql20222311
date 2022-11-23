using Newtonsoft.Json;
using WaiWaiKhaingGraphql20222311.Models;

namespace WaiWaiKhaingGraphql20222311.Controllers
{
    public class BlogQuery
    {
        private readonly string Domainurl;
        private readonly string Endpoint;

        public BlogQuery()
        {
            Domainurl = "https://restandhttp-2022.herokuapp.com";
            Endpoint = "api/Blog";
        }
        public async Task<OurApi_BlogResponseModel> GetBlogListAsync()
        {
            OurApi_BlogResponseModel model = new OurApi_BlogResponseModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Domainurl);
            HttpResponseMessage response = await client.GetAsync(Endpoint);

            if (!response.IsSuccessStatusCode)
            {
                model.Response = new OurApi_ResponseModel
                {
                    RespType = EnumRespType.Information,
                    RespDesp = "No Data."
                };
                goto result;
            }
            string jsonStr = await response.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<BlogModel>>(jsonStr);

            if (lst.Count > 0)
            {
                model.lst = lst.Select(x => new BlogModelResponseModel
                {
                    Blog_Title = x.Blog_Title,
                    Blog_Author = x.Blog_Author,
                    Blog_Content = x.Blog_Content,
                }).ToList();
            }
            model.Response = new OurApi_ResponseModel
            {
                RespType = EnumRespType.Success,
                RespDesp = "Success."
            };
        result:
            return model;
        }
        public async Task<OurApi_BlogResponModelByID> GetAsync(int id)
        {
            OurApi_BlogResponModelByID model = new OurApi_BlogResponModelByID();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Domainurl);
            HttpResponseMessage response = await client.GetAsync($"{Endpoint}/{id}");

            if (!response.IsSuccessStatusCode)
            {
                model.Response = new OurApi_ResponseModel
                {
                    RespType = EnumRespType.Information,
                    RespDesp = "No Data."
                };
                goto result;
            }
            string jsonStr = await response.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<BlogModel>(jsonStr);

            if (lst is not null)
            {
                BlogModelResponseModel ml = new BlogModelResponseModel();
                ml.Blog_Title = lst.Blog_Title;
                ml.Blog_Author = lst.Blog_Author;
                ml.Blog_Content = lst.Blog_Content;
                model.lstBlog = ml;
            }
            model.Response = new OurApi_ResponseModel
            {
                RespType = EnumRespType.Success,
                RespDesp = "Success."
            };
        result:
            return model;
        }
    }
}
