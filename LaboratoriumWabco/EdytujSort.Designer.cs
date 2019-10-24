namespace LaboratoriumWabco
{
    partial class EdytujSort
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
            this.labelEdytowanySort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEdytowanySort
            // 
            this.labelEdytowanySort.AutoSize = true;
            this.labelEdytowanySort.Location = new System.Drawing.Point(13, 13);
            this.labelEdytowanySort.Name = "labelEdytowanySort";
            this.labelEdytowanySort.Size = new System.Drawing.Size(174, 13);
            this.labelEdytowanySort.TabIndex = 0;
            this.labelEdytowanySort.Text = "Informacje na temat sortu częsci nr:";
            // 
            // EdytujSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEdytowanySort);
            this.Name = "EdytujSort";
            this.Text = "EdytujSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEdytowanySort;
    }
}