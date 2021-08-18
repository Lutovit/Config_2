using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config_2
{
    public class AdminSettings
    {
        public const string Settings = "AdminSettings";


        public string adminName { set; get; }
        public string adminEmail { set; get; }
    }
}
