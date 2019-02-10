﻿namespace Grayscale.Cube2X2Test
{
    using System.Drawing;
    using System.Windows.Forms;
    using Grayscale.Commons;

    /// <summary>
    /// 展開図コントロール。
    /// </summary>
    public partial class DevelopmentUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentUserControl"/> class.
        /// </summary>
        public DevelopmentUserControl()
        {
            this.InitializeComponent();
            this.DevelopmentPosition = new DevelopmentPosition(new Panel[]
            {
                this.tile0,
                this.tile1,
                this.tile2,
                this.tile3,
                this.tile4,
                this.tile5,
                this.tile6,
                this.tile7,
                this.tile8,
                this.tile9,
                this.tile10,
                this.tile11,
                this.tile12,
                this.tile13,
                this.tile14,
                this.tile15,
                this.tile16,
                this.tile17,
                this.tile18,
                this.tile19,
                this.tile20,
                this.tile21,
                this.tile22,
                this.tile23,
            });
        }

        /// <summary>
        /// Gets or sets 展開図ユーザーコントロール。
        /// </summary>
        public DevelopmentPosition DevelopmentPosition { get; set; }

        /// <summary>
        /// Gets 盤面を、文字列で返す。
        /// </summary>
        /// <returns>局面</returns>
        public string BoardText
        {
            get
            {
                return this.DevelopmentPosition.BoardText;
            }
        }

        /// <summary>
        /// 局面を設定します。
        /// </summary>
        /// <param name="position">局面文字列。</param>
        public void SetPosition(string position)
        {
            this.DevelopmentPosition.SetPosition(position);
        }

        /// <summary>
        /// 90度回転。4つのタイルを、１つずらします。
        /// </summary>
        /// <param name="titleA">タイル1。</param>
        /// <param name="titleB">タイル2。</param>
        /// <param name="titleC">タイル3。</param>
        /// <param name="titleD">タイル4。</param>
        public void Shift4(int titleA, int titleB, int titleC, int titleD)
        {
            // 展開図
            this.DevelopmentPosition.Shift4(titleA, titleB, titleC, titleD);
        }

        /// <summary>
        /// キューブを 90° ひねります。
        /// </summary>
        /// <param name="handle">回転箇所。</param>
        public void RotateOnly(int handle)
        {
            this.DevelopmentPosition.RotateOnly(handle);
        }
    }
}
