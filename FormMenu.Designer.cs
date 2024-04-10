namespace Triathlon
{
    partial class FormMenu
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
            btn_crudClubs = new Button();
            lbl_Menu = new Label();
            button1 = new Button();
            btn_crudSubstance = new Button();
            SuspendLayout();
            // 
            // btn_crudClubs
            // 
            btn_crudClubs.BackColor = Color.CornflowerBlue;
            btn_crudClubs.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_crudClubs.Location = new Point(12, 112);
            btn_crudClubs.Name = "btn_crudClubs";
            btn_crudClubs.Size = new Size(123, 49);
            btn_crudClubs.TabIndex = 0;
            btn_crudClubs.Text = "Crud Clubs";
            btn_crudClubs.UseVisualStyleBackColor = false;
            btn_crudClubs.Click += btn_crudClubs_Click;
            // 
            // lbl_Menu
            // 
            lbl_Menu.AutoSize = true;
            lbl_Menu.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbl_Menu.Location = new Point(111, 9);
            lbl_Menu.Name = "lbl_Menu";
            lbl_Menu.Size = new Size(127, 54);
            lbl_Menu.TabIndex = 1;
            lbl_Menu.Text = "Menu";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(148, 66);
            button1.Name = "button1";
            button1.Size = new Size(152, 49);
            button1.TabIndex = 2;
            button1.Text = "Crud Licences";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_crudSubstance
            // 
            btn_crudSubstance.BackColor = Color.DarkOrange;
            btn_crudSubstance.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_crudSubstance.Location = new Point(91, 167);
            btn_crudSubstance.Name = "btn_crudSubstance";
            btn_crudSubstance.Size = new Size(196, 49);
            btn_crudSubstance.TabIndex = 3;
            btn_crudSubstance.Text = "Crud Substances";
            btn_crudSubstance.UseVisualStyleBackColor = false;
            btn_crudSubstance.Click += btn_crudSubstance_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 228);
            Controls.Add(btn_crudSubstance);
            Controls.Add(button1);
            Controls.Add(lbl_Menu);
            Controls.Add(btn_crudClubs);
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_crudClubs;
        private Label lbl_Menu;
        private Button button1;
        private Button btn_crudSubstance;
    }
}