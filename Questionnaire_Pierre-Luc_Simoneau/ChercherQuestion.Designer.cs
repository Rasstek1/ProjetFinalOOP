namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class ChercherQuestion
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
            btnConsulter = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            chkSM = new CheckBox();
            chkVF = new CheckBox();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsulter
            // 
            btnConsulter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulter.Location = new Point(403, 157);
            btnConsulter.Margin = new Padding(2);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(125, 30);
            btnConsulter.TabIndex = 7;
            btnConsulter.Text = "Consulter";
            btnConsulter.UseVisualStyleBackColor = true;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 202);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1027, 485);
            dataGridView1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSM);
            groupBox2.Controls.Add(chkVF);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(17, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(906, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choisir le type de questions";
            // 
            // chkSM
            // 
            chkSM.AutoSize = true;
            chkSM.Location = new Point(489, 41);
            chkSM.Name = "chkSM";
            chkSM.Size = new Size(252, 22);
            chkSM.TabIndex = 1;
            chkSM.Text = "Questions Selection Multiple";
            chkSM.UseVisualStyleBackColor = true;
            // 
            // chkVF
            // 
            chkVF.AutoSize = true;
            chkVF.Location = new Point(215, 41);
            chkVF.Name = "chkVF";
            chkVF.Size = new Size(137, 22);
            chkVF.TabIndex = 0;
            chkVF.Text = "Questions V/F";
            chkVF.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(151, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 38);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(168, 4);
            label3.Name = "label3";
            label3.Size = new Size(302, 30);
            label3.TabIndex = 0;
            label3.Text = "Chercher une/des Question(s)";
            // 
            // ChercherQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnConsulter);
            Controls.Add(groupBox2);
            Name = "ChercherQuestion";
            Size = new Size(1061, 707);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsulter;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private CheckBox chkSM;
        private CheckBox chkVF;
        private Panel panel1;
        private Label label3;
    }
}
