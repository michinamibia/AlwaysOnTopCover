using Cover.Properties;
using System.Diagnostics;

namespace Outliner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Settings.Default.Location;
            this.Size = Settings.Default.Size;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Location = this.Location;
            Settings.Default.Size = this.Size;
            Settings.Default.Save();
        }
    }
}