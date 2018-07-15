namespace TabCap
{
    partial class FrmTabCap
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
            this.btnPaste = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveFocusedTab = new System.Windows.Forms.Button();
            this.btnSaveAllTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaste.Location = new System.Drawing.Point(3, 64);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste(&D)";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 55);
            this.tabControl1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(84, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete(&W)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveFocusedTab
            // 
            this.btnSaveFocusedTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveFocusedTab.Location = new System.Drawing.Point(165, 64);
            this.btnSaveFocusedTab.Name = "btnSaveFocusedTab";
            this.btnSaveFocusedTab.Size = new System.Drawing.Size(126, 23);
            this.btnSaveFocusedTab.TabIndex = 4;
            this.btnSaveFocusedTab.Text = "Save focused tab(&S)";
            this.btnSaveFocusedTab.UseVisualStyleBackColor = true;
            this.btnSaveFocusedTab.Click += new System.EventHandler(this.btnSaveFocusedTab_Click);
            // 
            // btnSaveAllTab
            // 
            this.btnSaveAllTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAllTab.Location = new System.Drawing.Point(297, 64);
            this.btnSaveAllTab.Name = "btnSaveAllTab";
            this.btnSaveAllTab.Size = new System.Drawing.Size(107, 23);
            this.btnSaveAllTab.TabIndex = 5;
            this.btnSaveAllTab.Text = "Save all tab(&A)";
            this.btnSaveAllTab.UseVisualStyleBackColor = true;
            this.btnSaveAllTab.Click += new System.EventHandler(this.btnSaveAllTab_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btnSaveAllTab);
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Controls.Add(this.btnSaveFocusedTab);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 90);
            this.panel1.TabIndex = 6;
            // 
            // frmTabCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 114);
            this.Controls.Add(this.panel1);
            this.Name = "frmTabCap";
            this.Text = "TabCap";
            this.Load += new System.EventHandler(this.frmTabCap_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveFocusedTab;
        private System.Windows.Forms.Button btnSaveAllTab;
        private System.Windows.Forms.Panel panel1;
    }
}

