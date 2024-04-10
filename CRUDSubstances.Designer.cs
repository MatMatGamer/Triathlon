namespace Triathlon
{
    partial class CRUDSubstances
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
            tbSeuilMax = new TextBox();
            tbNom = new TextBox();
            cbSubtances = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            cbClasses = new ComboBox();
            SuspendLayout();
            // 
            // tbSeuilMax
            // 
            tbSeuilMax.Location = new Point(77, 146);
            tbSeuilMax.Name = "tbSeuilMax";
            tbSeuilMax.Size = new Size(122, 23);
            tbSeuilMax.TabIndex = 33;
            tbSeuilMax.TextChanged += tbSeuilMax_TextChanged;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(78, 88);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(121, 23);
            tbNom.TabIndex = 31;
            // 
            // cbSubtances
            // 
            cbSubtances.FormattingEnabled = true;
            cbSubtances.Location = new Point(78, 35);
            cbSubtances.Name = "cbSubtances";
            cbSubtances.Size = new Size(121, 23);
            cbSubtances.TabIndex = 29;
            cbSubtances.SelectedIndexChanged += cbSubtances_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 186);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 26;
            label4.Text = "Classe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 70);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 25;
            label3.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 128);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 24;
            label2.Text = "Seuil Max";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 23;
            label1.Text = "Choisir une substance";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Location = new Point(111, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(192, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 128);
            btnCreate.Location = new Point(30, 267);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "Créer";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbClasses
            // 
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(78, 204);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(123, 23);
            cbClasses.TabIndex = 34;
            // 
            // CRUDSubstances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 309);
            Controls.Add(cbClasses);
            Controls.Add(tbSeuilMax);
            Controls.Add(tbNom);
            Controls.Add(cbSubtances);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "CRUDSubstances";
            Text = "Form2";
            Load += CRUDSubstances_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSeuilMax;
        private TextBox tbNom;
        private ComboBox cbSubtances;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private ComboBox cbClasses;
    }
}