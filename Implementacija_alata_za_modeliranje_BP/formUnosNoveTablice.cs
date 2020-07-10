using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implementacija_alata_za_modeliranje_BP
{
    public partial class formNovaTablica : Form
    {
        int brojAtributa = 0;
        public formNovaTablica()
        {
            InitializeComponent();
        }

        private void btnUgasiFormu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formNovaTablica_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void formNovaTablica_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void btnUnosStupca_Click(object sender, EventArgs e)
        {
            NewTableController kontroler = new NewTableController();
            DataTypes dataTypes = new DataTypes();
            dgvStupci.Rows.Add(1);
            dgvStupci.Rows[brojAtributa].Cells[0].Value = kontroler.ProvjeraImena(txtName.Text);
            if (kontroler.CheckDataType(txtType.Text))
            {
                dgvStupci.Rows[brojAtributa].Cells[1].Value=txtType.Text;
            }
            else
            {
                MessageBox.Show("Krivi unos");
            }
            dgvStupci.Rows[brojAtributa].Cells[2].Value = chcboxAutoInc.Checked;
            dgvStupci.Rows[brojAtributa].Cells[3].Value = chcBoxNotNull.Checked;
            dgvStupci.Rows[brojAtributa].Cells[4].Value = chcoxPrimaryKey.Checked;
            brojAtributa++;
            //Reset fields
            txtName.Clear();
            txtType.Clear();
            chcboxAutoInc.Checked = false;
            chcoxPrimaryKey.Checked = false;
            chcBoxNotNull.Checked = false;
            chcboxUnique.Checked = false;
        }


        private void formNovaTablica_Load(object sender, EventArgs e)
        {
            brojAtributa = 0;
        }
    }
}
