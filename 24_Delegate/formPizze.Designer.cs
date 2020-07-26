namespace _24_Delegate
{
    partial class formPizze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntClose = new System.Windows.Forms.Button();
            this.lboxMake = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(252, 197);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(89, 31);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "닫기";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // lboxMake
            // 
            this.lboxMake.FormattingEnabled = true;
            this.lboxMake.ItemHeight = 15;
            this.lboxMake.Location = new System.Drawing.Point(44, 38);
            this.lboxMake.Name = "lboxMake";
            this.lboxMake.Size = new System.Drawing.Size(297, 139);
            this.lboxMake.TabIndex = 1;
            // 
            // formPizze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 266);
            this.Controls.Add(this.lboxMake);
            this.Controls.Add(this.bntClose);
            this.Name = "formPizze";
            this.Text = "formPizze";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.ListBox lboxMake;
    }
}