namespace PracownicyApp
{
    partial class FormAdd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new Button();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtWiek = new TextBox();
            cmbStanowisko = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(116, 233);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(176, 46);
            txtImie.Margin = new Padding(3, 2, 3, 2);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(110, 23);
            txtImie.TabIndex = 1;
            txtImie.TextChanged += txtImie_TextChanged;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(176, 79);
            txtNazwisko.Margin = new Padding(3, 2, 3, 2);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(110, 23);
            txtNazwisko.TabIndex = 2;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(176, 104);
            txtWiek.Margin = new Padding(3, 2, 3, 2);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(110, 23);
            txtWiek.TabIndex = 3;
            txtWiek.TextChanged += txtWiek_TextChanged;
            txtWiek.KeyPress += txtWiek_KeyPress;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Location = new Point(176, 148);
            cmbStanowisko.Margin = new Padding(3, 2, 3, 2);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(133, 23);
            cmbStanowisko.TabIndex = 4;
            cmbStanowisko.SelectedIndexChanged += cmbStanowisko_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 46);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 109);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 150);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Stanowisko";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(251, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Anuluj";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStanowisko);
            Controls.Add(txtWiek);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(btnOK);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdd";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtWiek;
        private ComboBox cmbStanowisko;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDelete;
    }
}
