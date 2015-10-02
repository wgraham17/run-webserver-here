namespace RunWebserverHere
{
    internal class WebServerConfig
    {
        public string RootFolder { get; private set; }

        public bool AllowDirectoryBrowsing { get; private set; }

        public static WebServerConfig CreateDefault(string rootFolder)
        {
            return new WebServerConfig()
            {
                RootFolder = rootFolder,
                AllowDirectoryBrowsing = true
            };
        }
    }
}
