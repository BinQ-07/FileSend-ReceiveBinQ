
namespace Client
{
    partial class FileSRClient
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
            this.browseButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.file_dir = new System.Windows.Forms.TextBox();
            this.serv_adrs = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.browseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(313, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(114, 37);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browse_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(313, 83);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(114, 37);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send ";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.send_Click);
            // 
            // file_dir
            // 
            this.file_dir.Location = new System.Drawing.Point(12, 19);
            this.file_dir.Name = "file_dir";
            this.file_dir.Size = new System.Drawing.Size(295, 22);
            this.file_dir.TabIndex = 2;
            // 
            // serv_adrs
            // 
            this.serv_adrs.Location = new System.Drawing.Point(12, 90);
            this.serv_adrs.Name = "serv_adrs";
            this.serv_adrs.Size = new System.Drawing.Size(295, 22);
            this.serv_adrs.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileSRClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 132);
            this.Controls.Add(this.serv_adrs);
            this.Controls.Add(this.file_dir);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.browseButton);
            this.Name = "FileSRClient";
            this.Text = "Send a File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox file_dir;
        private System.Windows.Forms.TextBox serv_adrs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

