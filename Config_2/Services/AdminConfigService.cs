using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config_2.Services
{
    public class AdminConfigService:IAdminConfigService
    {
        private readonly AdminSettings _options;

        public AdminConfigService()
        {
            
        }

        public AdminConfigService(IOptionsSnapshot<AdminSettings> options) 
        {
            _options = options.Value;        
        }

        public string adminName 
        {
            get { return _options.adminName; }
        }

        public string adminEmail
        {
            get { return _options.adminEmail; }
        }

    }
}
