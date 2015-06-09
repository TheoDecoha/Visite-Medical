using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VMpart1
{
    public partial class Visite : Form
    {
        public Visite(DataView dvviste)
        {
            InitializeComponent();
            chargedgv(dvviste);
        }

        private void visite_Load(object sender, EventArgs e)
        {

        }

        public void chargedgv(DataView dv1)
        {
            dataGridView1.DataSource = dv1;
            int vwidth = dataGridView1.RowHeadersWidth;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Visible)
                    vwidth = vwidth + dataGridView1.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, false);
            }
            dataGridView1.Width = vwidth;
            if (dataGridView1.ScrollBars.Equals(ScrollBars.Both) | dataGridView1.ScrollBars.Equals(ScrollBars.Vertical))
            {
                dataGridView1.Width += 20;
            }
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            if (e.ColumnIndex == 1)
            {
                if (e.FormattedValue.ToString().Trim().Length == 0)
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Le nom du médecin ne peut être une valeur nulle";
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
            }
        }
        private void dataGridView1_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView1.Rows[e.Row.Index].ErrorText))
            {
                MessageBox.Show(dataGridView1.Rows[e.Row.Index].ErrorText);
            }
        }
        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Length == 0)
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = "Le nom ne peut être une valeur nulle";
                e.Cancel = true;
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = "";
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Validez la suppression de la ligne", "Suppression médecin", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        public void filtre(int nummed)
        {
            string Filter = "num_medecin= '" + nummed + "'";
        }

    }
}
