namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class ChercherUser
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnChercher = new Button();
            txtTelephone = new TextBox();
            txtVille = new TextBox();
            txtProvince = new TextBox();
            txtCP = new TextBox();
            chkTelephone = new CheckBox();
            chkVille = new CheckBox();
            chkProvince = new CheckBox();
            chkCP = new CheckBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(214, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 38);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 3);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 0;
            label1.Text = "Chercher des utilisateurs";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(995, 278);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChercher);
            groupBox2.Controls.Add(txtTelephone);
            groupBox2.Controls.Add(txtVille);
            groupBox2.Controls.Add(txtProvince);
            groupBox2.Controls.Add(txtCP);
            groupBox2.Controls.Add(chkTelephone);
            groupBox2.Controls.Add(chkVille);
            groupBox2.Controls.Add(chkProvince);
            groupBox2.Controls.Add(chkCP);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(21, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(996, 215);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir un/des critères de recherche";
            // 
            // btnChercher
            // 
            btnChercher.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChercher.Location = new Point(377, 177);
            btnChercher.Name = "btnChercher";
            btnChercher.Size = new Size(211, 32);
            btnChercher.TabIndex = 8;
            btnChercher.Text = "Chercher";
            btnChercher.UseVisualStyleBackColor = true;
            btnChercher.Click += btnChercher_Click;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(662, 130);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(235, 26);
            txtTelephone.TabIndex = 7;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(662, 45);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(235, 26);
            txtVille.TabIndex = 6;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(170, 130);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(235, 26);
            txtProvince.TabIndex = 5;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(170, 45);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(235, 26);
            txtCP.TabIndex = 4;
            // 
            // chkTelephone
            // 
            chkTelephone.AutoSize = true;
            chkTelephone.Location = new Point(519, 134);
            chkTelephone.Name = "chkTelephone";
            chkTelephone.Size = new Size(111, 22);
            chkTelephone.TabIndex = 3;
            chkTelephone.Text = "Téléphone";
            chkTelephone.UseVisualStyleBackColor = true;
            // 
            // chkVille
            // 
            chkVille.AutoSize = true;
            chkVille.Location = new Point(519, 49);
            chkVille.Name = "chkVille";
            chkVille.Size = new Size(60, 22);
            chkVille.TabIndex = 2;
            chkVille.Text = "Ville";
            chkVille.UseVisualStyleBackColor = true;
            // 
            // chkProvince
            // 
            chkProvince.AutoSize = true;
            chkProvince.Location = new Point(38, 134);
            chkProvince.Name = "chkProvince";
            chkProvince.Size = new Size(98, 22);
            chkProvince.TabIndex = 1;
            chkProvince.Text = "Province";
            chkProvince.UseVisualStyleBackColor = true;
            // 
            // chkCP
            // 
            chkCP.AutoSize = true;
            chkCP.Location = new Point(38, 49);
            chkCP.Name = "chkCP";
            chkCP.Size = new Size(123, 22);
            chkCP.TabIndex = 0;
            chkCP.Text = "Code Postal";
            chkCP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1040, 633);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // ChercherUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ChercherUser";
            Size = new Size(1215, 698);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnChercher;
        private TextBox txtTelephone;
        private TextBox txtVille;
        private TextBox txtProvince;
        private TextBox txtCP;
        private CheckBox chkTelephone;
        private CheckBox chkVille;
        private CheckBox chkProvince;
        private CheckBox chkCP;
        private GroupBox groupBox1;
    }
}
