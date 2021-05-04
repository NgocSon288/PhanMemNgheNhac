using App.Common;
using App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace App.Services
{
    public interface ISongService
    {
        Task<List<Song>> GetAll();
    }

    public class SongService : ISongService
    {
        public async Task<List<Song>> GetAll()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var dataString = await client.GetStringAsync(Constants.GET_SONGS);

                    return JsonConvert.DeserializeObject<List<Song>>(dataString);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}