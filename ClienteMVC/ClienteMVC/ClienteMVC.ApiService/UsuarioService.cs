using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Text;
using System.Threading.Tasks;

namespace ClienteMVC.ApiService
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient _client;

        public UsuarioService(HttpClient client)
        {
            //Configuramos el cliente
            this._client = ServiceConfiguration.InitClient(client);
        }

       
        public async Task<UsuarioServiceModel> GetAsync()
        {
            try
            {
               
                var response = await _client.GetAsync($"/api/v1/UsuarioAsync/GetAsync/");
                response.EnsureSuccessStatusCode();
                using (HttpContent Content = response.Content)
                {
                    return await Content.ReadAsAsync<UsuarioServiceModel>();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<UsuarioServiceModel> SetAsync(UsuarioServiceModel usuarioServiceModel)
        {
            try
            {
               
                var response = await _client.PostAsJsonAsync<UsuarioServiceModel>($"/api/v1/UsuarioAsync/SetAsync/",usuarioServiceModel);
                response.EnsureSuccessStatusCode();
                using (HttpContent Content = response.Content)
                {
                    return await Content.ReadAsAsync<UsuarioServiceModel>();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
