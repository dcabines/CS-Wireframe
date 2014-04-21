using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSWireframe.Models {
    public class RegistrationInfo {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Profile { get; set; }
        public int ReadScore { get; set; }
        public string InstallDate { get; set; }
        public string Brokerage { get; set; }
        public string Broker { get; set; }
        public string Association { get; set; }
        public string BrokerageLogo { get; set; }
    }
}