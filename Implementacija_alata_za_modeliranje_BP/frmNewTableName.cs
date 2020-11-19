using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Implementacija_alata_za_modeliranje_BP
{
    public partial class frmNewTableName : Form
    {
        string projectName;
        string tableName1=null;
        bool rename1 = false;
        public frmNewTableName()
        {
            InitializeComponent();
        }

        public frmNewTableName(string selectedProject)
        {
            InitializeComponent();
            projectName = selectedProject;
        }

        public frmNewTableName(string tableName,bool rename, string selectedProject)
        {
            InitializeComponent();

            tableName1 = tableName.Substring(0, tableName.IndexOf('.')); ;
            rename1 = rename;
            projectName = selectedProject;

        }

        private void btnCloseFormNewTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveTableName_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            LoadProjects loadProjects = new LoadProjects();
            bool exists = false;
            
            foreach (var table in loadProjects.LoadTables(projectName))
            {
                if ((table) == (tableName1+".dat") && rename1)
                {
                    string projectPath = loadProjects.CreateProjectDirectory() + "\\" + projectName + "\\" + tableName1.Replace(" ", "_") + ".dat";
                    string projectPath1 = loadProjects.CreateProjectDirectory() + "\\" + projectName + "\\" + txtTableName.Text.Replace(" ", "_") + ".dat";
                    string projectPathForChangeFK = loadProjects.CreateProjectDirectory() + "\\" + projectName;

                    controller.ChangeFKNameInDatAfterRenaming(tableName1.Replace(" ", "_"), txtTableName.Text.Replace(" ", "_"), projectName, projectPathForChangeFK);
                    if(!loadProjects.LoadTables(projectName).Contains(txtTableName.Text + ".dat"))
                    {
                        if (controller.CheckTextInput(txtTableName.Text.Replace(" ", "_")))
                        {
                            System.IO.File.Move(projectPath, projectPath1);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                        }
                    }    
                    
                }
                if (table == txtTableName.Text + ".dat")
                {
                    MessageBox.Show("Table already exists!");
                    exists = true;
                }
            }

            if (controller.CheckTextInput(txtTableName.Text) && !rename1 && !exists)
            {
                string projectPath = loadProjects.CreateProjectDirectory() + "\\" + projectName + "\\" + txtTableName.Text.Replace(" ", "_") + ".dat";
                FileStream fs = File.Create(projectPath);
                fs.Close();
                formNovaTablica frmNewTable = new formNovaTablica(txtTableName.Text, projectPath, projectName);
                frmNewTable.Show();
                this.Close();
            }
            else if (!controller.CheckTextInput(txtTableName.Text) && !rename1)
            {
                MessageBox.Show("Invalid input!");
            }


        }
        Point lastPoint;
        private void frmNewTableName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmNewTableName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmNewTableName_Load(object sender, EventArgs e)
        {
            txtTableName.Text = tableName1;
            this.AcceptButton = btnSaveTableName;
        }
    }
}
