﻿namespace Csharp_Bang_Cuu_Chuong
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
            this.btnxem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(534, 137);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(144, 40);
            this.btnxem.TabIndex = 0;
            this.btnxem.Text = "xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(200, 157);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(150, 20);
            this.txt1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn muốn xem bảng cửu chương mấy";
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(262, 219);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(237, 108);
            this.lsbketqua.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbketqua;
    }
}

