using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YT_DL
{
    class YoutubeDLManager
    {
        protected readonly string YoutubeDLPath = "youtube-dl.exe";
        protected List<string> Parameters = new List<string>();
        protected Process YoutubeDLProcess;
       
        public YoutubeDLManager()
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

        public async void UpdateYoutubeDL()
        {
            Parameters.Clear();
            AddParameter("-U");

            await RunYoutubeDL();
        }

        protected async Task<string> RunYoutubeDL()
        {
            string args = String.Join(" ", Parameters);

            //Console.WriteLine("Arg: " + args);

            YoutubeDLProcess.StartInfo.Arguments = args;
            YoutubeDLProcess.Start();
            var outputTask = await YoutubeDLProcess.StandardOutput.ReadToEndAsync();
            YoutubeDLProcess.WaitForExit();
            YoutubeDLProcess.Close();

            Parameters.Clear();

            return outputTask;
        }
        protected void AddParameter(string parameter)
        {
            Parameters.Add(parameter);
        }

        protected static string EscapeArguments(params string[] args)
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

    }
}