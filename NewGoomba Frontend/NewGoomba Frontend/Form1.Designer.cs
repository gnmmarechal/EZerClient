namespace NewGoomba_Frontend
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleROMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadROMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadROMToolStripMenuItem
            // 
            this.loadROMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleROMToolStripMenuItem,
            this.multipleROMsToolStripMenuItem});
            this.loadROMToolStripMenuItem.Name = "loadROMToolStripMenuItem";
            this.loadROMToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.loadROMToolStripMenuItem.Text = "Load ROM";
            // 
            // singleROMToolStripMenuItem
            // 
            this.singleROMToolStripMenuItem.Name = "singleROMToolStripMenuItem";
            this.singleROMToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.singleROMToolStripMenuItem.Text = "Single ROM";
            // 
            // multipleROMsToolStripMenuItem
            // 
            this.multipleROMsToolStripMenuItem.Name = "multipleROMsToolStripMenuItem";
            this.multipleROMsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.multipleROMsToolStripMenuItem.Text = "Multiple ROMs";
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(237, 217);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(129, 56);
            this.compileButton.TabIndex = 7;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 285);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "NewGoomba Frontend";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleROMsToolStripMenuItem;
        private System.Windows.Forms.Button compileButton;
    }
}

