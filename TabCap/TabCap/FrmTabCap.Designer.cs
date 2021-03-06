﻿namespace TabCap
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveFocusedTab = new System.Windows.Forms.Button();
            this.btnSaveAllTab = new System.Windows.Forms.Button();
            this.pnlTab = new System.Windows.Forms.Panel();
            this.btnReadCap = new System.Windows.Forms.Button();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.pnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaste.Location = new System.Drawing.Point(3, 4);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste(&D)";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(84, 4);
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
            this.btnSaveFocusedTab.Location = new System.Drawing.Point(165, 4);
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
            this.btnSaveAllTab.Location = new System.Drawing.Point(297, 4);
            this.btnSaveAllTab.Name = "btnSaveAllTab";
            this.btnSaveAllTab.Size = new System.Drawing.Size(107, 23);
            this.btnSaveAllTab.TabIndex = 5;
            this.btnSaveAllTab.Text = "Save all tab(&A)";
            this.btnSaveAllTab.UseVisualStyleBackColor = true;
            this.btnSaveAllTab.Click += new System.EventHandler(this.btnSaveAllTab_Click);
            // 
            // pnlTab
            // 
            this.pnlTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTab.Location = new System.Drawing.Point(4, 4);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(584, 273);
            this.pnlTab.TabIndex = 6;
            // 
            // btnReadCap
            // 
            this.btnReadCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReadCap.Location = new System.Drawing.Point(410, 4);
            this.btnReadCap.Name = "btnReadCap";
            this.btnReadCap.Size = new System.Drawing.Size(90, 23);
            this.btnReadCap.TabIndex = 6;
            this.btnReadCap.Text = "Read cap(&R)";
            this.btnReadCap.UseVisualStyleBackColor = true;
            this.btnReadCap.Click += new System.EventHandler(this.btnReadCap_Click);
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtn.Controls.Add(this.btnReadCap);
            this.pnlBtn.Controls.Add(this.btnPaste);
            this.pnlBtn.Controls.Add(this.btnDelete);
            this.pnlBtn.Controls.Add(this.btnSaveAllTab);
            this.pnlBtn.Controls.Add(this.btnSaveFocusedTab);
            this.pnlBtn.Location = new System.Drawing.Point(4, 283);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(584, 30);
            this.pnlBtn.TabIndex = 7;
            // 
            // FrmTabCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 316);
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlTab);
            this.Name = "FrmTabCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabCap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTabCap_FormClosing);
            this.Load += new System.EventHandler(this.frmTabCap_Load);
            this.pnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveFocusedTab;
        private System.Windows.Forms.Button btnSaveAllTab;
        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.Button btnReadCap;
        private System.Windows.Forms.Panel pnlBtn;
    }
}

