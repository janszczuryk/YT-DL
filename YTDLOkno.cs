using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace YT_DL
{
    public partial class YTDLOkno : Form
    {
        private static readonly string NL = Environment.NewLine;
        private static bool Updated = false;

        public YTDLOkno()
        {
            InitializeComponent();
        }

        private void YTDLOkno_Load(object sender, EventArgs e)
        {
            YoutubeDLManager manager = new YoutubeDLManager();
            manager.UpdateYoutubeDL();
            Updated = true;
        }

        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDownloadedFolder_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + YoutubeDLDownload.GetPathDownloading();
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private async void ButtonDownloadTitle_Click(object sender, EventArgs e)
        {
            if (!CanRun())
                return;

            string title = inputTitle.Text;
            outputLogs.AppendText(@"Rozpoczęcie pobierania: " + title + "..." + NL + NL);

            YoutubeDLDownload downloader = new YoutubeDLDownload();
            var output = await downloader.StartDownloadTitle(title);

            outputLogs.AppendText(output + NL + NL);
        }

        private async void ButtonDownloadLinks_Click(object sender, EventArgs e)
        {
            if (!CanRun())
                return;

            List<string> links = new List<string>(inputLinks.Lines);
            outputLogs.AppendText(@"Rozpoczęcie pobierania zestawu linków..." + NL + NL);

            YoutubeDLDownload downloader = new YoutubeDLDownload();
            var output = await downloader.StartDownloadLinks(links);

            outputLogs.AppendText(output + NL + NL);
        }

        private void stripInputTitlePaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                inputTitle.Paste();
            }
        }

        private void stripInputLinksPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                inputLinks.Paste();
            }
        }

        private async void inputTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTitle.Text))
            {
                if (e.KeyChar == (char)Keys.Enter && CanRun())
                {

                    string title = inputTitle.Text;
                    outputLogs.AppendText(@"Rozpoczęcie pobierania: " + title + "..." + NL + NL);

                    YoutubeDLDownload downloader = new YoutubeDLDownload();
                    var output = await downloader.StartDownloadTitle(title);

                    outputLogs.AppendText(output + NL + NL);
                }
            }
        }

        private bool CanRun()
        {
            return (Updated == true);
        }
    }
}
