namespace Library_Managment
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.writterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writterEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writterUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writterViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writterInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.publisherToolStripMenuItem,
            this.writterToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // publisherToolStripMenuItem
            // 
            this.publisherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.publisherToolStripMenuItem.Name = "publisherToolStripMenuItem";
            this.publisherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.publisherToolStripMenuItem.Text = "Publisher";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.insertToolStripMenuItem.Text = "Insert_Update_Delete";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // writterToolStripMenuItem
            // 
            this.writterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writterEntryToolStripMenuItem,
            this.writterUpdateToolStripMenuItem,
            this.writterViewToolStripMenuItem});
            this.writterToolStripMenuItem.Name = "writterToolStripMenuItem";
            this.writterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writterToolStripMenuItem.Text = "Writter";
            // 
            // writterEntryToolStripMenuItem
            // 
            this.writterEntryToolStripMenuItem.Name = "writterEntryToolStripMenuItem";
            this.writterEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writterEntryToolStripMenuItem.Text = "Writter Entry";
            this.writterEntryToolStripMenuItem.Click += new System.EventHandler(this.writterEntryToolStripMenuItem_Click);
            // 
            // writterUpdateToolStripMenuItem
            // 
            this.writterUpdateToolStripMenuItem.Name = "writterUpdateToolStripMenuItem";
            this.writterUpdateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.writterUpdateToolStripMenuItem.Text = "Writter Update/Delete";
            this.writterUpdateToolStripMenuItem.Click += new System.EventHandler(this.writterUpdateToolStripMenuItem_Click);
            // 
            // writterViewToolStripMenuItem
            // 
            this.writterViewToolStripMenuItem.Name = "writterViewToolStripMenuItem";
            this.writterViewToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.writterViewToolStripMenuItem.Text = "Writter View";
            this.writterViewToolStripMenuItem.Click += new System.EventHandler(this.writterViewToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writterInformationReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // writterInformationReportToolStripMenuItem
            // 
            this.writterInformationReportToolStripMenuItem.Name = "writterInformationReportToolStripMenuItem";
            this.writterInformationReportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.writterInformationReportToolStripMenuItem.Text = "Book Information Report";
            this.writterInformationReportToolStripMenuItem.Click += new System.EventHandler(this.writterInformationReportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem writterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writterEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writterUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writterViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writterInformationReportToolStripMenuItem;
    }
}