using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBoy.Models
{
    public class Profile
    {
        public class Location
        {
            public int coordinates { get; set; }
        }
        public class UserProfile
        {
            public int id { get; set; }
            public string email { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string bio { get; set; }
            public string locationName { get; set; }
            public List<Location> location { get; set; }
        }
        public class UserStatus
        {
            public string status { get; set; }
            public string message { get; set; }
            public List<UserProfile> userprofile { get; set; }
        }
      
    }

}