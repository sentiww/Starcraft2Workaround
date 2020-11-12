using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starcraft2Workaround
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["GamePath"] = GamePath.Text;
            Properties.Settings.Default.Save();

            try
            {
                var path = Path.Combine(GamePath.Text, x64RadioButton.Checked ? @"Support64\SC2Switcher_x64.exe" : @"Support\SC2Switcher.exe");
                Process.Start(path);
            }
            catch(Win32Exception ex)
            {
                MessageBox.Show(string.Format("Error message:\n{0}", ex.Message), "An unexpected error has occured!");
            }

            var releaseProc = new Process();
            releaseProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            releaseProc.StartInfo.FileName = "ipconfig";
            releaseProc.StartInfo.Arguments = "/release";
            releaseProc.Start();
            releaseProc.WaitForExit();
            
            var renewProc = new Process();
            renewProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            renewProc.StartInfo.FileName = "ipconfig";
            renewProc.StartInfo.Arguments = "/renew";
            renewProc.Start();

            if(CloseAfterStartup.Checked)
                this.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GamePath.Text = Properties.Settings.Default["GamePath"].ToString();
        }
    }
}
