using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Work_with_Registry
{
    public partial class Form1 : Form
    {
        RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            key.SetValue("TestProgram",
                "D:\\CSharp_Projects (Win forms)\\Work_with_Registry\\Work_with_Registry\\bin\\Debug\\Work_with_Registry.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            key.DeleteValue("TestProgram");
        }
    }
}
