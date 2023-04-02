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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            chkSM = new CheckBox();
            chkVF = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsulter
            // 
            btnConsulter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulter.Location = new Point(404, 136);
            btnConsulter.Margin = new Padding(2);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(125, 30);
            btnConsulter.TabIndex = 7;
            btnConsulter.Text = "Consulter";
            btnConsulter.UseVisualStyleBackColor = true;
            btnConsulter.Click += btnConsulter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnConsulter);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 577);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulter Questions";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 178);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(954, 396);
            dataGridView1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSM);
            groupBox2.Controls.Add(chkVF);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 43);
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
            // ChercherQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ChercherQuestion";
            Size = new Size(993, 614);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsulter;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private CheckBox chkSM;
        private CheckBox chkVF;
    }
}
