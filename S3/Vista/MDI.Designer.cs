namespace Vista
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATALOGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERRAMIENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPARTAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUESTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRToolStripMenuItem,
            this.cATALOGOToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.hERRAMIENTASToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            // 
            // cATALOGOToolStripMenuItem
            // 
            this.cATALOGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEPARTAMENTOSToolStripMenuItem,
            this.pUESTOSToolStripMenuItem});
            this.cATALOGOToolStripMenuItem.Name = "cATALOGOToolStripMenuItem";
            this.cATALOGOToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cATALOGOToolStripMenuItem.Text = "CATALOGOS";
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // hERRAMIENTASToolStripMenuItem
            // 
            this.hERRAMIENTASToolStripMenuItem.Name = "hERRAMIENTASToolStripMenuItem";
            this.hERRAMIENTASToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.hERRAMIENTASToolStripMenuItem.Text = "HERRAMIENTAS";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // dEPARTAMENTOSToolStripMenuItem
            // 
            this.dEPARTAMENTOSToolStripMenuItem.Name = "dEPARTAMENTOSToolStripMenuItem";
            this.dEPARTAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dEPARTAMENTOSToolStripMenuItem.Text = "DEPARTAMENTOS";
            this.dEPARTAMENTOSToolStripMenuItem.Click += new System.EventHandler(this.dEPARTAMENTOSToolStripMenuItem_Click);
            // 
            // pUESTOSToolStripMenuItem
            // 
            this.pUESTOSToolStripMenuItem.Name = "pUESTOSToolStripMenuItem";
            this.pUESTOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pUESTOSToolStripMenuItem.Text = "PUESTOS";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPARTAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUESTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERRAMIENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
    }
}