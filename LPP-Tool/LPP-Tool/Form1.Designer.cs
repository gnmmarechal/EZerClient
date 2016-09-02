namespace LPP_Tool
{
    partial class mainform
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
            this.compile_button = new System.Windows.Forms.Button();
            this.main_tabcontrol = new System.Windows.Forms.TabControl();
            this.tab_cia = new System.Windows.Forms.TabPage();
            this.lpp_stable = new System.Windows.Forms.RadioButton();
            this.luaplayer_label = new System.Windows.Forms.Label();
            this.main_tabcontrol.SuspendLayout();
            this.tab_cia.SuspendLayout();
            this.SuspendLayout();
            // 
            // compile_button
            // 
            this.compile_button.Location = new System.Drawing.Point(346, 324);
            this.compile_button.Name = "compile_button";
            this.compile_button.Size = new System.Drawing.Size(75, 23);
            this.compile_button.TabIndex = 0;
            this.compile_button.Text = "Compile";
            this.compile_button.UseVisualStyleBackColor = true;
            // 
            // main_tabcontrol
            // 
            this.main_tabcontrol.Controls.Add(this.tab_cia);
            this.main_tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.main_tabcontrol.Name = "main_tabcontrol";
            this.main_tabcontrol.SelectedIndex = 0;
            this.main_tabcontrol.Size = new System.Drawing.Size(409, 306);
            this.main_tabcontrol.TabIndex = 1;
            // 
            // tab_cia
            // 
            this.tab_cia.Controls.Add(this.luaplayer_label);
            this.tab_cia.Controls.Add(this.lpp_stable);
            this.tab_cia.Location = new System.Drawing.Point(4, 22);
            this.tab_cia.Name = "tab_cia";
            this.tab_cia.Size = new System.Drawing.Size(401, 280);
            this.tab_cia.TabIndex = 0;
            this.tab_cia.Text = "CIA";
            this.tab_cia.UseVisualStyleBackColor = true;
            // 
            // lpp_stable
            // 
            this.lpp_stable.AutoSize = true;
            this.lpp_stable.Location = new System.Drawing.Point(24, 46);
            this.lpp_stable.Name = "lpp_stable";
            this.lpp_stable.Size = new System.Drawing.Size(119, 17);
            this.lpp_stable.TabIndex = 0;
            this.lpp_stable.TabStop = true;
            this.lpp_stable.Text = "LPP-3DS R5 Stable";
            this.lpp_stable.UseVisualStyleBackColor = true;
            // 
            // luaplayer_label
            // 
            this.luaplayer_label.AutoSize = true;
            this.luaplayer_label.Location = new System.Drawing.Point(4, 19);
            this.luaplayer_label.Name = "luaplayer_label";
            this.luaplayer_label.Size = new System.Drawing.Size(92, 13);
            this.luaplayer_label.TabIndex = 1;
            this.luaplayer_label.Text = "LPP-3DS Version:";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 359);
            this.Controls.Add(this.main_tabcontrol);
            this.Controls.Add(this.compile_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainform";
            this.Text = "Lua Player Plus to CIA/3DS/3DSX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_tabcontrol.ResumeLayout(false);
            this.tab_cia.ResumeLayout(false);
            this.tab_cia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compile_button;
        private System.Windows.Forms.TabControl main_tabcontrol;
        private System.Windows.Forms.TabPage tab_cia;
        private System.Windows.Forms.Label luaplayer_label;
        private System.Windows.Forms.RadioButton lpp_stable;
    }
}

