using Desktop_Biblioteca.Client.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace Desktop_Biblioteca.Client
{
    public class BaseClient
    {
        public ResponseModel<T> GetApi<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var responseModel = new ResponseModel<T>();
                try
                {
                    var response = client.GetAsync(url).Result;
                    responseModel.StatusCode = response.StatusCode;
                    var json = response.Content.ReadAsStringAsync().Result;
                    responseModel.Entity = JsonConvert.DeserializeObject<T>(json);
                }
                catch (System.Exception)
                {
                    responseModel.StatusCode = HttpStatusCode.InternalServerError;
                }
                return responseModel;
            }
        }
    }
}
