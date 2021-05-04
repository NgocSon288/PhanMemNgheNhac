using App.Common;
using App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace App.Services
{
    public interface ISongCategoryService
    {
        Task<List<SongCategory>> GetAll();
    }

    public class SongCategoryService : ISongCategoryService
    {
        public async Task<List<SongCategory>> GetAll()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var dataString = await client.GetStringAsync(Constants.GET_CATEGORIES);

                    return JsonConvert.DeserializeObject<List<SongCategory>>(dataString);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}