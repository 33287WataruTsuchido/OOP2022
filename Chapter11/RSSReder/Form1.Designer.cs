
namespace RSSReder {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btRSSget = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btForward = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.wvBrower = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrower)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(22, 21);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(513, 20);
            this.cbRssUrl.TabIndex = 0;
            // 
            // btRSSget
            // 
            this.btRSSget.Location = new System.Drawing.Point(541, 18);
            this.btRSSget.Name = "btRSSget";
            this.btRSSget.Size = new System.Drawing.Size(75, 23);
            this.btRSSget.TabIndex = 1;
            this.btRSSget.Text = "取得";
            this.btRSSget.UseVisualStyleBackColor = true;
            this.btRSSget.Click += new System.EventHandler(this.btRSSget_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(22, 47);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(146, 520);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(703, 21);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(68, 22);
            this.btForward.TabIndex = 4;
            this.btForward.Text = "→";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(622, 20);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // wvBrower
            // 
            this.wvBrower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wvBrower.Location = new System.Drawing.Point(174, 47);
            this.wvBrower.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrower.Name = "wvBrower";
            this.wvBrower.Size = new System.Drawing.Size(389, 499);
            this.wvBrower.TabIndex = 6;
            this.wvBrower.DOMContentLoaded += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(this.wvBrower_DOMContentLoaded);
            this.wvBrower.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrower_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 728);
            this.Controls.Add(this.wvBrower);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btRSSget);
            this.Controls.Add(this.cbRssUrl);
            this.Name = "Form1";
            this.Text = "RSSReder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btRSSget;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrower;
    }
}

