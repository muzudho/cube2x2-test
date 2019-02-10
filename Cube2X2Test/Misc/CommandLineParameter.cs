namespace Grayscale.Cube2X2Test
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// コマンドライン引数。
    /// </summary>
    public static class CommandLineParameter
    {
        /// <summary>
        /// 公開しないプロパティは定数でOK。
        /// </summary>
        private const string ArgPos = "--pos";

        /// <summary>
        /// Gets 初期局面。
        /// </summary>
        public static string Position
        {
            get; private set;
        }

        /// <summary>
        /// 解析。
        /// </summary>
        /// <param name="args">コマンドライン引数。</param>
        public static void Parse(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException("args");
            }

            Trace.WriteLine(string.Format(
                CultureInfo.CurrentCulture,
                "Command line length: {0}.",
                args.Length));

            if (args.Length < 2)
            {
                return;
            }

            var state = string.Empty;

            foreach (var token in args)
            {
                if (string.IsNullOrEmpty(state))
                {
                    switch (token)
                    {
                        case ArgPos:
                            state = token;
                            break;
                    }
                }
                else
                {
                    switch (state)
                    {
                        case ArgPos:
                            Trace.WriteLine(string.Format(
                                CultureInfo.CurrentCulture,
                                "Arg: `{0}`.",
                                state));
                            Position = token;
                            break;
                    }
                }
            }
        }
    }
}
