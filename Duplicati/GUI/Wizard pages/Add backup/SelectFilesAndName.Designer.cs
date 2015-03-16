namespace Duplicati.GUI.Wizard_pages.Add_backup
{
    partial class SelectFiles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFiles));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderGroup = new System.Windows.Forms.GroupBox();
            this.InnerControlContainer = new System.Windows.Forms.Panel();
            this.totalSize = new System.Windows.Forms.Label();
            this.FolderTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.LayoutControlPanel = new System.Windows.Forms.Panel();
            this.BackupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderRadio = new System.Windows.Forms.RadioButton();
            this.FolderGroup.SuspendLayout();
            this.InnerControlContainer.SuspendLayout();
            this.LayoutControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderGroup
            // 
            this.FolderGroup.Controls.Add(this.InnerControlContainer);
            resources.ApplyResources(this.FolderGroup, "FolderGroup");
            this.FolderGroup.Name = "FolderGroup";
            this.FolderGroup.TabStop = false;
            // 
            // InnerControlContainer
            // 
            resources.ApplyResources(this.InnerControlContainer, "InnerControlContainer");
            this.InnerControlContainer.Controls.Add(this.FolderRadio);
            this.InnerControlContainer.Name = "InnerControlContainer";
            // 
            // totalSize
            // 
            resources.ApplyResources(this.totalSize, "totalSize");
            this.totalSize.Name = "totalSize";
            // 
            // LayoutControlPanel
            // 
            this.LayoutControlPanel.Controls.Add(this.BackupName);
            this.LayoutControlPanel.Controls.Add(this.label1);
            this.LayoutControlPanel.Controls.Add(this.FolderGroup);
            resources.ApplyResources(this.LayoutControlPanel, "LayoutControlPanel");
            this.LayoutControlPanel.Name = "LayoutControlPanel";
            // 
            // BackupName
            // 
            resources.ApplyResources(this.BackupName, "BackupName");
            this.BackupName.Name = "BackupName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FolderRadio
            // 
            resources.ApplyResources(this.FolderRadio, "FolderRadio");
            this.FolderRadio.Checked = true;
            this.FolderRadio.Name = "FolderRadio";
            this.FolderRadio.TabStop = true;
            this.FolderRadio.UseVisualStyleBackColor = true;
            this.FolderRadio.CheckedChanged += new System.EventHandler(this.TargetType_CheckedChanged);
            // 
            // SelectFiles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalSize);
            this.Controls.Add(this.LayoutControlPanel);
            this.Name = "SelectFiles";
            this.VisibleChanged += new System.EventHandler(this.SelectFiles_VisibleChanged);
            this.FolderGroup.ResumeLayout(false);
            this.InnerControlContainer.ResumeLayout(false);
            this.InnerControlContainer.PerformLayout();
            this.LayoutControlPanel.ResumeLayout(false);
            this.LayoutControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox FolderGroup;
        private System.Windows.Forms.Label totalSize;
        private System.Windows.Forms.ToolTip FolderTooltip;
        private System.Windows.Forms.Panel LayoutControlPanel;
        private System.Windows.Forms.Panel InnerControlContainer;
        private System.Windows.Forms.TextBox BackupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FolderRadio;
    }
}
