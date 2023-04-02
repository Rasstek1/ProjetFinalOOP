namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class AjouterQuestion
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
            BtnAnnuler = new Button();
            BtnAjouter = new Button();
            pnlBonneReponse = new Panel();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioBtnSM = new RadioButton();
            radioBtnVF = new RadioButton();
            panel1 = new Panel();
            label3 = new Label();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnnuler.Location = new Point(477, 570);
            BtnAnnuler.Margin = new Padding(2);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(176, 44);
            BtnAnnuler.TabIndex = 5;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // BtnAjouter
            // 
            BtnAjouter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAjouter.Location = new Point(230, 570);
            BtnAjouter.Margin = new Padding(2);
            BtnAjouter.Name = "BtnAjouter";
            BtnAjouter.Size = new Size(173, 44);
            BtnAjouter.TabIndex = 4;
            BtnAjouter.Text = "Ajouter";
            BtnAjouter.UseVisualStyleBackColor = true;
            BtnAjouter.Click += BtnAjouter_Click;
            // 
            // pnlBonneReponse
            // 
            pnlBonneReponse.Location = new Point(33, 378);
            pnlBonneReponse.Name = "pnlBonneReponse";
            pnlBonneReponse.Size = new Size(505, 187);
            pnlBonneReponse.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 353);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(115, 194);
            txtEnonce.Multiline = true;
            txtEnonce.Name = "txtEnonce";
            txtEnonce.Size = new Size(753, 141);
            txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 254);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 1;
            label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnSM);
            groupBox2.Controls.Add(radioBtnVF);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(33, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 94);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnSM
            // 
            radioBtnSM.AutoSize = true;
            radioBtnSM.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnSM.Location = new Point(451, 41);
            radioBtnSM.Name = "radioBtnSM";
            radioBtnSM.Size = new Size(287, 26);
            radioBtnSM.TabIndex = 1;
            radioBtnSM.TabStop = true;
            radioBtnSM.Text = "Questions Selections Multiples";
            radioBtnSM.UseVisualStyleBackColor = true;
            radioBtnSM.CheckedChanged += radioBtnSM_CheckedChanged;
            // 
            // radioBtnVF
            // 
            radioBtnVF.AutoSize = true;
            radioBtnVF.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnVF.Location = new Point(234, 41);
            radioBtnVF.Name = "radioBtnVF";
            radioBtnVF.Size = new Size(187, 26);
            radioBtnVF.TabIndex = 0;
            radioBtnVF.TabStop = true;
            radioBtnVF.Text = "Question Vrai/Faux";
            radioBtnVF.UseVisualStyleBackColor = true;
            radioBtnVF.CheckedChanged += radioBtnVF_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(127, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 38);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(192, 3);
            label3.Name = "label3";
            label3.Size = new Size(219, 30);
            label3.TabIndex = 0;
            label3.Text = "Ajouter une Question";
            // 
            // AjouterQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlBonneReponse);
            Controls.Add(BtnAnnuler);
            Controls.Add(label2);
            Controls.Add(BtnAjouter);
            Controls.Add(txtEnonce);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "AjouterQuestion";
            Size = new Size(893, 849);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnnuler;
        private Button BtnAjouter;
        private Panel pnlBonneReponse;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBtnSM;
        private RadioButton radioBtnVF;
        private Panel panel1;
        private Label label3;
    }
}
