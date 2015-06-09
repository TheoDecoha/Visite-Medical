namespace VMpart1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMedecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRATIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRATIONToolStripMenuItem
            // 
            this.aDMINISTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMedecinsToolStripMenuItem,
            this.miseÀJourBDDToolStripMenuItem});
            this.aDMINISTRATIONToolStripMenuItem.Name = "aDMINISTRATIONToolStripMenuItem";
            this.aDMINISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aDMINISTRATIONToolStripMenuItem.Text = "ADMINISTRATION";
            // 
            // gestionDesMedecinsToolStripMenuItem
            // 
            this.gestionDesMedecinsToolStripMenuItem.Name = "gestionDesMedecinsToolStripMenuItem";
            this.gestionDesMedecinsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesMedecinsToolStripMenuItem.Text = "Gestion des medecins";
            this.gestionDesMedecinsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMedecinsToolStripMenuItem_Click);
            // 
            // miseÀJourBDDToolStripMenuItem
            // 
            this.miseÀJourBDDToolStripMenuItem.Name = "miseÀJourBDDToolStripMenuItem";
            this.miseÀJourBDDToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.miseÀJourBDDToolStripMenuItem.Text = "Mise à jour BDD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 416);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMedecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourBDDToolStripMenuItem;
    }
}

