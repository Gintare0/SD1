using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SD1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void RunStudentasExecutable()
        {
            try
            {
                
                Process process = new Process();
                process.StartInfo.FileName = "studentas.exe"; 
                process.StartInfo.Arguments = ""; 
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                
                process.Start();

               
                string output = process.StandardOutput.ReadToEnd();

                
                process.WaitForExit();

                
                richTextBox1.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running studentas.exe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void RunStudentasMenuItem_Click(object sender, EventArgs e)
        {
            RunStudentasExecutable();
        }
    }
}
