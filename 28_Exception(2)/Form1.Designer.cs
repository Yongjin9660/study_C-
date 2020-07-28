namespace _28_Exception_2_
{
    partial class lboxColor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pColor = new System.Windows.Forms.Panel();
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnColorSave = new System.Windows.Forms.Button();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColorInfo);
            this.groupBox1.Controls.Add(this.tbarAlpha);
            this.groupBox1.Controls.Add(this.pColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alpha : ";
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(69, 20);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(27, 23);
            this.pColor.TabIndex = 3;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(69, 65);
            this.tbarAlpha.Maximum = 255;
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(92, 45);
            this.tbarAlpha.TabIndex = 4;
            this.tbarAlpha.Value = 255;
            this.tbarAlpha.Scroll += new System.EventHandler(this.tbarAlpha_Scroll);
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(85, 133);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(11, 12);
            this.lblColorInfo.TabIndex = 5;
            this.lblColorInfo.Text = "-";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(22, 259);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 160);
            this.listBox1.TabIndex = 1;
            // 
            // btnColorSave
            // 
            this.btnColorSave.Location = new System.Drawing.Point(136, 208);
            this.btnColorSave.Name = "btnColorSave";
            this.btnColorSave.Size = new System.Drawing.Size(102, 34);
            this.btnColorSave.TabIndex = 2;
            this.btnColorSave.Text = "저장";
            this.btnColorSave.UseVisualStyleBackColor = true;
            this.btnColorSave.Click += new System.EventHandler(this.btnColorSave_Click);
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.Location = new System.Drawing.Point(244, 208);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(102, 34);
            this.btnColorDelete.TabIndex = 3;
            this.btnColorDelete.Text = "삭제";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(397, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 398);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(29, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 71);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(120, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 205);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(65, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 71);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(300, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 236);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(156, 228);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 81);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(214, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(66, 154);
            this.panel7.TabIndex = 4;
            // 
            // lboxColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColorDelete);
            this.Controls.Add(this.btnColorSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "lboxColor";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnColorSave;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

