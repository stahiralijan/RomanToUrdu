namespace Roman_To_Urdu
{
    partial class Add_Word
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRomanWord = new System.Windows.Forms.TextBox();
            this.textBoxUrduWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roman Word:";
            // 
            // textBoxRomanWord
            // 
            this.textBoxRomanWord.Location = new System.Drawing.Point(33, 50);
            this.textBoxRomanWord.Name = "textBoxRomanWord";
            this.textBoxRomanWord.Size = new System.Drawing.Size(445, 22);
            this.textBoxRomanWord.TabIndex = 1;
            // 
            // textBoxUrduWord
            // 
            this.textBoxUrduWord.Location = new System.Drawing.Point(33, 113);
            this.textBoxUrduWord.Name = "textBoxUrduWord";
            this.textBoxUrduWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxUrduWord.Size = new System.Drawing.Size(445, 22);
            this.textBoxUrduWord.TabIndex = 3;
            this.textBoxUrduWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrduWord_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urdu Word:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(403, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 44);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Add_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 230);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxUrduWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRomanWord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Word";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Word";
            this.Shown += new System.EventHandler(this.Add_Word_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRomanWord;
        private System.Windows.Forms.TextBox textBoxUrduWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}