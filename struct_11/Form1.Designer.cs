namespace struct_11
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.none = new System.Windows.Forms.PictureBox();
            this.star = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.sun = new System.Windows.Forms.PictureBox();
            this.radioPlayer1 = new System.Windows.Forms.RadioButton();
            this.radioPlayer2 = new System.Windows.Forms.RadioButton();
            this.result2 = new System.Windows.Forms.ListBox();
            this.result1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.none)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Player는 한번씩 돌아가면서 그림을 선택합니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "- 각 5회 진행 후, 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리합니다.";
            // 
            // none
            // 
            this.none.BackColor = System.Drawing.SystemColors.ControlDark;
            this.none.Location = new System.Drawing.Point(701, 104);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(152, 164);
            this.none.TabIndex = 5;
            this.none.TabStop = false;
            this.none.Click += new System.EventHandler(this.none_Click);
            // 
            // star
            // 
            this.star.Image = global::struct_11.Properties.Resources._3;
            this.star.Location = new System.Drawing.Point(491, 104);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(152, 164);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star.TabIndex = 4;
            this.star.TabStop = false;
            this.star.Click += new System.EventHandler(this.star_Click);
            // 
            // moon
            // 
            this.moon.Image = global::struct_11.Properties.Resources._2;
            this.moon.Location = new System.Drawing.Point(278, 104);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(152, 164);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 3;
            this.moon.TabStop = false;
            this.moon.Click += new System.EventHandler(this.moon_Click);
            // 
            // sun
            // 
            this.sun.Image = global::struct_11.Properties.Resources._1;
            this.sun.Location = new System.Drawing.Point(65, 104);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(140, 164);
            this.sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sun.TabIndex = 2;
            this.sun.TabStop = false;
            this.sun.Click += new System.EventHandler(this.sun_Click);
            // 
            // radioPlayer1
            // 
            this.radioPlayer1.AutoSize = true;
            this.radioPlayer1.Location = new System.Drawing.Point(120, 299);
            this.radioPlayer1.Name = "radioPlayer1";
            this.radioPlayer1.Size = new System.Drawing.Size(65, 16);
            this.radioPlayer1.TabIndex = 6;
            this.radioPlayer1.TabStop = true;
            this.radioPlayer1.Text = "Player1";
            this.radioPlayer1.UseVisualStyleBackColor = true;
            // 
            // radioPlayer2
            // 
            this.radioPlayer2.AutoSize = true;
            this.radioPlayer2.Location = new System.Drawing.Point(491, 299);
            this.radioPlayer2.Name = "radioPlayer2";
            this.radioPlayer2.Size = new System.Drawing.Size(65, 16);
            this.radioPlayer2.TabIndex = 7;
            this.radioPlayer2.TabStop = true;
            this.radioPlayer2.Text = "Player1";
            this.radioPlayer2.UseVisualStyleBackColor = true;
            // 
            // result2
            // 
            this.result2.FormattingEnabled = true;
            this.result2.ItemHeight = 12;
            this.result2.Location = new System.Drawing.Point(491, 344);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(259, 124);
            this.result2.TabIndex = 9;
            // 
            // result1
            // 
            this.result1.FormattingEnabled = true;
            this.result1.ItemHeight = 12;
            this.result1.Location = new System.Drawing.Point(120, 344);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(259, 124);
            this.result1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 526);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.radioPlayer2);
            this.Controls.Add(this.radioPlayer1);
            this.Controls.Add(this.none);
            this.Controls.Add(this.star);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.none)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox sun;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.PictureBox none;
        private System.Windows.Forms.RadioButton radioPlayer1;
        private System.Windows.Forms.RadioButton radioPlayer2;
        private System.Windows.Forms.ListBox result2;
        private System.Windows.Forms.ListBox result1;
    }
}

