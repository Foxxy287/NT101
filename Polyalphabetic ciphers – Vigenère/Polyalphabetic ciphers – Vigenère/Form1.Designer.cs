namespace Polyalphabetic_ciphers___Vigenère
{
    partial class VigenèreCipher
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
            this.Text_txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Result_txt = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.Key_txt = new System.Windows.Forms.TextBox();
            this.Key_lbl = new System.Windows.Forms.Label();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.Text_lbl = new System.Windows.Forms.Label();
            this.Result_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_txt
            // 
            this.Text_txt.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_txt.Location = new System.Drawing.Point(12, 100);
            this.Text_txt.Multiline = true;
            this.Text_txt.Name = "Text_txt";
            this.Text_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_txt.Size = new System.Drawing.Size(776, 145);
            this.Text_txt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Result_txt
            // 
            this.Result_txt.Location = new System.Drawing.Point(12, 306);
            this.Result_txt.Multiline = true;
            this.Result_txt.Name = "Result_txt";
            this.Result_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result_txt.Size = new System.Drawing.Size(776, 132);
            this.Result_txt.TabIndex = 0;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Location = new System.Drawing.Point(283, 251);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(92, 33);
            this.Encrypt_btn.TabIndex = 1;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Location = new System.Drawing.Point(411, 251);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(92, 33);
            this.Decrypt_btn.TabIndex = 1;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // Key_txt
            // 
            this.Key_txt.Location = new System.Drawing.Point(312, 48);
            this.Key_txt.Name = "Key_txt";
            this.Key_txt.Size = new System.Drawing.Size(191, 20);
            this.Key_txt.TabIndex = 2;
            // 
            // Key_lbl
            // 
            this.Key_lbl.AutoSize = true;
            this.Key_lbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key_lbl.Location = new System.Drawing.Point(280, 48);
            this.Key_lbl.Name = "Key_lbl";
            this.Key_lbl.Size = new System.Drawing.Size(26, 16);
            this.Key_lbl.TabIndex = 3;
            this.Key_lbl.Text = "Key";
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lbl.Location = new System.Drawing.Point(277, 10);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(226, 32);
            this.Title_lbl.TabIndex = 4;
            this.Title_lbl.Text = "Vigenère Cipher";
            this.Title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text_lbl
            // 
            this.Text_lbl.AutoSize = true;
            this.Text_lbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_lbl.Location = new System.Drawing.Point(12, 81);
            this.Text_lbl.Name = "Text_lbl";
            this.Text_lbl.Size = new System.Drawing.Size(28, 16);
            this.Text_lbl.TabIndex = 5;
            this.Text_lbl.Text = "Text";
            // 
            // Result_lbl
            // 
            this.Result_lbl.AutoSize = true;
            this.Result_lbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_lbl.Location = new System.Drawing.Point(12, 287);
            this.Result_lbl.Name = "Result_lbl";
            this.Result_lbl.Size = new System.Drawing.Size(36, 16);
            this.Result_lbl.TabIndex = 6;
            this.Result_lbl.Text = "Result";
            // 
            // VigenèreCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result_lbl);
            this.Controls.Add(this.Text_lbl);
            this.Controls.Add(this.Title_lbl);
            this.Controls.Add(this.Key_lbl);
            this.Controls.Add(this.Key_txt);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.Result_txt);
            this.Controls.Add(this.Text_txt);
            this.Name = "VigenèreCipher";
            this.Text = "Polyalphabetic ciphers – Vigenère ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Result_txt;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.TextBox Key_txt;
        private System.Windows.Forms.Label Key_lbl;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.Label Text_lbl;
        private System.Windows.Forms.Label Result_lbl;
    }
}

