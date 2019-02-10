﻿namespace Grayscale.Cube2X2Test
{
    using System.Globalization;

    /// <summary>
    /// 局面。
    /// </summary>
    public abstract class AbstractPosition : IPosition
    {
        /// <summary>
        /// Gets 盤面を、文字列で返す。
        /// </summary>
        /// <returns>局面</returns>
        public string BoardText
        {
            get
            {
                return string.Format(
                    CultureInfo.CurrentCulture,
                    "{0}{1}{2}{3}/{4}{5}{6}{7}/{8}{9}{10}{11}/{12}{13}{14}{15}/{16}{17}{18}{19}/{20}{21}{22}{23}",
                    ColorHelper.GetShort(this.GetTileColor(0)),
                    ColorHelper.GetShort(this.GetTileColor(1)),
                    ColorHelper.GetShort(this.GetTileColor(2)),
                    ColorHelper.GetShort(this.GetTileColor(3)),
                    ColorHelper.GetShort(this.GetTileColor(4)),
                    ColorHelper.GetShort(this.GetTileColor(5)),
                    ColorHelper.GetShort(this.GetTileColor(6)),
                    ColorHelper.GetShort(this.GetTileColor(7)),
                    ColorHelper.GetShort(this.GetTileColor(8)),
                    ColorHelper.GetShort(this.GetTileColor(9)),
                    ColorHelper.GetShort(this.GetTileColor(10)),
                    ColorHelper.GetShort(this.GetTileColor(11)),
                    ColorHelper.GetShort(this.GetTileColor(12)),
                    ColorHelper.GetShort(this.GetTileColor(13)),
                    ColorHelper.GetShort(this.GetTileColor(14)),
                    ColorHelper.GetShort(this.GetTileColor(15)),
                    ColorHelper.GetShort(this.GetTileColor(16)),
                    ColorHelper.GetShort(this.GetTileColor(17)),
                    ColorHelper.GetShort(this.GetTileColor(18)),
                    ColorHelper.GetShort(this.GetTileColor(19)),
                    ColorHelper.GetShort(this.GetTileColor(20)),
                    ColorHelper.GetShort(this.GetTileColor(21)),
                    ColorHelper.GetShort(this.GetTileColor(22)),
                    ColorHelper.GetShort(this.GetTileColor(23)));
            }
        }

        /// <summary>
        /// タイルの色を設定します。
        /// </summary>
        /// <param name="tile">タイル番号。</param>
        /// <param name="color">色。</param>
        public abstract void SetTileColor(int tile, int color);

        /// <summary>
        /// タイルの色を返します。
        /// </summary>
        /// <param name="tile">タイル番号。</param>
        /// <returns>タイルの色。</returns>
        public abstract int GetTileColor(int tile);

        /// <summary>
        /// ゲーム開始状態に戻します。
        /// </summary>
        public void SetNewGame()
        {
            // 初期局面。
            this.SetTileColor(0, (int)ColorNumber.Yellow);
            this.SetTileColor(1, (int)ColorNumber.Yellow);
            this.SetTileColor(2, (int)ColorNumber.Yellow);
            this.SetTileColor(3, (int)ColorNumber.Yellow);
            this.SetTileColor(4, (int)ColorNumber.Violet);
            this.SetTileColor(5, (int)ColorNumber.Violet);
            this.SetTileColor(6, (int)ColorNumber.Violet);
            this.SetTileColor(7, (int)ColorNumber.Violet);
            this.SetTileColor(8, (int)ColorNumber.Red);
            this.SetTileColor(9, (int)ColorNumber.Red);
            this.SetTileColor(10, (int)ColorNumber.Red);
            this.SetTileColor(11, (int)ColorNumber.Red);
            this.SetTileColor(12, (int)ColorNumber.Blue);
            this.SetTileColor(13, (int)ColorNumber.Blue);
            this.SetTileColor(14, (int)ColorNumber.Blue);
            this.SetTileColor(15, (int)ColorNumber.Blue);
            this.SetTileColor(16, (int)ColorNumber.Gray);
            this.SetTileColor(17, (int)ColorNumber.Gray);
            this.SetTileColor(18, (int)ColorNumber.Gray);
            this.SetTileColor(19, (int)ColorNumber.Gray);
            this.SetTileColor(20, (int)ColorNumber.Green);
            this.SetTileColor(21, (int)ColorNumber.Green);
            this.SetTileColor(22, (int)ColorNumber.Green);
            this.SetTileColor(23, (int)ColorNumber.Green);
        }

        /// <summary>
        /// 90度回転。4つのタイルを、１つずらします。
        /// </summary>
        /// <param name="tileA">タイル1。</param>
        /// <param name="tileB">タイル2。</param>
        /// <param name="tileC">タイル3。</param>
        /// <param name="tileD">タイル4。</param>
        public void Shift4(int tileA, int tileB, int tileC, int tileD)
        {
            // 展開図
            var temp = this.GetTileColor(tileD);
            this.SetTileColor(tileD, this.GetTileColor(tileC));
            this.SetTileColor(tileC, this.GetTileColor(tileB));
            this.SetTileColor(tileB, this.GetTileColor(tileA));
            this.SetTileColor(tileA, temp);
        }

        /// <summary>
        /// キューブを 90° ひねります。
        /// </summary>
        /// <param name="handle">回転箇所。</param>
        public void RotateOnly(int handle)
        {
            switch (handle)
            {
                case 0:
                    this.Shift4(8, 0, 19, 20);
                    this.Shift4(10, 2, 17, 22);
                    this.Shift4(5, 4, 6, 7);
                    break;
                case 1:
                    this.Shift4(9, 1, 18, 21);
                    this.Shift4(11, 3, 16, 23);
                    this.Shift4(12, 13, 15, 14);
                    break;
                case 2:
                    this.Shift4(12, 2, 7, 21);
                    this.Shift4(14, 3, 5, 20);
                    this.Shift4(9, 8, 10, 11);
                    break;
                case 3:
                    this.Shift4(13, 0, 6, 23);
                    this.Shift4(15, 1, 4, 22);
                    this.Shift4(16, 17, 19, 18);
                    break;
                case 4:
                    this.Shift4(9, 13, 17, 5);
                    this.Shift4(8, 12, 16, 4);
                    this.Shift4(3, 1, 0, 2);
                    break;
                case 5:
                    this.Shift4(11, 15, 19, 7);
                    this.Shift4(10, 14, 18, 6);
                    this.Shift4(21, 23, 22, 20);
                    break;
                case 6:
                    this.Shift4(21, 18, 1, 9);
                    this.Shift4(23, 16, 3, 11);
                    this.Shift4(14, 15, 13, 12);
                    break;
                case 7:
                    this.Shift4(20, 19, 0, 8);
                    this.Shift4(22, 17, 2, 10);
                    this.Shift4(7, 6, 4, 5);
                    break;
                case 8:
                    this.Shift4(23, 6, 0, 13);
                    this.Shift4(22, 4, 1, 15);
                    this.Shift4(18, 19, 17, 16);
                    break;
                case 9:
                    this.Shift4(21, 7, 2, 12);
                    this.Shift4(20, 5, 3, 14);
                    this.Shift4(11, 10, 8, 9);
                    break;
                case 10:
                    this.Shift4(7, 19, 15, 11);
                    this.Shift4(6, 18, 14, 10);
                    this.Shift4(20, 22, 23, 21);
                    break;
                case 11:
                    this.Shift4(5, 17, 13, 9);
                    this.Shift4(4, 16, 12, 8);
                    this.Shift4(2, 0, 1, 3);
                    break;
            }
        }

        /// <summary>
        /// 見る角度を変えます。
        /// </summary>
        /// <param name="handle">回転箇所。</param>
        public void RotateView(int handle)
        {
            switch (handle)
            {
                case 0:

                    // +Y
                    this.RotateOnly(0);
                    this.RotateOnly(1);
                    break;
                case 1:

                    // +Z
                    this.RotateOnly(2);
                    this.RotateOnly(3);
                    break;
                case 2:

                    // +X
                    this.RotateOnly(4);
                    this.RotateOnly(5);
                    break;
                case 3:

                    // -Y
                    this.RotateOnly(6);
                    this.RotateOnly(7);
                    break;
                case 4:

                    // -Z
                    this.RotateOnly(8);
                    this.RotateOnly(9);
                    break;
                case 5:

                    // -X
                    this.RotateOnly(10);
                    this.RotateOnly(11);
                    break;
            }
        }
    }
}
