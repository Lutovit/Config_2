using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config_2.Services
{
    public  interface IAdminConfigService
    {
        public string adminName { get; }
        public string adminEmail { get; }
    }
}
