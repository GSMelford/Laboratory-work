
namespace Lab_13
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.PanelNumbers = new System.Windows.Forms.Panel();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Controls.Add(this.TabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(327, 367);
            this.TabControl.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.ComboBox);
            this.TabPage1.Controls.Add(this.RemoveButton);
            this.TabPage1.Controls.Add(this.AddButton);
            this.TabPage1.Controls.Add(this.TextBox);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(319, 339);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Task 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // ComboBox
            // 
            this.ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(3, 133);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(313, 23);
            this.ComboBox.TabIndex = 4;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveButton.Location = new System.Drawing.Point(3, 87);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(313, 46);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Location = new System.Drawing.Point(3, 41);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(313, 46);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Location = new System.Drawing.Point(3, 18);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(313, 23);
            this.TextBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Location = new System.Drawing.Point(3, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Введіть текст:";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.StatusBox);
            this.TabPage2.Controls.Add(this.PanelNumbers);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(319, 339);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Task 2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelNumbers
            // 
            this.PanelNumbers.AutoScroll = true;
            this.PanelNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNumbers.Location = new System.Drawing.Point(3, 3);
            this.PanelNumbers.Name = "PanelNumbers";
            this.PanelNumbers.Size = new System.Drawing.Size(313, 268);
            this.PanelNumbers.TabIndex = 0;
            // 
            // StatusBox
            // 
            this.StatusBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBox.Location = new System.Drawing.Point(3, 295);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(313, 41);
            this.StatusBox.TabIndex = 1;
            this.StatusBox.Text = "Спробуй!";
            this.StatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 367);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "Lab 2";
            this.TabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel PanelNumbers;
        private System.Windows.Forms.TextBox StatusBox;
    }
}

