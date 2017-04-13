
namespace Eduro.Controllers.api
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web.Http;

    public class VideosController : ApiController
    {
        public HttpResponseMessage Get(string filename, string ext)
        {
            var video = new VideoStream(filename, ext);

            var response = Request.CreateResponse();
            response.Content = new PushStreamContent(video.WriteToStream, new MediaTypeHeaderValue("video/" + ext));

            return response;
        }
    }
}
