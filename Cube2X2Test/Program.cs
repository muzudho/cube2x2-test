using System;

[assembly: CLSCompliant(true)]
namespace Grayscale.Cube2X2Test
{
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// プログラム。
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// <param name="args">コマンドライン引数。</param>
        [STAThread]
        public static void Main(string[] args)
        {
            // DefaultTraceListenerを削除する
            Trace.Listeners.Remove("Default");

            if (!Directory.Exists("./logs"))
            {
                Directory.CreateDirectory("./logs");
            }

            // ログ リスナーを追加。
            Trace.Listeners.Add(new TextWriterTraceListener("./logs/cube2x2-test.log", "LogFile"));

            // コンソール
            Trace.Listeners.Add(new ConsoleTraceListener());

            // コマンドライン引数読取。
            CommandLineParameter.Parse(args);

            Trace.WriteLine(string.Format(
                CultureInfo.CurrentCulture,
                "Command line: Position `{0}`.",
                CommandLineParameter.Position));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
