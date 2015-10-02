namespace RunWebserverHere
{
    using Microsoft.Owin.FileSystems;
    using Microsoft.Owin.StaticFiles;
    using Owin;
    using System;

    internal class OwinStartup
    {
        private WebServerConfig serverConfig;

        public OwinStartup(WebServerConfig serverConfig)
        {
            this.serverConfig = serverConfig;
        }

        public void Configuration(IAppBuilder app)
        {
            var fileSystem = new PhysicalFileSystem(this.serverConfig.RootFolder);

            if (this.serverConfig.AllowDirectoryBrowsing)
            {
                app.UseDirectoryBrowser(new DirectoryBrowserOptions()
                    {
                        FileSystem = fileSystem
                    });
            }

            app.UseStaticFiles(new StaticFileOptions()
                {
                    FileSystem = fileSystem,
                    ServeUnknownFileTypes = true 
                });
        }
    }
}
