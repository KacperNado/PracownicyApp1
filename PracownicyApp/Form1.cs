using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PracownicyApp
{
    public partial class Form1 : Form
    {
        private DataTable table = new DataTable();
        private int currentID = 1;

        public Form1()
        {
            InitializeComponent();

            // Tworzenie kolumn
            table.Columns.Add("ID");
            table.Columns.Add("Imie");
            table.Columns.Add("Nazwisko");
            table.Columns.Add("Wiek");
            table.Columns.Add("Stanowisko");

            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                table.Rows.Add(
                    currentID++,
                    formAdd.Imie,
                    formAdd.Nazwisko,
                    formAdd.Wiek,
                    formAdd.Stanowisko
                );
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV (*.csv)|*.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string csv = "";

                // nag³ówki
                var headers = table.Columns.Cast<DataColumn>();
                csv += string.Join(",", headers.Select(c => c.ColumnName)) + "\n";

                // dane
                foreach (DataRow row in table.Rows)
                {
                    csv += string.Join(",", row.ItemArray) + "\n";
                }

                File.WriteAllText(save.FileName, csv);
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "CSV (*.csv)|*.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                table.Rows.Clear();

                var lines = File.ReadAllLines(open.FileName);

                for (int i = 1; i < lines.Length; i++)
                {
                    var values = lines[i].Split(',');
                    table.Rows.Add(values);
                }
            }
        }
    }
}