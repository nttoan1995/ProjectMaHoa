namespace FinalCrypt
{
    partial class Form1
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
            this.dangnhap = new System.Windows.Forms.Button();
            this.dangki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dangnhap.Location = new System.Drawing.Point(48, 50);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(192, 73);
            this.dangnhap.TabIndex = 0;
            this.dangnhap.Text = "ĐĂNG NHẬP";
            this.dangnhap.UseVisualStyleBackColor = false;
            // 
            // dangki
            // 
            this.dangki.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dangki.Location = new System.Drawing.Point(48, 148);
            this.dangki.Name = "dangki";
            this.dangki.Size = new System.Drawing.Size(192, 73);
            this.dangki.TabIndex = 1;
            this.dangki.Text = "ĐĂNG KÍ";
            this.dangki.UseVisualStyleBackColor = true;
            this.dangki.Click += new System.EventHandler(this.dangki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dangki);
            this.Controls.Add(this.dangnhap);
            this.Name = "Form1";
            this.Text = "Final Crypt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button dangki;
    }
}

