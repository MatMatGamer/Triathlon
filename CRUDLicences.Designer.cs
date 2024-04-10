namespace Triathlon
{
    partial class CRUDLicences
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
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbClub = new ComboBox();
            tbCP = new TextBox();
            tbNom = new TextBox();
            tbTel = new TextBox();
            tbRue = new TextBox();
            tbVille = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 128);
            btnCreate.Location = new Point(47, 415);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Créer";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(209, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Location = new Point(128, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Choisir un Club";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 154);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 5;
            label2.Text = "Rue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 96);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Nom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 212);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "Ville";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 270);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Code Postal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 328);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "Téléphone";
            // 
            // cbClub
            // 
            cbClub.FormattingEnabled = true;
            cbClub.Location = new Point(104, 56);
            cbClub.Name = "cbClub";
            cbClub.Size = new Size(121, 23);
            cbClub.TabIndex = 14;
            cbClub.SelectedIndexChanged += cbClub_SelectedIndexChanged;
            // 
            // tbCP
            // 
            tbCP.Location = new Point(104, 288);
            tbCP.Name = "tbCP";
            tbCP.Size = new Size(121, 23);
            tbCP.TabIndex = 15;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(104, 114);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(121, 23);
            tbNom.TabIndex = 16;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(104, 346);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(121, 23);
            tbTel.TabIndex = 17;
            // 
            // tbRue
            // 
            tbRue.Location = new Point(103, 172);
            tbRue.Name = "tbRue";
            tbRue.Size = new Size(122, 23);
            tbRue.TabIndex = 18;
            // 
            // tbVille
            // 
            tbVille.Location = new Point(103, 230);
            tbVille.Name = "tbVille";
            tbVille.Size = new Size(122, 23);
            tbVille.TabIndex = 19;
            // 
            // CRUDLicences
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(tbVille);
            Controls.Add(tbRue);
            Controls.Add(tbTel);
            Controls.Add(tbNom);
            Controls.Add(tbCP);
            Controls.Add(cbClub);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "CRUDLicences";
            Text = "CRUD Licences";
            Load += CRUDLicences_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbClub;
        private TextBox tbCP;
        private TextBox tbNom;
        private TextBox tbTel;
        private TextBox tbRue;
        private TextBox tbVille;
    }
}