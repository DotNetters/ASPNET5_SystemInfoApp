using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ASPNET5SystemInfoApp.Services
{
    public class WindowsSystemInfoService : ISystemInfoService
    {
        public IEnumerable<string> GetInstalledSoftware()
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        var displayName = (string)sk.GetValue("DisplayName");
                        if (displayName != null)
                            yield return displayName != null ? displayName : skName;
                    }
                }
            }
        }
    }
}
