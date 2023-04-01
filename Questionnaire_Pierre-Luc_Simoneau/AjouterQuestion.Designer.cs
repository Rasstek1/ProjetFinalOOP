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
            groupBox1 = new GroupBox();
            pnlBonneReponse = new Panel();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioBtnSM = new RadioButton();
            radioBtnVF = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnnuler.Location = new Point(517, 612);
            BtnAnnuler.Margin = new Padding(2);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(176, 44);
            BtnAnnuler.TabIndex = 5;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnAjouter
            // 
            BtnAjouter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAjouter.Location = new Point(270, 612);
            BtnAjouter.Margin = new Padding(2);
            BtnAjouter.Name = "BtnAjouter";
            BtnAjouter.Size = new Size(173, 44);
            BtnAjouter.TabIndex = 4;
            BtnAjouter.Text = "Ajouter";
            BtnAjouter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlBonneReponse);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEnonce);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1003, 569);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter Question";
            // 
            // pnlBonneReponse
            // 
            pnlBonneReponse.Location = new Point(24, 348);
            pnlBonneReponse.Name = "pnlBonneReponse";
            pnlBonneReponse.Size = new Size(945, 215);
            pnlBonneReponse.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 307);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(106, 164);
            txtEnonce.Multiline = true;
            txtEnonce.Name = "txtEnonce";
            txtEnonce.Size = new Size(753, 141);
            txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 224);
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
            groupBox2.Location = new Point(24, 64);
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
            // 
            // AjouterQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnAnnuler);
            Controls.Add(BtnAjouter);
            Controls.Add(groupBox1);
            Name = "AjouterQuestion";
            Size = new Size(1027, 686);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAnnuler;
        private Button BtnAjouter;
        private GroupBox groupBox1;
        private Panel pnlBonneReponse;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBtnSM;
        private RadioButton radioBtnVF;
    }
}
