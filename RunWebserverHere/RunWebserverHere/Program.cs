namespace RunWebserverHere
{
    using Microsoft.Owin.Hosting;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    internal static class Program
    {
        internal static readonly int ErrorDirectoryNotFound = 13;
        internal static readonly int ErrorInvalidArguments = 999;
        internal static readonly int ErrorCancelled = 1000;
        private static Random RNG = new Random();

        [STAThread]
        internal static int Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(true);
            Application.EnableVisualStyles();
            
            if (args.Length == 0)
            {
                return RunInstallUninstallForm();
            }
            else if (args.Length >= 1 && args.Length < 3)
            {
                if (!Directory.Exists(args[0]))
                {
                    return ErrorDirectoryNotFound;
                }
                else
                {
                    return ConfigureAndRunWebServer(args[0], args);
                }
            }
            else
            {
                return ErrorInvalidArguments;
            }
        }

        internal static int RunInstallUninstallForm()
        {
            Application.Run(new InstallUninstallForm());
            return 0;
        }

        internal static int ConfigureAndRunWebServer(string workingDirectory, string[] allArguments)
        {
            WebServerConfig serverConfig = null;

            if (allArguments.Length > 1)
            {
                serverConfig = GetUserConfiguration(workingDirectory);
            }
            else
            {
                serverConfig = WebServerConfig.CreateDefault(workingDirectory);
            }

            if (serverConfig != null)
            {
                return RunWebServer(serverConfig);
            }
            else
            {
                return ErrorCancelled;
            }
        }
        
        internal static WebServerConfig GetUserConfiguration(string initialWorkingDirectory)
        {
            return WebServerConfig.CreateDefault(initialWorkingDirectory);
        }

        internal static int RunWebServer(WebServerConfig serverConfig)
        {
            var port = RNG.Next(10000, 60000);
            var startOptions = new StartOptions();
            
            startOptions.Urls.Add(string.Format("http://localhost:{0}", port));
            startOptions.Urls.Add(string.Format("http://127.0.0.1:{0}", port));
            startOptions.Urls.Add(string.Format("http://{0}:{1}", Environment.MachineName, port));

            var startupInstance = new OwinStartup(serverConfig);
        
            using (var cts = new CancellationTokenSource())
            using (var webApp = WebApp.Start(startOptions, startupInstance.Configuration))
            {
                Process.Start(startOptions.Urls[0]);

                var appContext = new WebServerApplicationContext();
                Application.Run(appContext);
            }

            return 0;
        }
    }
}
