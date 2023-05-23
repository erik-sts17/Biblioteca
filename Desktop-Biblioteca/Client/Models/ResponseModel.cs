using System.Net;

namespace Desktop_Biblioteca.Client.Models
{
    public class ResponseModel<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Entity { get; set; }
    }
}
