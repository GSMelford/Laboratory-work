
namespace Lab_18
{
    partial class MainForm
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
            this.CreateFolder = new System.Windows.Forms.Button();
            this.CreateSubFolder = new System.Windows.Forms.Button();
            this.CheckMaxSubFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateFolder
            // 
            this.CreateFolder.Location = new System.Drawing.Point(12, 12);
            this.CreateFolder.Name = "CreateFolder";
            this.CreateFolder.Size = new System.Drawing.Size(205, 43);
            this.CreateFolder.TabIndex = 0;
            this.CreateFolder.Text = "Создать 100 папок";
            this.CreateFolder.UseVisualStyleBackColor = true;
            this.CreateFolder.Click += new System.EventHandler(this.CreateFolder_Click);
            // 
            // CreateSubFolder
            // 
            this.CreateSubFolder.Location = new System.Drawing.Point(12, 61);
            this.CreateSubFolder.Name = "CreateSubFolder";
            this.CreateSubFolder.Size = new System.Drawing.Size(205, 45);
            this.CreateSubFolder.TabIndex = 3;
            this.CreateSubFolder.Text = "Создать 100 вложеных папок";
            this.CreateSubFolder.UseVisualStyleBackColor = true;
            this.CreateSubFolder.Click += new System.EventHandler(this.CreateSubFolder_Click);
            // 
            // CheckMaxSubFolders
            // 
            this.CheckMaxSubFolders.Location = new System.Drawing.Point(12, 112);
            this.CheckMaxSubFolders.Name = "CheckMaxSubFolders";
            this.CheckMaxSubFolders.Size = new System.Drawing.Size(205, 45);
            this.CheckMaxSubFolders.TabIndex = 4;
            this.CheckMaxSubFolders.Text = "Узнать максимальное количество вложеных папок";
            this.CheckMaxSubFolders.UseVisualStyleBackColor = true;
            this.CheckMaxSubFolders.Click += new System.EventHandler(this.CheckMaxSubFolders_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 168);
            this.Controls.Add(this.CheckMaxSubFolders);
            this.Controls.Add(this.CreateSubFolder);
            this.Controls.Add(this.CreateFolder);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateFolder;
        private System.Windows.Forms.Button CreateSubFolder;
        private System.Windows.Forms.Button CheckMaxSubFolders;
    }
}

