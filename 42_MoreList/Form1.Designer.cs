namespace _42_MoreList
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
            this.tboxData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lboxNo = new System.Windows.Forms.ListBox();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.tboxChangeOld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxChangeNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.lboxChangeList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxList = new System.Windows.Forms.TextBox();
            this.tboxChangeList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // tboxData
            // 
            this.tboxData.Location = new System.Drawing.Point(81, 25);
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(139, 21);
            this.tboxData.TabIndex = 1;
            this.tboxData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxData_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(81, 67);
            this.numPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(139, 21);
            this.numPosition.TabIndex = 3;
            this.numPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(130, 112);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 22);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "List";
            // 
            // lboxNo
            // 
            this.lboxNo.Enabled = false;
            this.lboxNo.FormattingEnabled = true;
            this.lboxNo.ItemHeight = 12;
            this.lboxNo.Location = new System.Drawing.Point(27, 187);
            this.lboxNo.Name = "lboxNo";
            this.lboxNo.Size = new System.Drawing.Size(48, 208);
            this.lboxNo.TabIndex = 7;
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 12;
            this.lboxList.Location = new System.Drawing.Point(81, 187);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(139, 208);
            this.lboxList.TabIndex = 8;
            // 
            // tboxChangeOld
            // 
            this.tboxChangeOld.Location = new System.Drawing.Point(286, 25);
            this.tboxChangeOld.Name = "tboxChangeOld";
            this.tboxChangeOld.Size = new System.Drawing.Size(139, 21);
            this.tboxChangeOld.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "검색";
            // 
            // tboxChangeNew
            // 
            this.tboxChangeNew.Location = new System.Drawing.Point(286, 69);
            this.tboxChangeNew.Name = "tboxChangeNew";
            this.tboxChangeNew.Size = new System.Drawing.Size(139, 21);
            this.tboxChangeNew.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "수정";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(335, 112);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 22);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lboxChangeList
            // 
            this.lboxChangeList.FormattingEnabled = true;
            this.lboxChangeList.ItemHeight = 12;
            this.lboxChangeList.Location = new System.Drawing.Point(286, 187);
            this.lboxChangeList.Name = "lboxChangeList";
            this.lboxChangeList.Size = new System.Drawing.Size(139, 208);
            this.lboxChangeList.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "List Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "ChangeList Detail";
            // 
            // tboxList
            // 
            this.tboxList.Enabled = false;
            this.tboxList.Location = new System.Drawing.Point(472, 43);
            this.tboxList.Multiline = true;
            this.tboxList.Name = "tboxList";
            this.tboxList.Size = new System.Drawing.Size(213, 157);
            this.tboxList.TabIndex = 17;
            // 
            // tboxChangeList
            // 
            this.tboxChangeList.Enabled = false;
            this.tboxChangeList.Location = new System.Drawing.Point(472, 238);
            this.tboxChangeList.Multiline = true;
            this.tboxChangeList.Name = "tboxChangeList";
            this.tboxChangeList.Size = new System.Drawing.Size(213, 157);
            this.tboxChangeList.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(442, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 296);
            this.panel1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 10);
            this.label8.TabIndex = 20;
            this.label8.Text = "ChangeList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 421);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tboxChangeList);
            this.Controls.Add(this.tboxList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lboxChangeList);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tboxChangeNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxChangeOld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.lboxNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxNo;
        private System.Windows.Forms.ListBox lboxList;
        private System.Windows.Forms.TextBox tboxChangeOld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxChangeNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lboxChangeList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxList;
        private System.Windows.Forms.TextBox tboxChangeList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}

