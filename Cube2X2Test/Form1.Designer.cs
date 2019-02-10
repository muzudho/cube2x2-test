namespace Grayscale.Cube2X2Test
{
    /// <summary>
    /// 2x2のキューブ。
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.normalizationUserControl1 = new Grayscale.Cube2X2Test.NormalizationUserControl();
            this.SuspendLayout();
            // 
            // normalizationUserControl1
            // 
            this.normalizationUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalizationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.normalizationUserControl1.Name = "normalizationUserControl1";
            this.normalizationUserControl1.Size = new System.Drawing.Size(1500, 757);
            this.normalizationUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 757);
            this.Controls.Add(this.normalizationUserControl1);
            this.Name = "Form1";
            this.Text = "2x2キューブ";
            this.ResumeLayout(false);

        }

        #endregion

        private NormalizationUserControl normalizationUserControl1;
    }
}

