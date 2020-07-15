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
        public frmNewTableName()
        {
            InitializeComponent();
        }

        public frmNewTableName(string selectedProject)
        {
            InitializeComponent();
            this.projectName = selectedProject;
        }

        private void btnCloseFormNewTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveTableName_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            if (controller.CheckTextInput(txtTableName.Text))
            {
                LoadProjects loadProjects = new LoadProjects();
                string projectPath = loadProjects.CreateProjectDirectory() + "\\" + projectName+"\\"+txtTableName.Text.Replace(" ","_")+".dat";
                FileStream fs = File.Create(projectPath);
                formNovaTablica frmNewTable = new formNovaTablica(txtTableName.Text);
                frmNewTable.Show();
                this.Close();
            }
            else
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
    }
}
