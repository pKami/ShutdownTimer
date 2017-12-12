using System;
using System.Diagnostics;

namespace pKami.WinUtils.ShutdownTimer
{
    public static class ShutdownCommand
    {
        private static class Texts
        {
            internal const string Error_InvalidArguments = "Error: Invalid arguments passed.";

            internal static string TimeCannotBeLowerThanZero(string unit)
            {
                return string.Format("Time ({0}) cannot be lower than zero!", unit);
            }

            internal static string ErrorParsingParameter(string paramName)
            {
                return string.Format("Error parsing parameter: {0}", paramName);
            }
        }

        private static class Params
        {
            internal const string Force = "/f";
            internal const string Restart = "/r";
            internal const string Shutdown = "/s";
            private const string time = "/t";

            internal static string Time(int seconds)
            {
                return time + " " + seconds.ToString();
            }
        }

        public static void Execute(string hours, string minutes, string seconds, bool force = false, bool restart = false)
        {
            decimal h, m, s;

            if (!decimal.TryParse(hours, out h))
                throw new ArgumentException(Texts.ErrorParsingParameter("hours"), "hours");

            if (!decimal.TryParse(minutes, out m))
                throw new ArgumentException(Texts.ErrorParsingParameter("minutes"), "minutes");

            if (!decimal.TryParse(seconds, out s))
                throw new ArgumentException(Texts.ErrorParsingParameter("seconds"), "seconds");

            Execute(h, m, s, force, restart);
        }

        public static void Execute(decimal hours, decimal minutes, decimal seconds, bool force = false, bool restart = false)
        {
            if (hours < 0)
                throw new ArgumentException(Texts.TimeCannotBeLowerThanZero("hours"), "hours");

            if (minutes < 0)
                throw new ArgumentException(Texts.TimeCannotBeLowerThanZero("minutes"), "minutes");

            if (seconds < 0)
                throw new ArgumentException(Texts.TimeCannotBeLowerThanZero("seconds"), "seconds");

            decimal dSecTime = hours * 60 * 60 + minutes * 60 + seconds;

            Execute(Convert.ToInt32(dSecTime), force, restart);
        }

        public static void Execute(int seconds, bool force, bool restart)
        {
            if (seconds < 0)
                throw new ArgumentException(Texts.TimeCannotBeLowerThanZero("seconds"), "seconds");

            string stdOut, stdErr;
            int exitCode;

            using (Process p = new Process())
            {
                p.StartInfo.FileName = "shutdown.exe";
                p.StartInfo.Arguments = buildShutdownParams(seconds, force, restart);
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;  // do not diplay a window
                p.Start();
                stdOut = p.StandardOutput.ReadToEnd();
                stdErr = p.StandardError.ReadToEnd();
                p.WaitForExit();
                exitCode = p.ExitCode;
            }

            if (exitCode != 0)
            {
                string message = string.IsNullOrEmpty(stdErr) ? stdOut : stdErr;

                if (message.StartsWith("Usage: ") && message.TrimEnd().EndsWith("Legacy API shutdown"))
                    message = Texts.Error_InvalidArguments;

                throw new ApplicationException(message);
            }
        }

        private static string buildShutdownParams(int seconds, bool force, bool restart)
        {
            string shutdownParams = Params.Time(seconds);

            if (force)
            {
                shutdownParams += " " + Params.Force;
            }

            if (restart)
            {
                shutdownParams += " " + Params.Restart;
            }
            else
            {
                shutdownParams += " " + Params.Shutdown;
            }

            return shutdownParams;
        }
    }
}
