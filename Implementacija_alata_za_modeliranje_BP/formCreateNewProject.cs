using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implementacija_alata_za_modeliranje_BP
{
    public partial class formCreateNewProject : Form
    {
        public formCreateNewProject()
        {
            InitializeComponent();
        }

        private void btnUgasiFormu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;

        private void formCreateNewProject_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void formCreateNewProject_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnCloseFormNewProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSaveProjectName_Click(object sender, EventArgs e)
        {
            NewTableController controller = new NewTableController();
            if (controller.CheckTextInput(txtProjectName.Text))
            {
                LoadProjects loadProjects = new LoadProjects();
                string folderName = loadProjects.CreateProjectDirectory();
                string pathString = System.IO.Path.Combine (folderName,txtProjectName.Text.Replace(" ", "_"));
                System.IO.Directory.CreateDirectory(pathString);
                this.Close();               
            }
            else
            {
                txtProjectName.Text = "";
                MessageBox.Show("Invalid input");
            }          
        }
    }
}
