using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_DL
{
    class YoutubeDLDownload : YoutubeDLManager
    {
        public const string FileNameFormat = @"%(title)s.%(ext)s";
        private const string PathLib = @"lib64\";
        private static string PathDownloading = @"downloaded\";

        public static string GetPathDownloading()
        {
            return PathDownloading;
        }

        public async Task<string> StartDownloadLinks(List<string> links)
        {
            SetDownloadParameters();
            SetDownloadLinks(links);

            return await RunYoutubeDL();
        }

        public async Task<string> StartDownloadTitle(string title)
        {
            SetDownloadParameters();
            AddParameter("--default-search " + EscapeArguments("ytsearch"));
            AddParameter(EscapeArguments($"\"{ title }\""));

            return await RunYoutubeDL();
        }

        private void SetDownloadParameters()
        {
            Parameters.Clear();
            AddParameter("--ignore-config");
            AddParameter("-x");
            AddParameter("--audio-format mp3");
            AddParameter("--audio-quality 0");
            AddParameter($"--ffmpeg-location " + EscapeArguments(PathLib));
            AddParameter($"-o " + EscapeArguments(PathDownloading + FileNameFormat));
        }

        private void SetDownloadLinks(List<string> links)
        {
            foreach (string link in links)
            {
                AddParameter(EscapeArguments(link));
            }
        }

    }
}
