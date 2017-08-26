using NewBoy.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBoy.Service
{
    public class RemoteService
    {
        public async Task GetRemoteService(Parameter param)
        {
            string passvalue = null;
            if(param.ptype =="Login")
            {
                passvalue ="h" ;
            }

            //post = string.Empty;
            //using (var httpClient = CreateClient())
            //{
            //    var response = await httpClient.GetAsync(passvalue);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var json = await response.Content.ReadAsStringAsync();
            //        if (!string.IsNullOrWhiteSpace(json))
            //        {
            //            var tempe = await Task.Run(() =>
            //                JsonConvert.DeserializeObject<Profile>(json)
            //             ).ConfigureAwait(false);
            //            post = tempe;
            //        }
            //    }
            //}
            //return post;
        }
        
    }
}
