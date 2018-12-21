using Masglobal.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;

namespace Masglobal.DAL
{
    public class Employees : Base
    {

        public async Task<IEnumerable<EmployeeDTO>> GetAsync(int id = 0)
        {
            var lstEmployees = new List<EmployeeDTO>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_strURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                    HttpResponseMessage response = await client.GetAsync($"api/{this.GetType().Name}/");
                    if (response.IsSuccessStatusCode)
                    {
                        lstEmployees = response.Content.ReadAsAsync<List<EmployeeDTO>>().Result;
                        if (id > 0)                        
                            return lstEmployees.Where(t => t.id.Equals(id));                        
                    }
                }

                return lstEmployees;
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());                
                return null;
            }
        }
    }
}