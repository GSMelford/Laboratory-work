
namespace Lab_12_Calculator
{
    partial class CalculatorForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NameProgram = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.CalculatorField = new System.Windows.Forms.TextBox();
            this.ButtonPM = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.KeyboardCalc = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.MenuText;
            this.TopPanel.Controls.Add(this.NameProgram);
            this.TopPanel.Controls.Add(this.Exit);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(190, 25);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // NameProgram
            // 
            this.NameProgram.AutoSize = true;
            this.NameProgram.ForeColor = System.Drawing.Color.White;
            this.NameProgram.Location = new System.Drawing.Point(3, 3);
            this.NameProgram.Name = "NameProgram";
            this.NameProgram.Size = new System.Drawing.Size(92, 18);
            this.NameProgram.TabIndex = 1;
            this.NameProgram.Text = "Калькулятор";
            this.NameProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameProgram_MouseDown);
            this.NameProgram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameProgram_MouseMove);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.MenuText;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(165, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CalculatorField
            // 
            this.CalculatorField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculatorField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatorField.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatorField.Location = new System.Drawing.Point(10, 35);
            this.CalculatorField.Name = "CalculatorField";
            this.CalculatorField.ReadOnly = true;
            this.CalculatorField.Size = new System.Drawing.Size(170, 29);
            this.CalculatorField.TabIndex = 1;
            this.CalculatorField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonPM
            // 
            this.ButtonPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPM.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPM.ForeColor = System.Drawing.Color.White;
            this.ButtonPM.Location = new System.Drawing.Point(10, 75);
            this.ButtonPM.Name = "ButtonPM";
            this.ButtonPM.Size = new System.Drawing.Size(45, 25);
            this.ButtonPM.TabIndex = 2;
            this.ButtonPM.Text = "+/-";
            this.ButtonPM.UseVisualStyleBackColor = false;
            this.ButtonPM.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(135, 75);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(45, 25);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "C";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // KeyboardCalc
            // 
            this.KeyboardCalc.Location = new System.Drawing.Point(10, 110);
            this.KeyboardCalc.Name = "KeyboardCalc";
            this.KeyboardCalc.Size = new System.Drawing.Size(170, 170);
            this.KeyboardCalc.TabIndex = 4;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(190, 295);
            this.Controls.Add(this.KeyboardCalc);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonPM);
            this.Controls.Add(this.CalculatorField);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label NameProgram;
        private System.Windows.Forms.TextBox CalculatorField;
        private System.Windows.Forms.Button ButtonPM;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Panel KeyboardCalc;
    }
}

