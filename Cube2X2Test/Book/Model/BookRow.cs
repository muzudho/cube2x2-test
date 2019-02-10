﻿namespace Grayscale.Cube2X2Test
{
    using System.Globalization;

    /// <summary>
    /// 定跡の１行分。
    /// </summary>
    public class BookRow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookRow"/> class.
        /// </summary>
        /// <param name="previousBoardText">1つ前の盤面。</param>
        /// <param name="handle">90°回転させた箇所。</param>
        /// <param name="ply">初期局面から何手目か。</param>
        public BookRow(string previousBoardText, int handle, int ply)
        {
            this.PreviousBoardText = previousBoardText;
            this.Handle = handle;
            this.Ply = ply;
        }

        /// <summary>
        /// Gets or sets 1つ前の盤面。
        /// </summary>
        public string PreviousBoardText { get; set; }

        /// <summary>
        /// Gets or sets 90°回転させた箇所。
        /// </summary>
        public int Handle { get; set; }

        /// <summary>
        /// Gets or sets 初期局面から何手目か。1手目なら 0。
        /// </summary>
        public int Ply { get; set; }

        /// <summary>
        /// 定跡出力。
        /// </summary>
        /// <returns>定跡文字列。</returns>
        public string ToText()
        {
            return string.Format(
                CultureInfo.CurrentCulture,
                "{0} {1} {2}",
                this.PreviousBoardText,
                this.Handle,
                this.Ply);
        }
    }
}
