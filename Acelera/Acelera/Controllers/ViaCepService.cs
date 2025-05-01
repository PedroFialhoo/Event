using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Acelera.Models;
using Newtonsoft.Json;

namespace Acelera.Controllers
{
    public class ViaCepService
    {
        public async Task<Endereco> BuscarEnderecoAsync(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);
                        return endereco;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
