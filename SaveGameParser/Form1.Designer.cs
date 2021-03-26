namespace BreederReader
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
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.tbxSelectedFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "ofdSelectFile";
            this.ofdSelectFile.InitialDirectory = "c:\\users\\";
            this.ofdSelectFile.Title = "Select File to Parse...";
            // 
            // tbxSelectedFile
            // 
            this.tbxSelectedFile.AccessibleDescription = "SelectedFile";
            this.tbxSelectedFile.AccessibleName = "tbxSelectedFile";
            this.tbxSelectedFile.Location = new System.Drawing.Point(98, 156);
            this.tbxSelectedFile.Name = "tbxSelectedFile";
            this.tbxSelectedFile.Size = new System.Drawing.Size(489, 20);
            this.tbxSelectedFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lblSelectedFile";
            this.label1.AccessibleName = "lblSelectedFile";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected File";
            // 
            // btnParse
            // 
            this.btnParse.AccessibleDescription = "ParseButton";
            this.btnParse.AccessibleName = "ParseButton";
            this.btnParse.Location = new System.Drawing.Point(607, 157);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(90, 18);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse File";
            this.btnParse.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleDescription = "BrowseFile";
            this.btnBrowse.AccessibleName = "BrowseFile";
            this.btnBrowse.Location = new System.Drawing.Point(25, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 44);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSelectedFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.TextBox tbxSelectedFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnBrowse;
    }
}

