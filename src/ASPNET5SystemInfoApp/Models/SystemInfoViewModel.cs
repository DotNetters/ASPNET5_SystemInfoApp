using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5SystemInfoApp.Models
{
    public class SystemInfoViewModel
    {
        public string SystemInfoServiceName { get; set; }

        public string ServerName { get; set; }
        public string OSVersion { get; set; }

        public IEnumerable<string> InstalledSoftware { get; set; }
    }
}
