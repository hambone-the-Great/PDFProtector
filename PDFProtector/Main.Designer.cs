namespace PDFProtector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select or drag and drop a PDF file to password protect.";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(562, 61);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(113, 31);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(562, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 31);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(198, 147);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(358, 31);
            this.txtPassword2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Repeat Password:";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(198, 107);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(358, 31);
            this.txtPassword1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password:";
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(198, 61);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(358, 31);
            this.txtSelected.TabIndex = 10;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(62, 65);
            this.lblFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(127, 22);
            this.lblFile.TabIndex = 9;
            this.lblFile.Text = "Selected File:";
            // 
            // PdfProtector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.lblFile);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PdfProtector";
            this.Text = "PDF Protector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Label lblFile;
    }
}

