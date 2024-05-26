using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Security.Claims;

namespace AlbatrosPOS.App
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7043/api/");
        }

        public async Task<HttpResponseMessage> Execute(string uri, HttpMethod method, HttpContent? content = null)
        {
            var jwt = JwtManager.Token;

            this._httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);

            switch (method.Method)
            {
                case "GET":
                    var getResult = await this._httpClient.GetAsync(uri);
                    return getResult;

                case "POST":
                    var postResult = await this._httpClient.PostAsync(uri, content);
                    return postResult;

                case "PUT":
                    var putResult = await this._httpClient.PutAsync(uri, content);
                    return putResult;

                case "DELETE":
                    var deleteResult = await this._httpClient.DeleteAsync(uri);
                    return deleteResult;

                default:
                    var result = await this._httpClient.GetAsync(uri);
                    return result;
            }
        }

        public async Task<HttpResponseMessage> ExecuteWithoutToken(string uri, HttpMethod method, HttpContent? content = null)
        {
            switch (method.Method)
            {
                case "GET":
                    var getResult = await this._httpClient.GetAsync(uri);
                    return getResult;
                case "POST":

                    var postResult = await this._httpClient.PostAsync(uri, content);
                    return postResult;
                case "PUT":
                    var putResult = await this._httpClient.PutAsync(uri, content);
                    return putResult;

                case "DELETE":
                    var deleteResult = await this._httpClient.DeleteAsync(uri);
                    return deleteResult;

                default:
                    var result = await this._httpClient.GetAsync(uri);
                    return result;
            }
        }
    }
}
