using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunWebserverHere
{
    public partial class InstallUninstallForm : Form
    {
        public InstallUninstallForm()
        {
            InitializeComponent();
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            try
            {
                var key = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("Directory\\shell\\runwebserverhere", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                key.SetValue(null, "Run Webserver Here");
                var commandKey = key.CreateSubKey("command");
                commandKey.SetValue(null, string.Format("\"{0}\" \"%1\"", Assembly.GetExecutingAssembly().Location));

                var key2 = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("Directory\\shell\\runwebserverhere_cfg", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                key2.SetValue(null, "Configure Webserver Here");
                key2.SetValue("Extended", "");
                var commandKey2 = key2.CreateSubKey("command");
                commandKey2.SetValue(null, string.Format("\"{0}\" \"%1\" --configure", Assembly.GetExecutingAssembly().Location));

                MessageBox.Show("Installed successfully!", "RunWebserverHere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Install failed! Try running as admin.", "RunWebserverHere", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
