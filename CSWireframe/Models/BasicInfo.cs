using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSWireframe.Models {
    public class Active {
        public string Name { get; set; }
        public string Date { get; set; }
    }

    public class Canceled {
        public string Name { get; set; }
        public string Date { get; set; }
    }

    public class FbPage {
        public object FbId { get; set; }
        public string Name { get; set; }
        public bool ReadAssoc { get; set; }
        public bool Profile { get; set; }
        public bool Idx { get; set; }
        public bool Feature { get; set; }
        public bool Ds { get; set; }
        public string AccessToken { get; set; }
    }

    public class BasicInfo {
        public string AboutMe { get; set; }
        public string MyServices { get; set; }
        public string Video { get; set; }
        public Active[] Active { get; set; }
        public Canceled[] Canceled { get; set; }
        public int[] ZipCodes { get; set; }
        public FbPage[] FbPages { get; set; }
    }
}