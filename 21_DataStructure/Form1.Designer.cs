namespace _21_DataStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "※ 선호하는 항목을 선택해주세요";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 179);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPick4
            // 
            this.lblPick4.AutoSize = true;
            this.lblPick4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPick4.Location = new System.Drawing.Point(458, 151);
            this.lblPick4.Margin = new System.Windows.Forms.Padding(2);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(149, 26);
            this.lblPick4.TabIndex = 9;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.AutoSize = true;
            this.lblPick3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPick3.Location = new System.Drawing.Point(306, 151);
            this.lblPick3.Margin = new System.Windows.Forms.Padding(2);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(148, 26);
            this.lblPick3.TabIndex = 8;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.AutoSize = true;
            this.lblPick2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPick2.Location = new System.Drawing.Point(154, 151);
            this.lblPick2.Margin = new System.Windows.Forms.Padding(2);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(148, 26);
            this.lblPick2.TabIndex = 7;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPick1.Location = new System.Drawing.Point(2, 151);
            this.lblPick1.Margin = new System.Windows.Forms.Padding(2);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(148, 26);
            this.lblPick1.TabIndex = 6;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox4
            // 
            this.pBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox4.Image = ((System.Drawing.Image)(resources.GetObject("pBox4.Image")));
            this.pBox4.Location = new System.Drawing.Point(456, 0);
            this.pBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(153, 149);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox4.TabIndex = 3;
            this.pBox4.TabStop = false;
            this.pBox4.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox3
            // 
            this.pBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox3.Image = ((System.Drawing.Image)(resources.GetObject("pBox3.Image")));
            this.pBox3.Location = new System.Drawing.Point(304, 0);
            this.pBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(152, 149);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 2;
            this.pBox3.TabStop = false;
            this.pBox3.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox2
            // 
            this.pBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox2.Image = ((System.Drawing.Image)(resources.GetObject("pBox2.Image")));
            this.pBox2.Location = new System.Drawing.Point(152, 0);
            this.pBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(152, 149);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 1;
            this.pBox2.TabStop = false;
            this.pBox2.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox1
            // 
            this.pBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox1.Image = global::_21_DataStructure.Properties.Resources._1;
            this.pBox1.Location = new System.Drawing.Point(0, 0);
            this.pBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(152, 149);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            this.pBox1.Click += new System.EventHandler(this.pBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Count :";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("굴림", 12F);
            this.lblTotalCount.Location = new System.Drawing.Point(121, 255);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(16, 16);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "※ List의 Data를 화면에 보여줍니다.";
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(153, 324);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 23;
            this.dgViewList.Size = new System.Drawing.Size(350, 235);
            this.dgViewList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 571);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgViewList;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick1;
    }
}

