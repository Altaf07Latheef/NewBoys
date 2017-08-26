using NewBoy.Models;
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
        }
        
    }
}
