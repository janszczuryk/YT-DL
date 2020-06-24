using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace YT_DL
{
    public partial class YTDLOkno : Form
    {
        public YTDLOkno()
        {
            InitializeComponent();
        }

        private void YTDLOkno_Load(object sender, EventArgs e)
        {
            Downloader downloader = new Downloader();
            downloader.UpdateYoutubeDL();

        }

        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDownloadTitle_Click(object sender, EventArgs e)
        {
            string title = inputTitle.Text;
            outputLogs.AppendText(@"Rozpoczęcie pobierania: " + title + "...");
            Downloader Downloader = new Downloader();
            string Output = Downloader.StartDownloadTitle(title);
            outputLogs.AppendText(Output);
            outputLogs.AppendText(Environment.NewLine + Environment.NewLine);
        }

        private void ButtonDownloadedFolder_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + Downloader.GetDownloadingPath();
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void ButtonDownloadLinks_Click(object sender, EventArgs e)
        {
            List<string> Links = new List<string>(inputLinks.Lines);
            outputLogs.AppendText(@"Rozpoczęcie pobierania zestawu linków...");
            Downloader Downloader = new Downloader();
            string Output = Downloader.StartDownloadLinks(Links);
            outputLogs.AppendText(Output);
            outputLogs.AppendText(Environment.NewLine + Environment.NewLine);
        }
        private void stripInputTitlePaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                inputTitle.Paste();
            }
        }

        private void stripInputLinksPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                inputLinks.Paste();
            }
        }

    }
}
