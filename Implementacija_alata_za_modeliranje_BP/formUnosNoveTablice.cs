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
        string tableName1;
        string dirPath1;
        string projectName1;
        bool reload1;
        public formNovaTablica()
        {
            InitializeComponent();
        }

        public formNovaTablica(string tableName, string dirPath, string projectName)
        {
            InitializeComponent();
            tableName1 = tableName;
            dirPath1 = dirPath;
            projectName1 = projectName;
        }

        public formNovaTablica(string tableName,string projectName, bool reload)
        {
            InitializeComponent();

            tableName1 = tableName;
            projectName1 = projectName;
            reload1 = reload;

            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dirPath1 = $@"{dirPath}\Projects\"+projectName+"\\"+tableName;

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
            if (kontroler.CheckForSameAtributes(dirPath1, txtName.Text))
            {
                if (kontroler.CheckTextInput(txtName.Text) && kontroler.CheckDataType(txtType.Text))
                {
                    if (chcBoxNotNull.Checked == false && chcoxPrimaryKey.Checked == true)
                    {
                        MessageBox.Show("Primary key can not be null!");
                    }
                    else if ((kontroler.CheckPrimaryKey(dirPath1) && chcoxPrimaryKey.Checked == true))
                    {
                        MessageBox.Show("Primary key already exists!");
                    }
                    else if (kontroler.CheckPrimaryKeyType(txtType.Text) && chcoxPrimaryKey.Checked == true)
                    {
                        MessageBox.Show("Primary key is wrong type!");
                    }
                    else
                    {
                        dgvStupci.Rows.Add(1);
                        dgvStupci.Rows[brojAtributa].Cells[0].Value = kontroler.ProvjeraImena(txtName.Text);
                        dgvStupci.Rows[brojAtributa].Cells[1].Value = txtType.Text;
                        dgvStupci.Rows[brojAtributa].Cells[2].Value = chcboxAutoInc.Checked;
                        dgvStupci.Rows[brojAtributa].Cells[3].Value = chcBoxNotNull.Checked;
                        dgvStupci.Rows[brojAtributa].Cells[4].Value = chcoxPrimaryKey.Checked;
                        brojAtributa++;
                        string foreingName = string.Empty;
                        foreingName += txtForeignName.Text;
                        kontroler.InsertDataIntoTextFile(dirPath1, dgvStupci.NewRowIndex, kontroler.ProvjeraImena(txtName.Text), txtType.Text, chcBoxNotNull.Checked, chcboxAutoInc.Checked, chcboxUnique.Checked, chcoxPrimaryKey.Checked, foreingName);
                        cmbColumnAtribut.DataSource = kontroler.ListOfTableAtributesForPrimaryKey(dirPath1);
                        cmbCurrentTableAtributes.DataSource = kontroler.ListOfAtributesInCurrentTable(dirPath1);
                        if (chcoxPrimaryKey.Checked)
                        {

                             dgvKeys.Rows.Add(1);
                             dgvKeys.Rows[rowIndex].Cells[0].Value = kontroler.ProvjeraImena(txtName.Text);
                             dgvKeys.Rows[rowIndex].Cells[1].Value = txtType.Text;
                             dgvKeys.Rows[rowIndex].Cells[2].Value = true;
                             rowIndex++;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Wrong input");
                }
            }
            else
            {
                MessageBox.Show("Attribute already exists");
            }
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
            rowIndex = 0;
            rowIndexForFK = 0;
            txtTableName.Text = tableName1.Replace(" ", "_");
            txtKeyNameTable.Text = tableName1.Replace(" ", "_");
            NewTableController controller = new NewTableController();
            LoadProjects loadProjects = new LoadProjects();
        
           

            if (reload1)
            {
                foreach (var item in loadProjects.OpenSpecificTable(dirPath1))
                {
                    string[] parts = item.Split(',');
                    dgvStupci.Rows.Add(1);
                    dgvStupci.Rows[brojAtributa].Cells[0].Value = parts[0].ToString();
                    dgvStupci.Rows[brojAtributa].Cells[1].Value = parts[1].ToString();
                    if (parts[3].ToString() == "True")
                        dgvStupci.Rows[brojAtributa].Cells[2].Value = true;
                    else
                        dgvStupci.Rows[brojAtributa].Cells[2].Value = false;
                    if (parts[2].ToString() == "True")
                        dgvStupci.Rows[brojAtributa].Cells[3].Value = true;
                    else
                        dgvStupci.Rows[brojAtributa].Cells[3].Value = false;
                    if (parts[4].ToString() == "True")
                    {
                        dgvKeys.Rows.Add(1);
                        dgvStupci.Rows[brojAtributa].Cells[4].Value = true;
                        dgvKeys.Rows[rowIndex].Cells[0].Value = parts[0].ToString();
                        dgvKeys.Rows[rowIndex].Cells[1].Value = parts[1].ToString();
                        dgvKeys.Rows[rowIndex].Cells[2].Value = true;
                        rowIndex++;


                    }
                    else
                        dgvStupci.Rows[brojAtributa].Cells[4].Value = false;

                        if (parts[5].ToString() != "")
                        {
                        string[] line = parts[5].Split(':');
                        dgvForeignKeys.Rows.Add(1);
                        dgvForeignKeys.Rows[rowIndexForFK].Cells[0].Value = line[0].Substring(line[0].IndexOf("[")+1, line[0].Length-1);
                        dgvForeignKeys.Rows[rowIndexForFK].Cells[1].Value = parts[0];
                        dgvForeignKeys.Rows[rowIndexForFK].Cells[2].Value = line[1].Substring(0, line[1].IndexOf("]"));
                        rowIndexForFK++;
                        }

                    brojAtributa++;
                }
            }
            cmbFKTableName.DataSource = loadProjects.LoadTablesWithoutExtension(projectName1);
            cmbColumnAtribut.DataSource = controller.ListOfTableAtributesForPrimaryKey(dirPath1);
            cmbCurrentTableAtributes.DataSource = controller.ListOfAtributesInCurrentTable(dirPath1);



        }

        private void btnNewColumnRemove_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            try
           {
                int lineToDelete = dgvStupci.CurrentCell.RowIndex;
                string atributName = dgvStupci.Rows[lineToDelete].Cells[0].Value.ToString();
                dgvStupci.Rows.RemoveAt(lineToDelete);
                controller.DelteRowFromTable(lineToDelete, dirPath1);
                brojAtributa--;
               
                cmbColumnAtribut.DataSource = controller.ListOfTableAtributesForPrimaryKey(dirPath1);
                cmbCurrentTableAtributes.DataSource = controller.ListOfAtributesInCurrentTable(dirPath1);

                try
                {
                    int rowIndex1 = -1;
                    int newRowIndex = -1;
                    foreach (DataGridViewRow row in dgvForeignKeys.Rows)
                    {
                        if (row.Cells[1].Value != null)
                        {
                            if (row.Cells[1].Value.ToString().Equals(atributName))
                            {
                                rowIndex1 = row.Index;
                                dgvForeignKeys.Rows.RemoveAt(rowIndex1);
                                rowIndexForFK--;
                                break;
                            }
                        }
                    }

                    foreach (DataGridViewRow row in dgvKeys.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (row.Cells[0].Value.ToString().Equals(atributName))
                            {
                                newRowIndex = row.Index;
                                dgvKeys.Rows.RemoveAt(newRowIndex);
                                rowIndex--;
                                break;
                            }
                        }
                    }
                }
                catch
                {
                }
                
            }
            catch(Exception f)
            {
                MessageBox.Show("Please select valid row");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            LoadProjects loadProjects = new LoadProjects();
            if (brojAtributa < 1 || !controller.CheckPrimaryKey(dirPath1))
            {
                controller.DeleteTable(dirPath1);
                loadProjects.DeleteTableDependece(projectName1, tableName1 + ".dat");
            }
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            LoadProjects loadProjects = new LoadProjects();
            if (brojAtributa < 1)
            {
                controller.DeleteTable(dirPath1);
                loadProjects.DeleteTableDependece(projectName1, tableName1 + ".dat");
                this.Close();

            }
            else
            {

                if (!controller.CheckPrimaryKey(dirPath1))
                {
                    MessageBox.Show("There is no primary key");
                }
                else
                {
                    this.Close();
                }
            }


        }
        int rowIndex = 0;
        private void btnKeysAdd_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            try
            {
                controller.CheckThoseDamnAtributesToPrimaryKeys(cmbColumnAtribut.SelectedItem.ToString(), dirPath1);
                for (int i = 0; i < dgvStupci.RowCount - 1; i++)
                {
                    if (dgvStupci.Rows[i].Cells[0].Value.ToString() == cmbColumnAtribut.SelectedItem.ToString())
                    {
                        dgvStupci.Rows[i].Cells[4].Value = true;
                        dgvStupci.Rows[i].Cells[3].Value = true;
                        dgvStupci.Refresh();
                        dgvKeys.Rows.Add(1);
                        dgvKeys.Rows[rowIndex].Cells[0].Value = cmbColumnAtribut.SelectedItem.ToString();
                        dgvKeys.Rows[rowIndex].Cells[1].Value = dgvStupci.Rows[i].Cells[1].Value;
                        dgvKeys.Rows[rowIndex].Cells[2].Value = chcboxKeysPrimary.Checked;
                        rowIndex++;
                    }
                }
                cmbColumnAtribut.DataSource = controller.ListOfTableAtributesForPrimaryKey(dirPath1);
                
            }
            catch { }
            

        }

        private void cmbFKTableName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            string dirPathForSelectedTable = dirPath1.Substring(0, dirPath1.LastIndexOf("\\")) + "\\"+cmbFKTableName.SelectedItem.ToString()+".dat";
            //Treba ocistit cmb ako nema atributa u tom 
            if (controller.ListOfPrimaryKeysForSpecificTable(dirPathForSelectedTable).Count!=0 )
            {
                cmbSelectedTablePK.DataSource = controller.ListOfPrimaryKeysForSpecificTable(dirPathForSelectedTable);
            }
            else
            {
                cmbSelectedTablePK.DataSource = null;

            }
        }

        int rowIndexForFK = 0;
        private void v_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            if (cmbFKTableName.SelectedIndex >-1 && cmbCurrentTableAtributes.SelectedIndex >-1 && cmbSelectedTablePK.SelectedIndex >-1)
            {
                dgvForeignKeys.Rows.Add(1);
                dgvForeignKeys.Rows[rowIndexForFK].Cells[0].Value = cmbFKTableName.SelectedItem;
                dgvForeignKeys.Rows[rowIndexForFK].Cells[1].Value = cmbCurrentTableAtributes.SelectedItem;
                dgvForeignKeys.Rows[rowIndexForFK].Cells[2].Value = cmbSelectedTablePK.SelectedItem;
                rowIndexForFK++;
                controller.InsertFKIntoFile(dirPath1, cmbCurrentTableAtributes.SelectedItem.ToString(), cmbFKTableName.SelectedItem.ToString(), cmbSelectedTablePK.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Plase selecet all required elements!");
            }
        }

        private void btnDeleteForeignKey_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
          
            try
            {
                int lineNumber = dgvForeignKeys.CurrentCell.RowIndex;
                string atributName = dgvForeignKeys.Rows[lineNumber].Cells[1].Value.ToString();
                controller.DeleteForeignKey(dirPath1, atributName);
                dgvForeignKeys.Rows.RemoveAt(lineNumber);
                rowIndexForFK--;
            }
            catch (Exception f)
            {
                MessageBox.Show("Please select valid row");
            }
        }
    }
}
