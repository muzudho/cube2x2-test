﻿namespace Grayscale.Cube2X2Test
{
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Text;
    using System.Windows.Forms;
    using Grayscale.Cube2X2Commons;

    /// <summary>
    /// 正規化一覧画面。
    /// </summary>
    public partial class NormalizationUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizationUserControl"/> class.
        /// </summary>
        public NormalizationUserControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 局面を設定。
        /// </summary>
        /// <param name="sourcePosition">元となる局面。</param>
        public void SetPosition(Position sourcePosition)
        {
            var sourceBoardText = sourcePosition.BoardText;
            var isomorphicPositions = IsomorphicPositions.Parse(sourcePosition);

            /*
            for (var i = 0; i < IsomorphicPositions.Order; i++)
            {
                var phaseBoardText = isomorphicPositions.Phase[i].Position.BoardText;
                Trace.WriteLine(string.Format(
                    CultureInfo.CurrentCulture,
                    "/ {0}: {1}",
                    i,
                    phaseBoardText));
            }
            */

            var normalizePosition = isomorphicPositions.Normalize();
            var normalizeBoardText = normalizePosition.BoardText;

            var developmentIndex = 0;
            foreach (var isomorphicPosition in isomorphicPositions.Phase)
            {
                var development = this.GetDevelopmentUserControl(developmentIndex);

                var phaseBoardText = isomorphicPosition.Position.BoardText;
                /*
                Trace.WriteLine(string.Format(
                    CultureInfo.CurrentCulture,
                    "* {0}: {1}",
                    developmentIndex,
                    phaseBoardText));
                 */

                var builder = new StringBuilder();
                foreach (var direction in isomorphicPosition.DirectionList)
                {
                    switch (direction)
                    {
                        case Direction.PlusX:
                            builder.Append("+X");
                            break;
                        case Direction.PlusY:
                            builder.Append("+Y");
                            break;
                        case Direction.PlusZ:
                            builder.Append("+Z");
                            break;
                    }
                }

                development.SetLabel(builder.ToString());

                development.SetPosition(phaseBoardText);

                if (phaseBoardText == sourceBoardText)
                {
                    development.BackColor = Color.White;
                }
                else if (phaseBoardText == normalizeBoardText)
                {
                    development.BackColor = Color.Silver;
                }
                else
                {
                    development.BackColor = Color.Black;
                }

                developmentIndex++;
            }
        }

        /// <summary>
        /// 展開図を取得。
        /// </summary>
        /// <param name="number">展開図番号。</param>
        /// <returns>展開図コントロール。</returns>
        public DevelopmentUserControl GetDevelopmentUserControl(int number)
        {
            // ユーザーコントロールの番号は 1つ 上がる。
            switch (number)
            {
                case 0:
                    return this.developmentUserControl1;
                case 1:
                    return this.developmentUserControl2;
                case 2:
                    return this.developmentUserControl3;
                case 3:
                    return this.developmentUserControl4;
                case 4:
                    return this.developmentUserControl5;
                case 5:
                    return this.developmentUserControl6;
                case 6:
                    return this.developmentUserControl7;
                case 7:
                    return this.developmentUserControl8;
                case 8:
                    return this.developmentUserControl9;
                case 9:
                    return this.developmentUserControl10;
                case 10:
                    return this.developmentUserControl11;
                case 11:
                    return this.developmentUserControl12;
                case 12:
                    return this.developmentUserControl13;
                case 13:
                    return this.developmentUserControl14;
                case 14:
                    return this.developmentUserControl15;
                case 15:
                    return this.developmentUserControl16;
                case 16:
                    return this.developmentUserControl17;
                case 17:
                    return this.developmentUserControl18;
                case 18:
                    return this.developmentUserControl19;
                case 19:
                    return this.developmentUserControl20;
                case 20:
                    return this.developmentUserControl21;
                case 21:
                    return this.developmentUserControl22;
                case 22:
                    return this.developmentUserControl23;
                case 23:
                    return this.developmentUserControl24;
                default:
                    // エラー。
                    return null;
            }
        }
    }
}
