using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void redirect()
        {
            DownloadTIme dt = new DownloadTIme();
            dt.Show();
        }

        private void label3_Click(object sender, EventArgs e) { Application.Exit(); }

        private void pictureBox2_Click(object sender, EventArgs e){ Application.Exit(); }

        private void panel3_Click(object sender, EventArgs e) { Application.Exit(); }

        private void label2_Click(object sender, EventArgs e) { redirect(); }

        private void pictureBox1_Click(object sender, EventArgs e) { redirect(); }

        private void panel2_Click(object sender, EventArgs e) { redirect(); }
    }
}
