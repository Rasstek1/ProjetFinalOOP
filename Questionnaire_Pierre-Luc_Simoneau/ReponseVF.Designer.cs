namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class ReponseVF
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
            panel1 = new Panel();
            rBtnVrai = new RadioButton();
            rBtnFaux = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rBtnFaux);
            panel1.Controls.Add(rBtnVrai);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 154);
            panel1.TabIndex = 0;
            // 
            // rBtnVrai
            // 
            rBtnVrai.AutoSize = true;
            rBtnVrai.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnVrai.Location = new Point(92, 64);
            rBtnVrai.Name = "rBtnVrai";
            rBtnVrai.Size = new Size(68, 34);
            rBtnVrai.TabIndex = 0;
            rBtnVrai.TabStop = true;
            rBtnVrai.Text = "Vrai";
            rBtnVrai.UseVisualStyleBackColor = true;
            // 
            // rBtnFaux
            // 
            rBtnFaux.AutoSize = true;
            rBtnFaux.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnFaux.Location = new Point(258, 64);
            rBtnFaux.Name = "rBtnFaux";
            rBtnFaux.Size = new Size(74, 34);
            rBtnFaux.TabIndex = 1;
            rBtnFaux.TabStop = true;
            rBtnFaux.Text = "Faux";
            rBtnFaux.UseVisualStyleBackColor = true;
            // 
            // ReponseVF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ReponseVF";
            Size = new Size(457, 154);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton rBtnFaux;
        private RadioButton rBtnVrai;
    }
}
