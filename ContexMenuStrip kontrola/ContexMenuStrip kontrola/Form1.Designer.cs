
namespace ContexMenuStrip_kontrola
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
            this.components = new System.ComponentModel.Container();
            this.textBoxLijevo = new System.Windows.Forms.TextBox();
            this.textBoxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLijevo
            // 
            this.textBoxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxLijevo.Location = new System.Drawing.Point(125, 129);
            this.textBoxLijevo.Name = "textBoxLijevo";
            this.textBoxLijevo.Size = new System.Drawing.Size(186, 22);
            this.textBoxLijevo.TabIndex = 0;
            this.textBoxLijevo.TextChanged += new System.EventHandler(this.textBoxLijevo_TextChanged);
            // 
            // textBoxDesno
            // 
            this.textBoxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxDesno.Location = new System.Drawing.Point(406, 129);
            this.textBoxDesno.Name = "textBoxDesno";
            this.textBoxDesno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDesno.Size = new System.Drawing.Size(217, 22);
            this.textBoxDesno.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoDesnoToolStripMenuItem,
            this.desnoLijevoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // lijevoDesnoToolStripMenuItem
            // 
            this.lijevoDesnoToolStripMenuItem.Name = "lijevoDesnoToolStripMenuItem";
            this.lijevoDesnoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.lijevoDesnoToolStripMenuItem.Text = "LijevoDesno";
            this.lijevoDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoDesnoToolStripMenuItem_Click);
            // 
            // desnoLijevoToolStripMenuItem
            // 
            this.desnoLijevoToolStripMenuItem.Name = "desnoLijevoToolStripMenuItem";
            this.desnoLijevoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.desnoLijevoToolStripMenuItem.Text = "DesnoLijevo";
            this.desnoLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoLijevoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDesno);
            this.Controls.Add(this.textBoxLijevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLijevo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxDesno;
        private System.Windows.Forms.ToolStripMenuItem lijevoDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoLijevoToolStripMenuItem;
    }
}

