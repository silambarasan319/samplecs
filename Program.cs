using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace myWebApp
{   
    public static class OperatingSystem
    {
       public static bool IsWindows() =>
       RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

       public static bool IsMacOS() =>
       RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

       public static bool IsLinux() =>
       RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

