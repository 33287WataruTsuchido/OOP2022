
namespace WeatherApp
{
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
            this.tbAreaInfo = new System.Windows.Forms.TextBox();
            this.btGetWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbWeather1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbHokkaidou = new System.Windows.Forms.ComboBox();
            this.cbTouhoku = new System.Windows.Forms.ComboBox();
            this.cbKanntou = new System.Windows.Forms.ComboBox();
            this.cbChuubu = new System.Windows.Forms.ComboBox();
            this.cbKyuushuu = new System.Windows.Forms.ComboBox();
            this.cbShikoku = new System.Windows.Forms.ComboBox();
            this.cbKannsai = new System.Windows.Forms.ComboBox();
            this.cbChuugoku = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.cbOkinawa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbWeather3 = new System.Windows.Forms.PictureBox();
            this.pbWeather2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWeather1 = new System.Windows.Forms.TextBox();
            this.tbWeather2 = new System.Windows.Forms.TextBox();
            this.tbWeather3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAreaInfo
            // 
            this.tbAreaInfo.Location = new System.Drawing.Point(821, 285);
            this.tbAreaInfo.Multiline = true;
            this.tbAreaInfo.Name = "tbAreaInfo";
            this.tbAreaInfo.Size = new System.Drawing.Size(296, 175);
            this.tbAreaInfo.TabIndex = 0;
            // 
            // btGetWeather
            // 
            this.btGetWeather.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGetWeather.Location = new System.Drawing.Point(697, 342);
            this.btGetWeather.Name = "btGetWeather";
            this.btGetWeather.Size = new System.Drawing.Size(78, 31);
            this.btGetWeather.TabIndex = 1;
            this.btGetWeather.Text = "取得";
            this.btGetWeather.UseVisualStyleBackColor = true;
            this.btGetWeather.Click += new System.EventHandler(this.btGetWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(692, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "天気概況";
            // 
            // pbWeather1
            // 
            this.pbWeather1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbWeather1.Location = new System.Drawing.Point(697, 86);
            this.pbWeather1.Name = "pbWeather1";
            this.pbWeather1.Size = new System.Drawing.Size(117, 108);
            this.pbWeather1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeather1.TabIndex = 5;
            this.pbWeather1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.日本地図;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cbHokkaidou
            // 
            this.cbHokkaidou.FormattingEnabled = true;
            this.cbHokkaidou.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "十勝地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方"});
            this.cbHokkaidou.Location = new System.Drawing.Point(556, 86);
            this.cbHokkaidou.Name = "cbHokkaidou";
            this.cbHokkaidou.Size = new System.Drawing.Size(76, 20);
            this.cbHokkaidou.TabIndex = 8;
            this.cbHokkaidou.Text = "北海道";
            // 
            // cbTouhoku
            // 
            this.cbTouhoku.FormattingEnabled = true;
            this.cbTouhoku.Items.AddRange(new object[] {
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県"});
            this.cbTouhoku.Location = new System.Drawing.Point(487, 210);
            this.cbTouhoku.Name = "cbTouhoku";
            this.cbTouhoku.Size = new System.Drawing.Size(75, 20);
            this.cbTouhoku.TabIndex = 8;
            this.cbTouhoku.Text = "東北地方";
            // 
            // cbKanntou
            // 
            this.cbKanntou.FormattingEnabled = true;
            this.cbKanntou.Items.AddRange(new object[] {
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県"});
            this.cbKanntou.Location = new System.Drawing.Point(434, 304);
            this.cbKanntou.Name = "cbKanntou";
            this.cbKanntou.Size = new System.Drawing.Size(75, 20);
            this.cbKanntou.TabIndex = 8;
            this.cbKanntou.Text = "関東地方";
            // 
            // cbChuubu
            // 
            this.cbChuubu.FormattingEnabled = true;
            this.cbChuubu.Items.AddRange(new object[] {
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県"});
            this.cbChuubu.Location = new System.Drawing.Point(316, 255);
            this.cbChuubu.Name = "cbChuubu";
            this.cbChuubu.Size = new System.Drawing.Size(76, 20);
            this.cbChuubu.TabIndex = 8;
            this.cbChuubu.Text = "中部地方";
            // 
            // cbKyuushuu
            // 
            this.cbKyuushuu.FormattingEnabled = true;
            this.cbKyuushuu.Items.AddRange(new object[] {
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県"});
            this.cbKyuushuu.Location = new System.Drawing.Point(49, 433);
            this.cbKyuushuu.Name = "cbKyuushuu";
            this.cbKyuushuu.Size = new System.Drawing.Size(76, 20);
            this.cbKyuushuu.TabIndex = 8;
            this.cbKyuushuu.Text = "九州地方";
            // 
            // cbShikoku
            // 
            this.cbShikoku.FormattingEnabled = true;
            this.cbShikoku.Items.AddRange(new object[] {
            "香川県",
            "徳島県",
            "愛媛県",
            "高知県"});
            this.cbShikoku.Location = new System.Drawing.Point(141, 390);
            this.cbShikoku.Name = "cbShikoku";
            this.cbShikoku.Size = new System.Drawing.Size(76, 20);
            this.cbShikoku.TabIndex = 8;
            this.cbShikoku.Text = "四国地方";
            // 
            // cbKannsai
            // 
            this.cbKannsai.FormattingEnabled = true;
            this.cbKannsai.Items.AddRange(new object[] {
            "三重県",
            "佐賀県",
            "大阪府",
            "京都府",
            "兵庫県",
            "奈良県",
            "和歌山県"});
            this.cbKannsai.Location = new System.Drawing.Point(300, 342);
            this.cbKannsai.Name = "cbKannsai";
            this.cbKannsai.Size = new System.Drawing.Size(76, 20);
            this.cbKannsai.TabIndex = 8;
            this.cbKannsai.Text = "関西地方";
            // 
            // cbChuugoku
            // 
            this.cbChuugoku.FormattingEnabled = true;
            this.cbChuugoku.Items.AddRange(new object[] {
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "山口県"});
            this.cbChuugoku.Location = new System.Drawing.Point(60, 330);
            this.cbChuugoku.Name = "cbChuugoku";
            this.cbChuugoku.Size = new System.Drawing.Size(76, 20);
            this.cbChuugoku.TabIndex = 8;
            this.cbChuugoku.Text = "中国地方";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(692, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "現在時刻";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(697, 379);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(78, 31);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // cbOkinawa
            // 
            this.cbOkinawa.FormattingEnabled = true;
            this.cbOkinawa.Items.AddRange(new object[] {
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
            this.cbOkinawa.Location = new System.Drawing.Point(278, 440);
            this.cbOkinawa.Name = "cbOkinawa";
            this.cbOkinawa.Size = new System.Drawing.Size(76, 20);
            this.cbOkinawa.TabIndex = 8;
            this.cbOkinawa.Text = "沖縄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(693, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "‐";
            // 
            // pbWeather3
            // 
            this.pbWeather3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbWeather3.Location = new System.Drawing.Point(996, 86);
            this.pbWeather3.Name = "pbWeather3";
            this.pbWeather3.Size = new System.Drawing.Size(117, 108);
            this.pbWeather3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeather3.TabIndex = 5;
            this.pbWeather3.TabStop = false;
            // 
            // pbWeather2
            // 
            this.pbWeather2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbWeather2.Location = new System.Drawing.Point(849, 86);
            this.pbWeather2.Name = "pbWeather2";
            this.pbWeather2.Size = new System.Drawing.Size(117, 108);
            this.pbWeather2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeather2.TabIndex = 5;
            this.pbWeather2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(845, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "‐";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(992, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "‐";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(845, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "‐";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(845, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "‐";
            // 
            // tbWeather1
            // 
            this.tbWeather1.Location = new System.Drawing.Point(697, 61);
            this.tbWeather1.Name = "tbWeather1";
            this.tbWeather1.Size = new System.Drawing.Size(117, 19);
            this.tbWeather1.TabIndex = 10;
            // 
            // tbWeather2
            // 
            this.tbWeather2.Location = new System.Drawing.Point(849, 61);
            this.tbWeather2.Name = "tbWeather2";
            this.tbWeather2.Size = new System.Drawing.Size(117, 19);
            this.tbWeather2.TabIndex = 10;
            // 
            // tbWeather3
            // 
            this.tbWeather3.Location = new System.Drawing.Point(996, 61);
            this.tbWeather3.Name = "tbWeather3";
            this.tbWeather3.Size = new System.Drawing.Size(118, 19);
            this.tbWeather3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(692, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "発表者";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 478);
            this.Controls.Add(this.tbWeather3);
            this.Controls.Add(this.tbWeather2);
            this.Controls.Add(this.tbWeather1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChuugoku);
            this.Controls.Add(this.cbKannsai);
            this.Controls.Add(this.cbShikoku);
            this.Controls.Add(this.cbOkinawa);
            this.Controls.Add(this.cbKyuushuu);
            this.Controls.Add(this.cbChuubu);
            this.Controls.Add(this.cbKanntou);
            this.Controls.Add(this.cbTouhoku);
            this.Controls.Add(this.cbHokkaidou);
            this.Controls.Add(this.pbWeather3);
            this.Controls.Add(this.pbWeather2);
            this.Controls.Add(this.pbWeather1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btGetWeather);
            this.Controls.Add(this.tbAreaInfo);
            this.Name = "Form1";
            this.Text = "天気情報取得アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAreaInfo;
        private System.Windows.Forms.Button btGetWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbWeather1;
        private System.Windows.Forms.ComboBox cbHokkaidou;
        private System.Windows.Forms.ComboBox cbTouhoku;
        private System.Windows.Forms.ComboBox cbKanntou;
        private System.Windows.Forms.ComboBox cbChuubu;
        private System.Windows.Forms.ComboBox cbKyuushuu;
        private System.Windows.Forms.ComboBox cbShikoku;
        private System.Windows.Forms.ComboBox cbKannsai;
        private System.Windows.Forms.ComboBox cbChuugoku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cbOkinawa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbWeather3;
        private System.Windows.Forms.PictureBox pbWeather2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWeather1;
        private System.Windows.Forms.TextBox tbWeather2;
        private System.Windows.Forms.TextBox tbWeather3;
        private System.Windows.Forms.Label label9;
    }
}

