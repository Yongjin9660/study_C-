namespace _23_DataTable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxRegClass = new System.Windows.Forms.ComboBox();
            this.tboxRegName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoRegSexMale = new System.Windows.Forms.RadioButton();
            this.rdoRegSexFeMale = new System.Windows.Forms.RadioButton();
            this.tboxRegRef = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxViewClass = new System.Windows.Forms.ComboBox();
            this.dgViewInfo = new System.Windows.Forms.DataGridView();
            this.btnViewDataDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록하기";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tboxRegRef, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxRegName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboxRegClass, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "반 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "성별 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "특기 : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxRegClass
            // 
            this.cboxRegClass.FormattingEnabled = true;
            this.cboxRegClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxRegClass.Location = new System.Drawing.Point(73, 3);
            this.cboxRegClass.Name = "cboxRegClass";
            this.cboxRegClass.Size = new System.Drawing.Size(240, 20);
            this.cboxRegClass.TabIndex = 7;
            // 
            // tboxRegName
            // 
            this.tboxRegName.Location = new System.Drawing.Point(73, 35);
            this.tboxRegName.Multiline = true;
            this.tboxRegName.Name = "tboxRegName";
            this.tboxRegName.Size = new System.Drawing.Size(140, 24);
            this.tboxRegName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoRegSexFeMale);
            this.panel1.Controls.Add(this.rdoRegSexMale);
            this.panel1.Location = new System.Drawing.Point(73, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 26);
            this.panel1.TabIndex = 9;
            // 
            // rdoRegSexMale
            // 
            this.rdoRegSexMale.AutoSize = true;
            this.rdoRegSexMale.Location = new System.Drawing.Point(19, 10);
            this.rdoRegSexMale.Name = "rdoRegSexMale";
            this.rdoRegSexMale.Size = new System.Drawing.Size(47, 16);
            this.rdoRegSexMale.TabIndex = 0;
            this.rdoRegSexMale.TabStop = true;
            this.rdoRegSexMale.Text = "남자";
            this.rdoRegSexMale.UseVisualStyleBackColor = true;
            // 
            // rdoRegSexFeMale
            // 
            this.rdoRegSexFeMale.AutoSize = true;
            this.rdoRegSexFeMale.Location = new System.Drawing.Point(164, 10);
            this.rdoRegSexFeMale.Name = "rdoRegSexFeMale";
            this.rdoRegSexFeMale.Size = new System.Drawing.Size(47, 16);
            this.rdoRegSexFeMale.TabIndex = 1;
            this.rdoRegSexFeMale.TabStop = true;
            this.rdoRegSexFeMale.Text = "여자";
            this.rdoRegSexFeMale.UseVisualStyleBackColor = true;
            // 
            // tboxRegRef
            // 
            this.tboxRegRef.Location = new System.Drawing.Point(73, 99);
            this.tboxRegRef.Name = "tboxRegRef";
            this.tboxRegRef.Size = new System.Drawing.Size(240, 21);
            this.tboxRegRef.TabIndex = 10;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(256, 163);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(89, 33);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewDataDel);
            this.groupBox2.Controls.Add(this.dgViewInfo);
            this.groupBox2.Controls.Add(this.cboxViewClass);
            this.groupBox2.Location = new System.Drawing.Point(26, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내용 확인";
            // 
            // cboxViewClass
            // 
            this.cboxViewClass.FormattingEnabled = true;
            this.cboxViewClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxViewClass.Location = new System.Drawing.Point(16, 41);
            this.cboxViewClass.Name = "cboxViewClass";
            this.cboxViewClass.Size = new System.Drawing.Size(103, 20);
            this.cboxViewClass.TabIndex = 0;
            this.cboxViewClass.SelectedIndexChanged += new System.EventHandler(this.cboxViewClass_SelectedIndexChanged);
            // 
            // dgViewInfo
            // 
            this.dgViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewInfo.Location = new System.Drawing.Point(16, 78);
            this.dgViewInfo.Name = "dgViewInfo";
            this.dgViewInfo.RowTemplate.Height = 23;
            this.dgViewInfo.Size = new System.Drawing.Size(531, 150);
            this.dgViewInfo.TabIndex = 1;
            // 
            // btnViewDataDel
            // 
            this.btnViewDataDel.Location = new System.Drawing.Point(449, 31);
            this.btnViewDataDel.Name = "btnViewDataDel";
            this.btnViewDataDel.Size = new System.Drawing.Size(98, 30);
            this.btnViewDataDel.TabIndex = 2;
            this.btnViewDataDel.Text = "삭제";
            this.btnViewDataDel.UseVisualStyleBackColor = true;
            this.btnViewDataDel.Click += new System.EventHandler(this.btnViewDataDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tboxRegRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoRegSexFeMale;
        private System.Windows.Forms.RadioButton rdoRegSexMale;
        private System.Windows.Forms.TextBox tboxRegName;
        private System.Windows.Forms.ComboBox cboxRegClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViewDataDel;
        private System.Windows.Forms.DataGridView dgViewInfo;
        private System.Windows.Forms.ComboBox cboxViewClass;
    }
}

