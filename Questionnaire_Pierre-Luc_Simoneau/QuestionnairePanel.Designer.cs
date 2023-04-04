namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class QuestionnairePanel
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
            label1 = new Label();
            pnlReponses = new Panel();
            lblCount = new Label();
            btnConfirmer = new Button();
            lblEnonce = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 45);
            label1.TabIndex = 0;
            label1.Text = "Questionnaire";
            // 
            // pnlReponses
            // 
            pnlReponses.Location = new Point(12, 250);
            pnlReponses.Name = "pnlReponses";
            pnlReponses.Size = new Size(1140, 289);
            pnlReponses.TabIndex = 1;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.Location = new Point(12, 22);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(132, 32);
            lblCount.TabIndex = 0;
            lblCount.Text = "Question #";
            // 
            // btnConfirmer
            // 
            btnConfirmer.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmer.Location = new Point(456, 561);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(248, 48);
            btnConfirmer.TabIndex = 2;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // lblEnonce
            // 
            lblEnonce.AutoSize = true;
            lblEnonce.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnonce.Location = new Point(12, 77);
            lblEnonce.Name = "lblEnonce";
            lblEnonce.Size = new Size(92, 32);
            lblEnonce.TabIndex = 3;
            lblEnonce.Text = "Enonce";
            // 
            // QuestionnairePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 621);
            Controls.Add(lblEnonce);
            Controls.Add(btnConfirmer);
            Controls.Add(pnlReponses);
            Controls.Add(lblCount);
            Controls.Add(label1);
            Name = "QuestionnairePanel";
            Text = "QuestionnairePanel";
            Load += QuestionnairePanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlReponses;
        private Label lblCount;
        private Button btnConfirmer;
        private Label lblEnonce;
    }
}