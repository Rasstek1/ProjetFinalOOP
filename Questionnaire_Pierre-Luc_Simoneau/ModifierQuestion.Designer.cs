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
            groupBox1 = new GroupBox();
            btnChercher = new Button();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtEnonce = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioBtnQuestionSelectMult = new RadioButton();
            radioBtnVF = new RadioButton();
            pnlReponses = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnnuler.Location = new Point(529, 566);
            btnAnnuler.Margin = new Padding(2);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(162, 45);
            btnAnnuler.TabIndex = 8;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifier.Location = new Point(289, 566);
            btnModifier.Margin = new Padding(2);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(164, 45);
            btnModifier.TabIndex = 7;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChercher);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEnonce);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pnlReponses);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 544);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modifier Question";
            // 
            // btnChercher
            // 
            btnChercher.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChercher.Location = new Point(503, 56);
            btnChercher.Margin = new Padding(2);
            btnChercher.Name = "btnChercher";
            btnChercher.Size = new Size(174, 31);
            btnChercher.TabIndex = 7;
            btnChercher.Text = "Chercher";
            btnChercher.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(270, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 21);
            txtId.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 60);
            label3.Name = "label3";
            label3.Size = new Size(213, 22);
            label3.TabIndex = 5;
            label3.Text = "Saisir l'ID de la question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 353);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 3;
            label2.Text = "Bonnes Réponses";
            // 
            // txtEnonce
            // 
            txtEnonce.Location = new Point(105, 200);
            txtEnonce.Multiline = true;
            txtEnonce.Name = "txtEnonce";
            txtEnonce.Size = new Size(753, 141);
            txtEnonce.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 260);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 1;
            label1.Text = "Énoncé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnQuestionSelectMult);
            groupBox2.Controls.Add(radioBtnVF);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // radioBtnQuestionSelectMult
            // 
            radioBtnQuestionSelectMult.AutoSize = true;
            radioBtnQuestionSelectMult.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnQuestionSelectMult.Location = new Point(452, 42);
            radioBtnQuestionSelectMult.Name = "radioBtnQuestionSelectMult";
            radioBtnQuestionSelectMult.Size = new Size(287, 26);
            radioBtnQuestionSelectMult.TabIndex = 1;
            radioBtnQuestionSelectMult.TabStop = true;
            radioBtnQuestionSelectMult.Text = "Questions Selections Multiples";
            radioBtnQuestionSelectMult.UseVisualStyleBackColor = true;
            // 
            // radioBtnVF
            // 
            radioBtnVF.AutoSize = true;
            radioBtnVF.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnVF.Location = new Point(234, 42);
            radioBtnVF.Name = "radioBtnVF";
            radioBtnVF.Size = new Size(187, 26);
            radioBtnVF.TabIndex = 0;
            radioBtnVF.TabStop = true;
            radioBtnVF.Text = "Question Vrai/Faux";
            radioBtnVF.UseVisualStyleBackColor = true;
            // 
            // pnlReponses
            // 
            pnlReponses.Location = new Point(30, 385);
            pnlReponses.Name = "pnlReponses";
            pnlReponses.Size = new Size(860, 153);
            pnlReponses.TabIndex = 8;
            // 
            // ModifierQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAnnuler);
            Controls.Add(btnModifier);
            Controls.Add(groupBox1);
            Name = "ModifierQuestion";
            Size = new Size(987, 632);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnnuler;
        private Button btnModifier;
        private GroupBox groupBox1;
        private Button btnChercher;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private TextBox txtEnonce;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBtnQuestionSelectMult;
        private RadioButton radioBtnVF;
        private Panel pnlReponses;
    }
}
