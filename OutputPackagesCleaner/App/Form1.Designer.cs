namespace App
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrowse.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowse.Location = new System.Drawing.Point(352, 185);
            this.buttonBrowse.Name = "button1";
            this.buttonBrowse.Size = new System.Drawing.Size(216, 84);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Delete Output Paths";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonDeleteOutputPaths_Click);
            // 
            // button2
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(15, 185);
            this.buttonDelete.Name = "button2";
            this.buttonDelete.Size = new System.Drawing.Size(331, 84);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Browse Source Path";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonBrowsePath_Click);
            // 
            // label1
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(15, 55);
            this.pathLabel.Name = "label1";
            this.pathLabel.Size = new System.Drawing.Size(77, 15);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "Find the path";
            // 
            // label2
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "label2";
            this.labelTitle.Size = new System.Drawing.Size(129, 30);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Source path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 285);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string SourcePath;
        private Button buttonBrowse;
        private FolderBrowserDialog folderBrowserDialog;
        private Button buttonDelete;
        private Label pathLabel;
        private Label labelTitle;
    }
}