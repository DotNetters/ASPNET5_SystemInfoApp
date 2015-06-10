using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5SystemInfoApp.Services
{
    public interface ISystemInfoService
    {
        IEnumerable<string> GetInstalledSoftware();
    }
}
