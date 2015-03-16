namespace Duplicati.Library.Backend
{
    partial class SSHUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSHUI));
            this.TestConnection = new System.Windows.Forms.Button();
            this.Password_show = new Duplicati.Winforms.Controls.PasswordControl();
            this.Username = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.Keyfile = new System.Windows.Forms.TextBox();
            this.Keyfilelabel = new System.Windows.Forms.Label();
            this.BrowseForKeyFileButton = new System.Windows.Forms.Button();
            this.OpenSSHKeyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestConnection
            // 
            resources.ApplyResources(this.TestConnection, "TestConnection");
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // Password_show
            // 
            this.Password_show.AskToEnterNewPassword = false;
            this.Password_show.InitialPassword = null;
            this.Password_show.IsPasswordVisible = false;
            resources.ApplyResources(this.Password_show, "Password_show");
            this.Password_show.Name = "Password_show";
            this.Password_show.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Username_label
            // 
            resources.ApplyResources(this.Username_label, "Username_label");
            this.Username_label.Name = "Username_label";
            // 
            // Keyfile
            // 
            resources.ApplyResources(this.Keyfile, "Keyfile");
            this.Keyfile.Name = "Keyfile";
            this.Keyfile.TextChanged += new System.EventHandler(this.Keyfile_TextChanged);
            // 
            // Keyfilelabel
            // 
            resources.ApplyResources(this.Keyfilelabel, "Keyfilelabel");
            this.Keyfilelabel.Name = "Keyfilelabel";
            // 
            // BrowseForKeyFileButton
            // 
            resources.ApplyResources(this.BrowseForKeyFileButton, "BrowseForKeyFileButton");
            this.BrowseForKeyFileButton.Name = "BrowseForKeyFileButton";
            this.BrowseForKeyFileButton.UseVisualStyleBackColor = true;
            this.BrowseForKeyFileButton.Click += new System.EventHandler(this.BrowseForKeyFileButton_Click);
            // 
            // OpenSSHKeyFileDialog
            // 
            resources.ApplyResources(this.OpenSSHKeyFileDialog, "OpenSSHKeyFileDialog");
            this.OpenSSHKeyFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.label1_Click);
            // 
            // Password_label
            // 
            resources.ApplyResources(this.Password_label, "Password_label");
            this.Password_label.Name = "Password_label";
            this.Password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // SSHUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.BrowseForKeyFileButton);
            this.Controls.Add(this.Keyfile);
            this.Controls.Add(this.Keyfilelabel);
            this.Controls.Add(this.TestConnection);
            this.Controls.Add(this.Password_show);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Username_label);
            this.Name = "SSHUI";
            this.Load += new System.EventHandler(this.SSHUI_PageLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button TestConnection;
        private Duplicati.Winforms.Controls.PasswordControl Password_show;
        private System.Windows.Forms.TextBox Username;
        //private System.Windows.Forms.TextBox Path;
        //private System.Windows.Forms.TextBox Servername;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Keyfile;
        private System.Windows.Forms.Label Keyfilelabel;
        private System.Windows.Forms.Button BrowseForKeyFileButton;
        private System.Windows.Forms.OpenFileDialog OpenSSHKeyFileDialog;
        private System.Windows.Forms.Label Password_label;
    }
}
