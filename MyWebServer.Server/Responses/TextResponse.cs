namespace MyWebServer.Server.Results
{
    using MyWebServer.Server.Common;
    using System.Text;
    using MyWebServer.Server.Http;
    using MyWebServer.Server.Responses;
    

    public class TextResponse : ContentResponse
    {
        public TextResponse(string text)
            : base(text, "text/plain; charset=UTF-8")
        {
        }
    }
}
