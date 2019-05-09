namespace PlannerUI
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
            this.flatPanel = new System.Windows.Forms.Panel();
            this.flatTree = new System.Windows.Forms.Label();
            this.errorLds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flatPanel
            // 
            this.flatPanel.BackColor = System.Drawing.SystemColors.Window;
            this.flatPanel.Location = new System.Drawing.Point(12, 12);
            this.flatPanel.Name = "flatPanel";
            this.flatPanel.Size = new System.Drawing.Size(1054, 593);
            this.flatPanel.TabIndex = 1;
            this.flatPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flatPanel_MouseDown);
            this.flatPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flatPanel_MouseUp);
            // 
            // flatTree
            // 
            this.flatTree.AutoSize = true;
            this.flatTree.Location = new System.Drawing.Point(1085, 12);
            this.flatTree.Name = "flatTree";
            this.flatTree.Size = new System.Drawing.Size(0, 17);
            this.flatTree.TabIndex = 2;
            // 
            // errorLds
            // 
            this.errorLds.AutoSize = true;
            this.errorLds.Location = new System.Drawing.Point(1085, 588);
            this.errorLds.Name = "errorLds";
            this.errorLds.Size = new System.Drawing.Size(0, 17);
            this.errorLds.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 617);
            this.Controls.Add(this.errorLds);
            this.Controls.Add(this.flatTree);
            this.Controls.Add(this.flatPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel flatPanel;
        private System.Windows.Forms.Label flatTree;
        private System.Windows.Forms.Label errorLds;
    }
}

