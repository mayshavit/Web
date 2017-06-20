using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebServerAndClient
{
    public class ClientModel
    {/// <summary>
    /// /////////////////////////////////////////////////
    /// </summary>
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; } 
    }
}