namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class UserPanel
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
            panel1 = new Panel();
            label3 = new Label();
            labelUserName = new Label();
            label1 = new Label();
            txtNbrQuestions = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtScore = new TextBox();
            btnDemarrer = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(98, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 55);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(146, 14);
            label3.Name = "label3";
            label3.Size = new Size(499, 30);
            label3.TabIndex = 0;
            label3.Text = "Bienvenu à la création d'un nouveau questionnaire";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.Location = new Point(12, 9);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(161, 30);
            labelUserName.TabIndex = 11;
            labelUserName.Text = "labelUserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 168);
            label1.Name = "label1";
            label1.Size = new Size(310, 28);
            label1.TabIndex = 12;
            label1.Text = "Choisissez le nombre de questions";
            // 
            // txtNbrQuestions
            // 
            txtNbrQuestions.Location = new Point(618, 173);
            txtNbrQuestions.Name = "txtNbrQuestions";
            txtNbrQuestions.Size = new Size(46, 23);
            txtNbrQuestions.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 250);
            label2.Name = "label2";
            label2.Size = new Size(273, 28);
            label2.TabIndex = 14;
            label2.Text = "Choisissez le score de passage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 278);
            label4.Name = "label4";
            label4.Size = new Size(251, 15);
            label4.TabIndex = 15;
            label4.Text = "(Chaque bonne réponse vous donne un point)";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(618, 258);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(46, 23);
            txtScore.TabIndex = 16;
            // 
            // btnDemarrer
            // 
            btnDemarrer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDemarrer.Location = new Point(360, 332);
            btnDemarrer.Name = "btnDemarrer";
            btnDemarrer.Size = new Size(252, 50);
            btnDemarrer.TabIndex = 17;
            btnDemarrer.Text = "Démarrer";
            btnDemarrer.UseVisualStyleBackColor = true;
            btnDemarrer.Click += btnDemarrer_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 982);
            Controls.Add(btnDemarrer);
            Controls.Add(txtScore);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtNbrQuestions);
            Controls.Add(label1);
            Controls.Add(labelUserName);
            Controls.Add(panel1);
            Name = "UserPanel";
            Text = "UserPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label labelUserName;
        private Label label1;
        private TextBox txtNbrQuestions;
        private Label label2;
        private Label label4;
        private TextBox txtScore;
        private Button btnDemarrer;
    }
}