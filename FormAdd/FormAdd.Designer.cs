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
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(133, 311);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(201, 62);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(125, 27);
            txtImie.TabIndex = 1;
            txtImie.TextChanged += txtImie_TextChanged;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(201, 105);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(125, 27);
            txtNazwisko.TabIndex = 2;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(201, 138);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(125, 27);
            txtWiek.TabIndex = 3;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Location = new Point(201, 197);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(151, 28);
            cmbStanowisko.TabIndex = 4;
            cmbStanowisko.SelectedIndexChanged += cmbStanowisko_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 5;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 105);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 145);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 200);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "Stanowisko";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStanowisko);
            Controls.Add(txtWiek);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(btnOK);
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
    }
}
