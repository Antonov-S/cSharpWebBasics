namespace MyWebServer.Server.Responses
{
    using System.Text;
    using MyWebServer.Server.Common;
    using MyWebServer.Server.Http;
    using MyWebServer.Server.Results;
    

    public class ContentResponse : HttpResponse
    {
        public ContentResponse(string text, string contentType)
            : base(HttpStatusCode.Ok)
        {
            Guard.AgainstNull(text);

            var contentLength = Encoding.UTF8.GetByteCount(text).ToString();

            this.Headers.Add("Content-Type", contentType);
            this.Headers.Add("Content-Length", contentLength);

            this.Content = text;
        }
    }
}
