namespace MyWebServer.Server.Responses
{
    using MyWebServer.Server.Results;

    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string text) 
            : base(text, "text/html; charset=UTF-8")
        {
        }
    }
}
