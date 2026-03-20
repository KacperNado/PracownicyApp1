namespace PracownicyApp
{
    public partial class FormAdd : Form
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Wiek { get; private set; }
        public string Stanowisko { get; private set; }

        public FormAdd()
        {
            InitializeComponent();
            this.CancelButton = btnDelete;
            cmbStanowisko.Items.Add("Manager");
            cmbStanowisko.Items.Add("Programista");
            cmbStanowisko.Items.Add("Tester");
            cmbStanowisko.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWiek.Text))
            {
                MessageBox.Show("Podaj wiek!");
                return;
            }
            Imie = txtImie.Text;
            Nazwisko = txtNazwisko.Text;
            Wiek = txtWiek.Text;
            Stanowisko = cmbStanowisko.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbStanowisko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtWiek_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWiek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
