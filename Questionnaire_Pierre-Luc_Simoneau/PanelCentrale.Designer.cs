namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class PanelCentrale
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
            menuStrip1 = new MenuStrip();
            gestionUserToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            chercherToolStripMenuItem = new ToolStripMenuItem();
            gestionQuestionToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem1 = new ToolStripMenuItem();
            supprimerToolStripMenuItem1 = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            chercherToolStripMenuItem1 = new ToolStripMenuItem();
            gestionRésultatToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionUserToolStripMenuItem, gestionQuestionToolStripMenuItem, gestionRésultatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1472, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionUserToolStripMenuItem
            // 
            gestionUserToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, supprimerToolStripMenuItem, modifierToolStripMenuItem, chercherToolStripMenuItem });
            gestionUserToolStripMenuItem.Name = "gestionUserToolStripMenuItem";
            gestionUserToolStripMenuItem.Size = new Size(90, 20);
            gestionUserToolStripMenuItem.Text = "Gestion Users";
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(129, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(129, 22);
            supprimerToolStripMenuItem.Text = "Supprimer";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(129, 22);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // chercherToolStripMenuItem
            // 
            chercherToolStripMenuItem.Name = "chercherToolStripMenuItem";
            chercherToolStripMenuItem.Size = new Size(129, 22);
            chercherToolStripMenuItem.Text = "Chercher";
            chercherToolStripMenuItem.Click += chercherToolStripMenuItem_Click;
            // 
            // gestionQuestionToolStripMenuItem
            // 
            gestionQuestionToolStripMenuItem.CheckOnClick = true;
            gestionQuestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem1, supprimerToolStripMenuItem1, modifierToolStripMenuItem1, chercherToolStripMenuItem1 });
            gestionQuestionToolStripMenuItem.Name = "gestionQuestionToolStripMenuItem";
            gestionQuestionToolStripMenuItem.Size = new Size(115, 20);
            gestionQuestionToolStripMenuItem.Text = "Gestion Questions";
            // 
            // ajouterToolStripMenuItem1
            // 
            ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            ajouterToolStripMenuItem1.Size = new Size(180, 22);
            ajouterToolStripMenuItem1.Text = "Ajouter";
            ajouterToolStripMenuItem1.Click += ajouterToolStripMenuItem1_Click;
            // 
            // supprimerToolStripMenuItem1
            // 
            supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            supprimerToolStripMenuItem1.Size = new Size(180, 22);
            supprimerToolStripMenuItem1.Text = "Supprimer";
            supprimerToolStripMenuItem1.Click += supprimerToolStripMenuItem1_Click;
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(180, 22);
            modifierToolStripMenuItem1.Text = "Modifier";
            // 
            // chercherToolStripMenuItem1
            // 
            chercherToolStripMenuItem1.Name = "chercherToolStripMenuItem1";
            chercherToolStripMenuItem1.Size = new Size(180, 22);
            chercherToolStripMenuItem1.Text = "Chercher";
            // 
            // gestionRésultatToolStripMenuItem
            // 
            gestionRésultatToolStripMenuItem.Name = "gestionRésultatToolStripMenuItem";
            gestionRésultatToolStripMenuItem.Size = new Size(104, 20);
            gestionRésultatToolStripMenuItem.Text = "Gestion Résultat";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1472, 919);
            panel1.TabIndex = 1;
            // 
            // PanelCentrale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 943);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PanelCentrale";
            Text = "PanelCentrale";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionUserToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem chercherToolStripMenuItem;
        private ToolStripMenuItem gestionQuestionToolStripMenuItem;
        private ToolStripMenuItem gestionRésultatToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem1;
        private ToolStripMenuItem supprimerToolStripMenuItem1;
        private ToolStripMenuItem modifierToolStripMenuItem1;
        private ToolStripMenuItem chercherToolStripMenuItem1;
        private Panel panel1;
    }
}