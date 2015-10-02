namespace RunWebserverHere
{
    using System.IO;
    using System.Windows.Forms;

    internal class WebServerApplicationContext : ApplicationContext
    {
        private NotifyIcon notifyIcon;

        public WebServerApplicationContext()
        {
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.Icon = Properties.Resources.LogoIcon;
            this.notifyIcon.Text = "Web Server Running";

            var exitMenuItem = new MenuItem("E&xit");
            exitMenuItem.Click += exitMenuItem_Click;

            this.notifyIcon.ContextMenu = new ContextMenu(new[] { exitMenuItem });

            this.notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(2500, "RunWebserverHere", "Web server is running!", ToolTipIcon.Info);
        }

        private void exitMenuItem_Click(object sender, System.EventArgs e)
        {
            this.ExitThread();
        }
    }
}
