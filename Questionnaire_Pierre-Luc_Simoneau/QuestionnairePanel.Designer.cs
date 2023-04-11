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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReponses = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questionnaire";
            // 
            // pnlReponses
            // 
            this.pnlReponses.Location = new System.Drawing.Point(12, 250);
            this.pnlReponses.Name = "pnlReponses";
            this.pnlReponses.Size = new System.Drawing.Size(1140, 289);
            this.pnlReponses.TabIndex = 1;
            this.pnlReponses.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReponses_Paint);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(12, 22);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(132, 32);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Question #";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmer.Location = new System.Drawing.Point(456, 561);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(248, 48);
            this.btnConfirmer.TabIndex = 2;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnonce.Location = new System.Drawing.Point(12, 77);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(92, 32);
            this.lblEnonce.TabIndex = 3;
            this.lblEnonce.Text = "Enonce";
            // 
            // QuestionnairePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 621);
            this.Controls.Add(this.lblEnonce);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.pnlReponses);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Name = "QuestionnairePanel";
            this.Text = "QuestionnairePanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel pnlReponses;
        private Label lblCount;
        private Button btnConfirmer;
        private Label lblEnonce;
    }
}