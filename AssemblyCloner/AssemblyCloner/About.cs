using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyCloner
{
    public partial class About : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public About()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void About_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void About_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void authorGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/k3rnel-dev");
        }

        private async void About_Load(object sender, EventArgs e)
        {
            while (true)
            {
                await PrintAndClearTextAsync("Assembly Cloner its a simple\r\nprogram for cloning assembly\r\ninformation of softwares.", label3);
                await Task.Delay(3000);
            }
        }

        private async Task PrintAndClearTextAsync(string text, Label label)
        {
            await PrintTextAsync(text, label);

            await Task.Delay(350);

            label.Text = "";
            await Task.Delay(250);
        }

        private async Task PrintTextAsync(string text, Label label)
        {
            foreach (char c in text)
            {
                label.Text += c;
                await Task.Delay(50);
            }
        }
    }
}
