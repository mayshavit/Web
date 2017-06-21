using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServerAndClient.Models
{
    public class Client
    {
        public int ID { get; set; } //
        public string UserName { get; set; }
        public string Passward { get; set; }
        public string EMail { get; set; }
    }
}