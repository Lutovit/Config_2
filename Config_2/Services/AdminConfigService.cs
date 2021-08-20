using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config_2.Services
{
    public class AdminConfigService:IAdminConfigService
    {
        private AdminSettings AdminSettings;
        private readonly IConfiguration Configuration;

        public AdminConfigService()
        {
            
        }

        public AdminConfigService(IConfiguration configuration) 
        {
            Configuration = configuration;

            //AdminSettings = new AdminSettings();

            //Configuration.GetSection(AdminSettings.Settings).Bind(AdminSettings);
            Configuration.GetSection(AdminSettings.Settings).Get<AdminSettings>();
        }

        public string adminName 
        {
            get { return AdminSettings.adminName; }
        }

        public string adminEmail
        {
            get { return AdminSettings.adminEmail; }
        }

    }
}
