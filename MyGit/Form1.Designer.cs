
namespace MyGit
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
            this.btnClone = new System.Windows.Forms.Button();
            this.txtClone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(13, 13);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 23);
            this.btnClone.TabIndex = 0;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            // 
            // txtClone
            // 
            this.txtClone.Location = new System.Drawing.Point(95, 15);
            this.txtClone.Name = "txtClone";
            this.txtClone.Size = new System.Drawing.Size(693, 20);
            this.txtClone.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClone);
            this.Controls.Add(this.btnClone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.TextBox txtClone;
    }
}

