namespace lambda_sample
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAddAnswer = new System.Windows.Forms.Label();
            this.LblSubAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.LblGuide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "デリゲート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "匿名関数";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "ラムダ式";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "定義済デリゲート";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(25, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "10+20=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "10-20=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAddAnswer
            // 
            this.LblAddAnswer.BackColor = System.Drawing.Color.White;
            this.LblAddAnswer.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblAddAnswer.Location = new System.Drawing.Point(136, 273);
            this.LblAddAnswer.Name = "LblAddAnswer";
            this.LblAddAnswer.Size = new System.Drawing.Size(54, 27);
            this.LblAddAnswer.TabIndex = 7;
            this.LblAddAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubAnswer
            // 
            this.LblSubAnswer.BackColor = System.Drawing.Color.White;
            this.LblSubAnswer.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblSubAnswer.Location = new System.Drawing.Point(136, 315);
            this.LblSubAnswer.Name = "LblSubAnswer";
            this.LblSubAnswer.Size = new System.Drawing.Size(54, 27);
            this.LblSubAnswer.TabIndex = 8;
            this.LblSubAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 684);
            this.label1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "定義済デリゲート";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LblGuide
            // 
            this.LblGuide.BackColor = System.Drawing.Color.White;
            this.LblGuide.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblGuide.ForeColor = System.Drawing.Color.Silver;
            this.LblGuide.Location = new System.Drawing.Point(522, 315);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(246, 120);
            this.LblGuide.TabIndex = 11;
            this.LblGuide.Text = "ソースが表示されます";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 705);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSubAnswer);
            this.Controls.Add(this.LblAddAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "デリゲート -> 匿名関数 -> 定義済みデリゲート -> ラムダ式まで";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAddAnswer;
        private System.Windows.Forms.Label LblSubAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label LblGuide;
    }
}

