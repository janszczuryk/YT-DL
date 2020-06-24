using System;

namespace YT_DL
{
    partial class YTDLOkno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTDLOkno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDownloadedFolder = new System.Windows.Forms.Button();
            this.outputLogs = new System.Windows.Forms.TextBox();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.labelProgramTitle = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDownloadTitle = new System.Windows.Forms.Label();
            this.labelDownloadLinks = new System.Windows.Forms.Label();
            this.buttonDownloadLinks = new System.Windows.Forms.Button();
            this.inputLinks = new System.Windows.Forms.RichTextBox();
            this.contextMenuInputLinks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripInputLinksPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDownloadTitle = new System.Windows.Forms.Button();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.contextMenuInputTitle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripInputTitlePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuInputLinks.SuspendLayout();
            this.contextMenuInputTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDownloadedFolder);
            this.panel1.Controls.Add(this.outputLogs);
            this.panel1.Controls.Add(this.buttonCloseWindow);
            this.panel1.Controls.Add(this.labelProgramTitle);
            this.panel1.Controls.Add(this.buttonSettings);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonDownloadedFolder
            // 
            this.buttonDownloadedFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.buttonDownloadedFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonDownloadedFolder, "buttonDownloadedFolder");
            this.buttonDownloadedFolder.Name = "buttonDownloadedFolder";
            this.buttonDownloadedFolder.UseVisualStyleBackColor = false;
            this.buttonDownloadedFolder.Click += new System.EventHandler(this.ButtonDownloadedFolder_Click);
            // 
            // outputLogs
            // 
            this.outputLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.outputLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLogs.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            resources.ApplyResources(this.outputLogs, "outputLogs");
            this.outputLogs.Name = "outputLogs";
            this.outputLogs.ReadOnly = true;
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.buttonCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonCloseWindow, "buttonCloseWindow");
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.ButtonCloseWindow_Click);
            // 
            // labelProgramTitle
            // 
            resources.ApplyResources(this.labelProgramTitle, "labelProgramTitle");
            this.labelProgramTitle.Name = "labelProgramTitle";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDownloadTitle);
            this.panel2.Controls.Add(this.labelDownloadLinks);
            this.panel2.Controls.Add(this.buttonDownloadLinks);
            this.panel2.Controls.Add(this.inputLinks);
            this.panel2.Controls.Add(this.buttonDownloadTitle);
            this.panel2.Controls.Add(this.inputTitle);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // labelDownloadTitle
            // 
            resources.ApplyResources(this.labelDownloadTitle, "labelDownloadTitle");
            this.labelDownloadTitle.Name = "labelDownloadTitle";
            // 
            // labelDownloadLinks
            // 
            resources.ApplyResources(this.labelDownloadLinks, "labelDownloadLinks");
            this.labelDownloadLinks.Name = "labelDownloadLinks";
            // 
            // buttonDownloadLinks
            // 
            this.buttonDownloadLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.buttonDownloadLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonDownloadLinks, "buttonDownloadLinks");
            this.buttonDownloadLinks.Name = "buttonDownloadLinks";
            this.buttonDownloadLinks.UseVisualStyleBackColor = false;
            this.buttonDownloadLinks.Click += new System.EventHandler(this.ButtonDownloadLinks_Click);
            // 
            // inputLinks
            // 
            this.inputLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.inputLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLinks.ContextMenuStrip = this.contextMenuInputLinks;
            this.inputLinks.DetectUrls = false;
            this.inputLinks.EnableAutoDragDrop = true;
            this.inputLinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputLinks.HideSelection = false;
            resources.ApplyResources(this.inputLinks, "inputLinks");
            this.inputLinks.Name = "inputLinks";
            // 
            // contextMenuInputLinks
            // 
            this.contextMenuInputLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.contextMenuInputLinks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripInputLinksPaste});
            this.contextMenuInputLinks.Name = "contextMenuStrip1";
            this.contextMenuInputLinks.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuInputLinks, "contextMenuInputLinks");
            // 
            // stripInputLinksPaste
            // 
            this.stripInputLinksPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.stripInputLinksPaste, "stripInputLinksPaste");
            this.stripInputLinksPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.stripInputLinksPaste.Name = "stripInputLinksPaste";
            this.stripInputLinksPaste.Click += new System.EventHandler(this.stripInputLinksPaste_Click);
            // 
            // buttonDownloadTitle
            // 
            this.buttonDownloadTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.buttonDownloadTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonDownloadTitle, "buttonDownloadTitle");
            this.buttonDownloadTitle.Name = "buttonDownloadTitle";
            this.buttonDownloadTitle.UseVisualStyleBackColor = false;
            this.buttonDownloadTitle.Click += new System.EventHandler(this.ButtonDownloadTitle_Click);
            // 
            // inputTitle
            // 
            this.inputTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.inputTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTitle.ContextMenuStrip = this.contextMenuInputTitle;
            this.inputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            resources.ApplyResources(this.inputTitle, "inputTitle");
            this.inputTitle.Name = "inputTitle";
            // 
            // contextMenuInputTitle
            // 
            this.contextMenuInputTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.contextMenuInputTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripInputTitlePaste});
            this.contextMenuInputTitle.Name = "contextMenuStrip1";
            this.contextMenuInputTitle.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuInputTitle, "contextMenuInputTitle");
            // 
            // stripInputTitlePaste
            // 
            this.stripInputTitlePaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.stripInputTitlePaste, "stripInputTitlePaste");
            this.stripInputTitlePaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.stripInputTitlePaste.Name = "stripInputTitlePaste";
            this.stripInputTitlePaste.Click += new System.EventHandler(this.stripInputTitlePaste_Click);
            // 
            // YTDLOkno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YTDLOkno";
            this.Load += new System.EventHandler(this.YTDLOkno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuInputLinks.ResumeLayout(false);
            this.contextMenuInputTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.RichTextBox inputLinks;
        private System.Windows.Forms.TextBox outputLogs;
        private System.Windows.Forms.Button buttonDownloadTitle;
        private System.Windows.Forms.Button buttonDownloadLinks;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonDownloadedFolder;
        private System.Windows.Forms.Label labelProgramTitle;
        private System.Windows.Forms.Label labelDownloadTitle;
        private System.Windows.Forms.Label labelDownloadLinks;
        private System.Windows.Forms.ContextMenuStrip contextMenuInputLinks;
        private System.Windows.Forms.ToolStripMenuItem stripInputLinksPaste;
        private System.Windows.Forms.ContextMenuStrip contextMenuInputTitle;
        private System.Windows.Forms.ToolStripMenuItem stripInputTitlePaste;
    }
}

