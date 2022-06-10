using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationProjectFrontendMVC.Models
{

        public class Home
        {
            public int ID;
            public string Body;
            public DateTime StartDate;
            public DateTime EndDate;
            public bool Status;
            public short Severity;
            public DateTime LastUpdateDate; 
        }
}