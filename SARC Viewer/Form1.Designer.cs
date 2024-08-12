namespace SARC_Viewer
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSARCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSARCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSARCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashTableEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SARC_ItemListBox = new System.Windows.Forms.ListBox();
            this.SARC_ItemListBoxCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SARC_ItemListBoxCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.hashTableToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSARCToolStripMenuItem,
            this.saveSARCToolStripMenuItem,
            this.closeSARCToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSARCToolStripMenuItem
            // 
            this.openSARCToolStripMenuItem.Name = "openSARCToolStripMenuItem";
            this.openSARCToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openSARCToolStripMenuItem.Text = "Open SARC";
            this.openSARCToolStripMenuItem.Click += new System.EventHandler(this.openSARCToolStripMenuItem_Click);
            // 
            // saveSARCToolStripMenuItem
            // 
            this.saveSARCToolStripMenuItem.Name = "saveSARCToolStripMenuItem";
            this.saveSARCToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveSARCToolStripMenuItem.Text = "Save SARC";
            // 
            // closeSARCToolStripMenuItem
            // 
            this.closeSARCToolStripMenuItem.Name = "closeSARCToolStripMenuItem";
            this.closeSARCToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeSARCToolStripMenuItem.Text = "Close SARC";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.createToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // hashTableToolStripMenuItem
            // 
            this.hashTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashTableEditorToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.hashTableToolStripMenuItem.Name = "hashTableToolStripMenuItem";
            this.hashTableToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hashTableToolStripMenuItem.Text = "HashTable";
            // 
            // hashTableEditorToolStripMenuItem
            // 
            this.hashTableEditorToolStripMenuItem.Name = "hashTableEditorToolStripMenuItem";
            this.hashTableEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hashTableEditorToolStripMenuItem.Text = "HashTable Editor";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toHashToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SARC_ItemListBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // SARC_ItemListBox
            // 
            this.SARC_ItemListBox.ContextMenuStrip = this.SARC_ItemListBoxCMS;
            this.SARC_ItemListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SARC_ItemListBox.FormattingEnabled = true;
            this.SARC_ItemListBox.ItemHeight = 12;
            this.SARC_ItemListBox.Location = new System.Drawing.Point(0, 0);
            this.SARC_ItemListBox.Name = "SARC_ItemListBox";
            this.SARC_ItemListBox.Size = new System.Drawing.Size(266, 426);
            this.SARC_ItemListBox.TabIndex = 0;
            // 
            // SARC_ItemListBoxCMS
            // 
            this.SARC_ItemListBoxCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem,
            this.extractToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.SARC_ItemListBoxCMS.Name = "SARC_ItemListBoxCMS";
            this.SARC_ItemListBoxCMS.Size = new System.Drawing.Size(117, 70);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // extractToolStripMenuItem1
            // 
            this.extractToolStripMenuItem1.Name = "extractToolStripMenuItem1";
            this.extractToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.extractToolStripMenuItem1.Text = "Extract";
            this.extractToolStripMenuItem1.Click += new System.EventHandler(this.extractToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // toHashToolStripMenuItem
            // 
            this.toHashToolStripMenuItem.Name = "toHashToolStripMenuItem";
            this.toHashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toHashToolStripMenuItem.Text = "ToHash";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SARC Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SARC_ItemListBoxCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSARCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSARCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSARCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox SARC_ItemListBox;
        private System.Windows.Forms.ToolStripMenuItem hashTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashTableEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SARC_ItemListBoxCMS;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toHashToolStripMenuItem;
    }
}

