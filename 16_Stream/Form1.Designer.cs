namespace _16_Stream
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tboxConfigData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxData = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.btnConfigRead = new System.Windows.Forms.Button();
            this.btnConfigSet = new System.Windows.Forms.Button();
            this.SFDialog = new System.Windows.Forms.SaveFileDialog();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(53, 41);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(197, 39);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Text 읽어오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Text 저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboxConfigData
            // 
            this.tboxConfigData.Enabled = false;
            this.tboxConfigData.Location = new System.Drawing.Point(53, 86);
            this.tboxConfigData.Multiline = true;
            this.tboxConfigData.Name = "tboxConfigData";
            this.tboxConfigData.Size = new System.Drawing.Size(420, 154);
            this.tboxConfigData.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numData);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.tboxData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Text : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "3. Number : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Check Box :";
            // 
            // tboxData
            // 
            this.tboxData.Location = new System.Drawing.Point(102, 33);
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(139, 21);
            this.tboxData.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.checkBox1.Location = new System.Drawing.Point(155, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "cb1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numData
            // 
            this.numData.Location = new System.Drawing.Point(131, 105);
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(110, 21);
            this.numData.TabIndex = 5;
            // 
            // btnConfigRead
            // 
            this.btnConfigRead.Location = new System.Drawing.Point(53, 425);
            this.btnConfigRead.Name = "btnConfigRead";
            this.btnConfigRead.Size = new System.Drawing.Size(197, 39);
            this.btnConfigRead.TabIndex = 4;
            this.btnConfigRead.Text = "Config 가져오기";
            this.btnConfigRead.UseVisualStyleBackColor = true;
            this.btnConfigRead.Click += new System.EventHandler(this.btnConfigRead_Click);
            // 
            // btnConfigSet
            // 
            this.btnConfigSet.Location = new System.Drawing.Point(276, 425);
            this.btnConfigSet.Name = "btnConfigSet";
            this.btnConfigSet.Size = new System.Drawing.Size(197, 39);
            this.btnConfigSet.TabIndex = 5;
            this.btnConfigSet.Text = "Config 설정하기";
            this.btnConfigSet.UseVisualStyleBackColor = true;
            this.btnConfigSet.Click += new System.EventHandler(this.btnConfigSet_Click);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 507);
            this.Controls.Add(this.btnConfigSet);
            this.Controls.Add(this.btnConfigRead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxConfigData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tboxConfigData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numData;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigRead;
        private System.Windows.Forms.Button btnConfigSet;
        private System.Windows.Forms.SaveFileDialog SFDialog;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}

