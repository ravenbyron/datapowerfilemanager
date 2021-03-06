﻿namespace DataPowerFileManager
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.cmbDataPowerDomains = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDomainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tLogin = new System.Windows.Forms.Timer(this.components);
            this.fileListBox = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.driveListBox = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.dirListBox = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDataPowerDomains
            // 
            this.cmbDataPowerDomains.Enabled = false;
            this.cmbDataPowerDomains.FormattingEnabled = true;
            this.cmbDataPowerDomains.Location = new System.Drawing.Point(341, 57);
            this.cmbDataPowerDomains.Name = "cmbDataPowerDomains";
            this.cmbDataPowerDomains.Size = new System.Drawing.Size(219, 21);
            this.cmbDataPowerDomains.TabIndex = 2;
            this.cmbDataPowerDomains.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Get File List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataPowerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(571, 24);
            this.msMainMenu.TabIndex = 9;
            this.msMainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToToolStripMenuItem
            // 
            this.returnToToolStripMenuItem.Name = "returnToToolStripMenuItem";
            this.returnToToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.returnToToolStripMenuItem.Text = "Login";
            this.returnToToolStripMenuItem.Click += new System.EventHandler(this.returnToToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataPowerToolStripMenuItem
            // 
            this.dataPowerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDomainsToolStripMenuItem});
            this.dataPowerToolStripMenuItem.Name = "dataPowerToolStripMenuItem";
            this.dataPowerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.dataPowerToolStripMenuItem.Text = "DataPower";
            // 
            // getDomainsToolStripMenuItem
            // 
            this.getDomainsToolStripMenuItem.Name = "getDomainsToolStripMenuItem";
            this.getDomainsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getDomainsToolStripMenuItem.Text = "Get Domains";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Enabled = false;
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.Location = new System.Drawing.Point(341, 84);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(219, 279);
            this.treeView2.TabIndex = 13;
            // 
            // tLogin
            // 
            this.tLogin.Enabled = true;
            this.tLogin.Tick += new System.EventHandler(this.tLogin_Tick);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(12, 369);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Pattern = "*.xml;*.xslt;*.xsd";
            this.fileListBox.Size = new System.Drawing.Size(219, 277);
            this.fileListBox.TabIndex = 24;
            // 
            // driveListBox
            // 
            this.driveListBox.FormattingEnabled = true;
            this.driveListBox.Location = new System.Drawing.Point(12, 57);
            this.driveListBox.Name = "driveListBox";
            this.driveListBox.Size = new System.Drawing.Size(219, 21);
            this.driveListBox.TabIndex = 23;
            this.driveListBox.SelectedIndexChanged += new System.EventHandler(this.driveListBox_SelectedIndexChanged);
            // 
            // dirListBox
            // 
            this.dirListBox.FormattingEnabled = true;
            this.dirListBox.IntegralHeight = false;
            this.dirListBox.Location = new System.Drawing.Point(12, 84);
            this.dirListBox.Name = "dirListBox";
            this.dirListBox.Size = new System.Drawing.Size(219, 279);
            this.dirListBox.TabIndex = 22;
            this.dirListBox.Change += new System.EventHandler(this.dirListBox_Change);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 653);
            this.ControlBox = false;
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.driveListBox);
            this.Controls.Add(this.dirListBox);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbDataPowerDomains);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPowerFileManager";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDataPowerDomains;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDomainsToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Timer tLogin;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox;
    }
}

