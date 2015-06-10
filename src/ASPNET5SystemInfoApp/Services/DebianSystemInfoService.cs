using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5SystemInfoApp.Services
{
    public class DebianSystemInfoService : ISystemInfoService
    {
        public IEnumerable<string> GetInstalledSoftware()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("dpkg", "--get-selections")
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process process = Process.Start(startInfo);
            process.Start();
            string line;
            do
            {
                line = process.StandardOutput.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                    yield return line.Split('\t', ' ')[0];

            } while (!process.HasExited || !string.IsNullOrWhiteSpace(line));
        }
    }
}
