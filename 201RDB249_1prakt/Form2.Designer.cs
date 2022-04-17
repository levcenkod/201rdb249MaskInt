
namespace _201RDB249_1prakt
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonMe = new System.Windows.Forms.Button();
            this.ButtonDators = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(196, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kurs uzsak speli?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ButtonMe
            // 
            this.ButtonMe.Location = new System.Drawing.Point(38, 176);
            this.ButtonMe.Name = "ButtonMe";
            this.ButtonMe.Size = new System.Drawing.Size(210, 75);
            this.ButtonMe.TabIndex = 6;
            this.ButtonMe.Text = "Es";
            this.ButtonMe.UseVisualStyleBackColor = true;
            this.ButtonMe.Click += new System.EventHandler(this.ButtonMe_Click);
            // 
            // ButtonDators
            // 
            this.ButtonDators.Location = new System.Drawing.Point(327, 176);
            this.ButtonDators.Name = "ButtonDators";
            this.ButtonDators.Size = new System.Drawing.Size(213, 75);
            this.ButtonDators.TabIndex = 7;
            this.ButtonDators.Text = "Dators";
            this.ButtonDators.UseVisualStyleBackColor = true;
            this.ButtonDators.Click += new System.EventHandler(this.ButtonDators_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 360);
            this.Controls.Add(this.ButtonDators);
            this.Controls.Add(this.ButtonMe);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonMe;
        private System.Windows.Forms.Button ButtonDators;
    }
}