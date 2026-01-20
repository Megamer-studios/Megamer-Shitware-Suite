using System.Text;

namespace ShittyExcel
{
    public partial class Form1 : Form
    {
        public Form1(string fileLoc)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileLoc))
            {
                string[] lines = System.IO.File.ReadAllLines(fileLoc);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                if (lines.Length > 0)
                {
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        dataGridView1.Columns.Add(header, header);
                    }
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] cells = lines[i].Split(',');
                        dataGridView1.Rows.Add(cells);
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.Title = "Save DataGridView as CSV";
            sfd.ShowDialog();
            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                StringBuilder csvData = new StringBuilder();

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    csvData.Append(dataGridView1.Columns[i].HeaderText);
                    if (i < dataGridView1.Columns.Count - 1)
                        csvData.Append(",");
                }
                csvData.AppendLine();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        csvData.Append(row.Cells[i].Value?.ToString());
                        if (i < dataGridView1.Columns.Count - 1)
                            csvData.Append(",");
                    }
                    csvData.AppendLine();
                }
                System.IO.File.WriteAllText(sfd.FileName, csvData.ToString());
                MessageBox.Show("Data saved successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ofd.Title = "Open CSV file";
            ofd.FilterIndex = 0;
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                if (lines.Length > 0)
                {
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        dataGridView1.Columns.Add(header, header);
                    }
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] cells = lines[i].Split(',');
                        dataGridView1.Rows.Add(cells);
                    }
                }
            }
        }

        private void collumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput ti2 = new TextInput("New Column", "Column Header:");
            ti2.ShowDialog();
            TextInput ti = new TextInput("New collumn", "Collumn name:");

            ti.ShowDialog();

            if (!string.IsNullOrEmpty(ti.InputText) && !string.IsNullOrEmpty(ti2.InputText))
            {
                dataGridView1.Columns.Add(ti.InputText, ti2.InputText);
            }
            else
            {
                MessageBox.Show("Column creation cancelled or invalid input.", "Collumn creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = null;

                }
            }
            else
            {
                MessageBox.Show("No cells selected. Please select cells to remove.", "No Cells Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeCollumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (var cell in dataGridView1.SelectedCells)
                {
                    try
                    {
                        dataGridView1.Columns.RemoveAt(((DataGridViewCell)cell).ColumnIndex);

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        // Ignore exception if column index is out of range
                    }
                }
            }
            else
            {
                MessageBox.Show("No columns selected. Please select columns to remove.", "No Columns Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
