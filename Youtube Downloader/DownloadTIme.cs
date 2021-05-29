using MediaToolkit;
using MediaToolkit.Model;
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
using VideoLibrary;

namespace Youtube_Downloader
{
    public partial class DownloadTIme : Form
    {
        public DownloadTIme()
        {
            InitializeComponent();
        }

        public void download()
        {
            string conv = textBox1.Text.ToLower();
            if (!conv.Contains("youtube.com"))
            {
                MessageBox.Show("The only allowed website here is youtube.com/");
            }
            else
            {
                if (!Directory.Exists("Downloaded"))
                {
                    Directory.CreateDirectory("Downloaded");
                }
                Thread.Sleep(1000);
                MessageBox.Show("Press OK to download, this might take 10 to 20 seconds", "Youtube Downloader", MessageBoxButtons.OK);
                try {
                    var source = "./Downloaded/";
                    var youtube = YouTube.Default;
                    var vid = youtube.GetVideo(textBox1.Text);
                    File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                    var inputFile = new MediaFile { Filename = source + vid.FullName };
                    var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);

                        engine.Convert(inputFile, outputFile);
                    }
                    MessageBox.Show("File is downloaded as " + vid.FullName + " in Downloaded folder");
                } catch
                {
                    MessageBox.Show("Something went wrong while downloading a file, this may be caused due your network or because of a missing dll", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { download(); }

        private void label2_Click(object sender, EventArgs e) { download(); }

        private void panel4_Click(object sender, EventArgs e) { download(); }
    }
}
