namespace Cryphoto
{
    partial class CryotForm
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
            this.pctrBxDecryptSource = new System.Windows.Forms.PictureBox();
            this.pctrBxDecryptResult = new System.Windows.Forms.PictureBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.grpBxDecrypt = new System.Windows.Forms.GroupBox();
            this.btnChangeCryption = new System.Windows.Forms.Button();
            this.pctrBxEncryptSource = new System.Windows.Forms.PictureBox();
            this.pctrBxEncryptHiddn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pctrBxEncryptResult = new System.Windows.Forms.PictureBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.grpBxEncrypt = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxDecryptSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxDecryptResult)).BeginInit();
            this.grpBxDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxEncryptSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxEncryptHiddn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxEncryptResult)).BeginInit();
            this.grpBxEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctrBxDecryptSource
            // 
            this.pctrBxDecryptSource.BackColor = System.Drawing.Color.DarkMagenta;
            this.pctrBxDecryptSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxDecryptSource.Location = new System.Drawing.Point(6, 19);
            this.pctrBxDecryptSource.Name = "pctrBxDecryptSource";
            this.pctrBxDecryptSource.Size = new System.Drawing.Size(248, 175);
            this.pctrBxDecryptSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxDecryptSource.TabIndex = 0;
            this.pctrBxDecryptSource.TabStop = false;
            this.pctrBxDecryptSource.Click += new System.EventHandler(this.pictureBoxClicker);
            // 
            // pctrBxDecryptResult
            // 
            this.pctrBxDecryptResult.BackColor = System.Drawing.Color.Coral;
            this.pctrBxDecryptResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxDecryptResult.Location = new System.Drawing.Point(6, 225);
            this.pctrBxDecryptResult.Name = "pctrBxDecryptResult";
            this.pctrBxDecryptResult.Size = new System.Drawing.Size(248, 175);
            this.pctrBxDecryptResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxDecryptResult.TabIndex = 1;
            this.pctrBxDecryptResult.TabStop = false;
            this.pctrBxDecryptResult.Click += new System.EventHandler(this.pictureBoxClicker);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(6, 196);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(125, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.buttonClicker);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(137, 196);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(117, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Get Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.buttonClicker);
            // 
            // grpBxDecrypt
            // 
            this.grpBxDecrypt.Controls.Add(this.pctrBxDecryptSource);
            this.grpBxDecrypt.Controls.Add(this.btnSource);
            this.grpBxDecrypt.Controls.Add(this.pctrBxDecryptResult);
            this.grpBxDecrypt.Controls.Add(this.btnDecrypt);
            this.grpBxDecrypt.Location = new System.Drawing.Point(12, 52);
            this.grpBxDecrypt.Name = "grpBxDecrypt";
            this.grpBxDecrypt.Size = new System.Drawing.Size(260, 405);
            this.grpBxDecrypt.TabIndex = 4;
            this.grpBxDecrypt.TabStop = false;
            this.grpBxDecrypt.Text = "Decryption";
            this.grpBxDecrypt.Visible = false;
            // 
            // btnChangeCryption
            // 
            this.btnChangeCryption.Location = new System.Drawing.Point(12, 2);
            this.btnChangeCryption.Name = "btnChangeCryption";
            this.btnChangeCryption.Size = new System.Drawing.Size(207, 23);
            this.btnChangeCryption.TabIndex = 5;
            this.btnChangeCryption.Text = "Decryption >>";
            this.btnChangeCryption.UseVisualStyleBackColor = true;
            this.btnChangeCryption.Click += new System.EventHandler(this.buttonClicker);
            // 
            // pctrBxEncryptSource
            // 
            this.pctrBxEncryptSource.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pctrBxEncryptSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxEncryptSource.Location = new System.Drawing.Point(6, 25);
            this.pctrBxEncryptSource.Name = "pctrBxEncryptSource";
            this.pctrBxEncryptSource.Size = new System.Drawing.Size(244, 175);
            this.pctrBxEncryptSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxEncryptSource.TabIndex = 0;
            this.pctrBxEncryptSource.TabStop = false;
            this.pctrBxEncryptSource.Click += new System.EventHandler(this.pictureBoxClicker);
            this.pctrBxEncryptSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.pctrBxEncryptSource_DragDrop);
            this.pctrBxEncryptSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.pctrBxEncryptSource_DragEnter);
            // 
            // pctrBxEncryptHiddn
            // 
            this.pctrBxEncryptHiddn.BackColor = System.Drawing.SystemColors.Highlight;
            this.pctrBxEncryptHiddn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxEncryptHiddn.Location = new System.Drawing.Point(6, 213);
            this.pctrBxEncryptHiddn.Name = "pctrBxEncryptHiddn";
            this.pctrBxEncryptHiddn.Size = new System.Drawing.Size(244, 175);
            this.pctrBxEncryptHiddn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxEncryptHiddn.TabIndex = 1;
            this.pctrBxEncryptHiddn.TabStop = false;
            this.pctrBxEncryptHiddn.Click += new System.EventHandler(this.pictureBoxClicker);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hidding";
            // 
            // pctrBxEncryptResult
            // 
            this.pctrBxEncryptResult.BackColor = System.Drawing.Color.Orchid;
            this.pctrBxEncryptResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBxEncryptResult.Location = new System.Drawing.Point(6, 417);
            this.pctrBxEncryptResult.Name = "pctrBxEncryptResult";
            this.pctrBxEncryptResult.Size = new System.Drawing.Size(244, 175);
            this.pctrBxEncryptResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxEncryptResult.TabIndex = 4;
            this.pctrBxEncryptResult.TabStop = false;
            this.pctrBxEncryptResult.Click += new System.EventHandler(this.pictureBoxClicker);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(6, 391);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(244, 21);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.buttonClicker);
            // 
            // grpBxEncrypt
            // 
            this.grpBxEncrypt.Controls.Add(this.btnEncrypt);
            this.grpBxEncrypt.Controls.Add(this.pctrBxEncryptResult);
            this.grpBxEncrypt.Controls.Add(this.label2);
            this.grpBxEncrypt.Controls.Add(this.label1);
            this.grpBxEncrypt.Controls.Add(this.pctrBxEncryptHiddn);
            this.grpBxEncrypt.Controls.Add(this.pctrBxEncryptSource);
            this.grpBxEncrypt.Location = new System.Drawing.Point(12, 52);
            this.grpBxEncrypt.Name = "grpBxEncrypt";
            this.grpBxEncrypt.Size = new System.Drawing.Size(260, 600);
            this.grpBxEncrypt.TabIndex = 3;
            this.grpBxEncrypt.TabStop = false;
            this.grpBxEncrypt.Text = "Encryption";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(225, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(47, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.buttonClicker);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fast Bitmap",
            "Lock Bitmap",
            "DotNet Bitmap"});
            this.comboBox1.Location = new System.Drawing.Point(98, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "bitmap type";
            // 
            // CryotForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 659);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnChangeCryption);
            this.Controls.Add(this.grpBxEncrypt);
            this.Controls.Add(this.grpBxDecrypt);
            this.Name = "CryotForm";
            this.Text = "Cryphoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CryotForm_FormClosing);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CryotForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxDecryptSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxDecryptResult)).EndInit();
            this.grpBxDecrypt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxEncryptSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxEncryptHiddn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxEncryptResult)).EndInit();
            this.grpBxEncrypt.ResumeLayout(false);
            this.grpBxEncrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBxDecryptSource;
        private System.Windows.Forms.PictureBox pctrBxDecryptResult;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.GroupBox grpBxDecrypt;
        private System.Windows.Forms.Button btnChangeCryption;
        private System.Windows.Forms.PictureBox pctrBxEncryptSource;
        private System.Windows.Forms.PictureBox pctrBxEncryptHiddn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctrBxEncryptResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox grpBxEncrypt;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

