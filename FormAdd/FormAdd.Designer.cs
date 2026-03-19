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
            txtImie.Location = new Point(104, 52);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(125, 27);
            txtImie.TabIndex = 1;
            txtImie.TextChanged += txtImie_TextChanged;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(104, 95);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(125, 27);
            txtNazwisko.TabIndex = 2;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(102, 138);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(125, 27);
            txtWiek.TabIndex = 3;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Location = new Point(102, 193);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(151, 28);
            cmbStanowisko.TabIndex = 4;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
