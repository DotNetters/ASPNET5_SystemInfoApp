using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5SystemInfoApp.Services
{
    public class FallbackSystemInfoService : ISystemInfoService
    {
        public IEnumerable<string> GetInstalledSoftware()
        {
            return new string[] { };
        }
    }
}
