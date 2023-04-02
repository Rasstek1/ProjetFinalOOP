namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class ModifierQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAnnuler = new Button();
            btnModifier = new Button();
            btnChercher = new Button();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbSM = new RadioButton();
            rbVF = new RadioButton();
            pnlReponses = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnnuler.Location = new Point(500, 567);
            btnAnnuler.Margin = new Padding(2);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(162, 45);
            btnAnnuler.TabIndex = 8;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifier.Location = new Point(260, 567);
            btnModifier.Margin = new Padding(2);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(164, 45);
            btnModifier.TabIndex = 7;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnChercher
            // 
            btnChercher.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChercher.Location = new Point(505, 66);
            btnChercher.Margin = new Padding(2);
            btnChercher.Name = "btnChercher";
            btnChercher.Size = new Size(174, 31);
            btnChercher.TabIndex = 7;
            btnChercher.Text = "Chercher";
            btnChercher.UseVisualStyleBackColor = true;
            btnChercher.Click += btnChercher_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(272, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 21);
            txtId.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 70);
            label3.Name = "label3";
            label3.Size = new Size(213, 22);
            label3.TabIndex = 5;
            label3.Text = "Saisir l'ID de la question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 363);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(107, 210);
            txtEnonce.Multiline = true;
            txtEnonce.Name = "txtEnonce";
            txtEnonce.Size = new Size(753, 141);
            txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 270);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 1;
            label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbSM);
            groupBox2.Controls.Add(rbVF);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(26, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // rbSM
            // 
            rbSM.AutoSize = true;
            rbSM.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbSM.Location = new Point(452, 42);
            rbSM.Name = "rbSM";
            rbSM.Size = new Size(287, 26);
            rbSM.TabIndex = 1;
            rbSM.TabStop = true;
            rbSM.Text = "Questions Selections Multiples";
            rbSM.UseVisualStyleBackColor = true;
            // 
            // rbVF
            // 
            rbVF.AutoSize = true;
            rbVF.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbVF.Location = new Point(234, 42);
            rbVF.Name = "rbVF";
            rbVF.Size = new Size(187, 26);
            rbVF.TabIndex = 0;
            rbVF.TabStop = true;
            rbVF.Text = "Question Vrai/Faux";
            rbVF.UseVisualStyleBackColor = true;
            // 
            // pnlReponses
            // 
            pnlReponses.Location = new Point(32, 395);
            pnlReponses.Name = "pnlReponses";
            pnlReponses.Size = new Size(828, 153);
            pnlReponses.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(130, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 38);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(192, 3);
            label4.Name = "label4";
            label4.Size = new Size(231, 30);
            label4.TabIndex = 0;
            label4.Text = "Modifier une Question";
            // 
            // ModifierQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnChercher);
            Controls.Add(btnAnnuler);
            Controls.Add(txtId);
            Controls.Add(btnModifier);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(txtEnonce);
            Controls.Add(pnlReponses);
            Controls.Add(label1);
            Name = "ModifierQuestion";
            Size = new Size(886, 641);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnnuler;
        private Button btnModifier;
        private Button btnChercher;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbSM;
        private RadioButton rbVF;
        private Panel pnlReponses;
        private Panel panel1;
        private Label label4;
    }
}
