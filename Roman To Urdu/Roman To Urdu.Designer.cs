namespace Roman_To_Urdu
{
    partial class RomanToUrdu
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
            this.textBoxRoman = new System.Windows.Forms.TextBox();
            this.textBoxUrdu = new System.Windows.Forms.TextBox();
            this.labelRoman = new System.Windows.Forms.Label();
            this.labelUrdu = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCopyUrduText = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRoman
            // 
            this.textBoxRoman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRoman.Location = new System.Drawing.Point(12, 29);
            this.textBoxRoman.Multiline = true;
            this.textBoxRoman.Name = "textBoxRoman";
            this.textBoxRoman.Size = new System.Drawing.Size(823, 248);
            this.textBoxRoman.TabIndex = 0;
            this.textBoxRoman.Text = "mera naam tahir hay";
            // 
            // textBoxUrdu
            // 
            this.textBoxUrdu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrdu.Location = new System.Drawing.Point(12, 300);
            this.textBoxUrdu.Multiline = true;
            this.textBoxUrdu.Name = "textBoxUrdu";
            this.textBoxUrdu.ShortcutsEnabled = false;
            this.textBoxUrdu.Size = new System.Drawing.Size(823, 131);
            this.textBoxUrdu.TabIndex = 1;
            this.textBoxUrdu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxUrdu_MouseDown);
            // 
            // labelRoman
            // 
            this.labelRoman.AutoSize = true;
            this.labelRoman.Location = new System.Drawing.Point(12, 9);
            this.labelRoman.Name = "labelRoman";
            this.labelRoman.Size = new System.Drawing.Size(92, 17);
            this.labelRoman.TabIndex = 2;
            this.labelRoman.Text = "Roman Urdu:";
            // 
            // labelUrdu
            // 
            this.labelUrdu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUrdu.AutoSize = true;
            this.labelUrdu.Location = new System.Drawing.Point(12, 280);
            this.labelUrdu.Name = "labelUrdu";
            this.labelUrdu.Size = new System.Drawing.Size(138, 17);
            this.labelUrdu.TabIndex = 3;
            this.labelUrdu.Text = "Urdu Transliteration:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Location = new System.Drawing.Point(695, 437);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(140, 34);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(206, 28);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(205, 24);
            this.toolStripMenuItemAdd.Text = "Add Urdu for this word";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // buttonCopyUrduText
            // 
            this.buttonCopyUrduText.Location = new System.Drawing.Point(12, 437);
            this.buttonCopyUrduText.Name = "buttonCopyUrduText";
            this.buttonCopyUrduText.Size = new System.Drawing.Size(183, 34);
            this.buttonCopyUrduText.TabIndex = 5;
            this.buttonCopyUrduText.Text = "Copy Converted Text";
            this.buttonCopyUrduText.UseVisualStyleBackColor = true;
            this.buttonCopyUrduText.Click += new System.EventHandler(this.buttonCopyUrduText_Click);
            // 
            // RomanToUrdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 483);
            this.Controls.Add(this.buttonCopyUrduText);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelUrdu);
            this.Controls.Add(this.labelRoman);
            this.Controls.Add(this.textBoxUrdu);
            this.Controls.Add(this.textBoxRoman);
            this.MinimumSize = new System.Drawing.Size(865, 530);
            this.Name = "RomanToUrdu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roman To Urdu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RomanToUrdu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRoman;
        private System.Windows.Forms.TextBox textBoxUrdu;
        private System.Windows.Forms.Label labelRoman;
        private System.Windows.Forms.Label labelUrdu;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.Button buttonCopyUrduText;
    }
}

