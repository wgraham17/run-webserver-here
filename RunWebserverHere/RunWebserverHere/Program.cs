namespace RunWebserverHere
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    internal static class Program
    {
        internal static readonly int ErrorDirectoryNotFound = 13;
        internal static readonly int ErrorInvalidArguments = 999;
        internal static readonly int ErrorCancelled = 1000;

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
                if (Directory.Exists(args[0]))
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

        internal static int RunWebServer(WebServerConfig serverConfig)
        {
            using (var cts = new CancellationTokenSource())
            {
                var token = cts.Token;
            }


            return 0;
        }
    }
}
