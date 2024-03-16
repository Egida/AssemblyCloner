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
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Diagnostics;
using AssemblyCloner.Properties;

namespace AssemblyCloner
{
    public partial class Form1 : Form
    {
        private string iconFilePath;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void oneFile_Open_Click(object sender, EventArgs e)
        {
            file1Open_Dialog.Filter = "EXE files|*.exe";
            file1Open_Dialog.Title = "Open 1st EXE file!";

            if (file1Open_Dialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(file1Open_Dialog.FileName))
                {
                    oneFile_box.Text = file1Open_Dialog.FileName;
                } else
                {
                    MessageBox.Show("Selected file does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            } 
        }

        private void twoFile_Open_Click(object sender, EventArgs e)
        {
            file2Open_Dialog.Filter = "EXE files|*.exe";
            file2Open_Dialog.Title = "Open 1st EXE file!";

            if (file2Open_Dialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(file2Open_Dialog.FileName))
                {
                    twoFile_box.Text = file2Open_Dialog.FileName;
                }
                else
                {
                    MessageBox.Show("Selected file does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void build_btn_Click(object sender, EventArgs e)
        {


            string oneFile = oneFile_box.Text;
            string twoFile = twoFile_box.Text;
            string resPath = Path.Combine(Environment.CurrentDirectory, "res.exe");

            File.WriteAllBytes(resPath, Resources.Resource1.Res);

            if (string.IsNullOrEmpty(oneFile) || string.IsNullOrEmpty(twoFile))
            {
                MessageBox.Show("Forms cannot be empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(oneFile) && !File.Exists(twoFile))
            {
                MessageBox.Show("Selected Files does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(resPath))
            {
                MessageBox.Show("Res.exe does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            try
            {
                bool iconIsInputed = false;

                if (iconFilePath != null)
                {
                    if (File.Exists(iconFilePath))
                    {
                        iconIsInputed = true;
                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "EXE Files (*.exe)|*.exe";
                    saveFileDialog.Title = "Save Output File";
                    saveFileDialog.FileName = "Output.exe";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        ExecuteResCommand($"-extract {oneFile}, resources.res, VERSIONINFO,,");
                        ExecuteResCommand($"-delete \"{twoFile}\", tempFile.exe, VERSIONINFO,,");
                        ExecuteResCommand($"-addoverwrite tempFile.exe, ReadyFile.exe, resources.res, VERSIONINFO,,");

                        if (iconIsInputed)
                        {
                            File.Copy(iconFilePath, Path.Combine(Environment.CurrentDirectory,"icon_get.ico"));

                            ExecuteResCommand($"-delete ReadyFile.exe, ChangeIco.exe, ICONGROUP,,");
                            ExecuteResCommand($"-addoverwrite ChangeIco.exe, {saveFileDialog.FileName}, icon_get.ico, ICONGROUP,1,");

                            File.Delete("ChangeIco.exe");
                            File.Delete("icon_get.ico");
                        }
                        
                        else
                        {
                            File.Move("ReadyFile.exe", saveFileDialog.FileName);
                        }

                        File.Delete($"ReadyFile.exe");
                        File.Delete($"tempFile.exe");
                        File.Delete($"Res.ini");
                        File.Delete($"res.log");
                        File.Delete($"resources.res");
                        File.Delete($"res.exe");

                        MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteResCommand(string arguments)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "res.exe";
            processInfo.Arguments = arguments;
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            string errorOutput = process.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(errorOutput))
            {
                throw new Exception($"res.exe error: {errorOutput}");
            }
        }

        private void iconSelect_Click(object sender, EventArgs e)
        {
            iconFileDialog.Filter = "ICO files|*.ico";
            iconFileDialog.Title = "Open ICO File";

            if (iconFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(iconFileDialog.FileName))
                {
                    iconInput.Image = Image.FromFile(iconFileDialog.FileName);
                    iconFilePath = iconFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Selected file does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            oneFile_box.Clear();
            twoFile_box.Clear();
            iconFilePath = "";
            iconInput.Image = null;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
