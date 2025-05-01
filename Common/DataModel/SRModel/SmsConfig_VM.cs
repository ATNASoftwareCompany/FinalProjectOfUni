using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.SRModel
{
    public class SmsConfig_VM
    {
        public string BaseUrl { get; set; } = "https://console.melipayamak.com/";
        public string Username { get; set; }
        public string Password { get; set; }
        public string SenderNumber { get; set; }
    }
}
