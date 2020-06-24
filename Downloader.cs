using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace YT_DL
{
    class Downloader
    {
        private readonly string YoutubeDLPath = "youtube-dl.exe";
        private static string LibPath = @"lib64\";
        private static string DownloadingPath = @"downloaded\";
        private List<string> Parameters = new List<string>();
        private Process YoutubeDLProcess;
       
        public Downloader()
        {
            YoutubeDLProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = YoutubeDLPath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
        }
        public static string GetDownloadingPath()
        {
            return DownloadingPath;
        }

        public string StartDownloadLinks(List<string> links)
        {
            SetDownloadParameters();
            SetDownloadLinks(links);

            return RunYoutubeDL();
        }

        public string StartDownloadTitle(string title)
        {
            SetDownloadParameters();
            AddParameter("--default-search " + EscapeArguments("ytsearch"));
            AddParameter(EscapeArguments($"\"{ title }\""));

            return RunYoutubeDL();
        }

        public string UpdateYoutubeDL()
        {
            Parameters.Clear();
            AddParameter("-U");

            return RunYoutubeDL();
        }

        private string RunYoutubeDL()
        {
            string args = String.Join(" ", Parameters);

            Console.WriteLine("Arg: " + args);

            YoutubeDLProcess.StartInfo.Arguments = args;
            YoutubeDLProcess.Start();
            var outputTask = YoutubeDLProcess.StandardOutput.ReadToEndAsync();
            YoutubeDLProcess.WaitForExit();
            YoutubeDLProcess.Close();

            Parameters.Clear();

            return outputTask.Result;
        }

        private static string EscapeArguments(params string[] args)
        {
            StringBuilder arguments = new StringBuilder();
            Regex invalidChar = new Regex("[\x00\x0a\x0d]");//  these can not be escaped
            Regex needsQuotes = new Regex(@"\s|""");//          contains whitespace or two quote characters
            Regex escapeQuote = new Regex(@"(\\*)(""|$)");//    one or more '\' followed with a quote or end of string
            for (int carg = 0; args != null && carg < args.Length; carg++)
            {
                if (args[carg] == null) { throw new ArgumentNullException("args[" + carg + "]"); }
                if (invalidChar.IsMatch(args[carg])) { throw new ArgumentOutOfRangeException("args[" + carg + "]"); }
                if (args[carg] == String.Empty) { arguments.Append("\"\""); }
                else if (!needsQuotes.IsMatch(args[carg])) { arguments.Append(args[carg]); }
                else
                {
                    arguments.Append('"');
                    arguments.Append(escapeQuote.Replace(args[carg], m =>
                    m.Groups[1].Value + m.Groups[1].Value +
                    (m.Groups[2].Value == "\"" ? "\\\"" : "")
                    ));
                    arguments.Append('"');
                }
                if (carg + 1 < args.Length)
                    arguments.Append(' ');
            }
            return arguments.ToString();
        }

        private void SetDownloadParameters()
        {
            AddParameter("--ignore-config");
            AddParameter("-x");
            AddParameter("--audio-format mp3");
            AddParameter("--audio-quality 0");
            AddParameter($"--ffmpeg-location " + EscapeArguments(LibPath));
            AddParameter($"-o " + EscapeArguments(DownloadingPath + "%(title)s.%(ext)s"));
        }

        private void SetDownloadLinks(List<string> links)
        {
            foreach (string link in links)
            {
                AddParameter(EscapeArguments(link));
            }
        }

        private void AddParameter(string parameter)
        {
            Parameters.Add(parameter);
        }
    }
}