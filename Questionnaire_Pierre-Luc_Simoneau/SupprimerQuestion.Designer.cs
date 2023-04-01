namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class SupprimerQuestion
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnSupprimer = new Button();
            txtId = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 263);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "SUPPRIMER UNE QUESTION";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(19, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 154);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(167, 87);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(117, 41);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(215, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 21);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(175, 18);
            label1.TabIndex = 0;
            label1.Text = "Saisir l'ID de la question";
            // 
            // SupprimerQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "SupprimerQuestion";
            Size = new Size(577, 300);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSupprimer;
        private TextBox txtId;
        private Label label1;
    }
}
