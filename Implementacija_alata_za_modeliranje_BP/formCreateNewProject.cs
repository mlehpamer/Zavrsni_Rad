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
using System.IO;

namespace Implementacija_alata_za_modeliranje_BP
{
    public partial class formCreateNewProject : Form
    {
        string projectName1;
        bool rename1 = false;

        public formCreateNewProject()
        {

            InitializeComponent();
        }

        formERADijagram f1 = new formERADijagram();

        public formCreateNewProject(formERADijagram form1,string projectName,bool rename)
        {
            InitializeComponent();
            f1=new formERADijagram();
            f1 = form1;
            this.projectName1 = projectName;
            this.rename1 = rename;
        }

        public formCreateNewProject(string projectName, bool rename)
        {
            InitializeComponent();
            rename1 = rename;
            projectName1 = projectName;
        }

        private void btnUgasiFormu_Click(object sender, EventArgs e)
        {
            txtProjectName.Clear();
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
            LoadProjects loadProjects = new LoadProjects();
            bool exists = false;
            foreach(var project in loadProjects.ProjectList())
            {
                if(project==projectName1 && rename1)
                {
                    string folderName = loadProjects.CreateProjectDirectory();
                    string pathString = System.IO.Path.Combine(folderName, projectName1.Replace(" ", "_"));
                    string pathString1 = System.IO.Path.Combine(folderName, txtProjectName.Text.Replace(" ", "_"));
                    if (!loadProjects.ProjectList().Contains(txtProjectName.Text.Replace(" ", "_")))
                    {
                        if(controller.CheckTextInput(txtProjectName.Text.Replace(" ", "_"))){
                            System.IO.Directory.Move(pathString, pathString1);
                            f1.oldName = projectName1.Replace(" ", "_");
                            f1.newProject = txtProjectName.Text.Replace(" ", "_");
                            f1.projectIsRenamed = true;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input!");
                        }
                    }


                 
                    
                   
                }
                else if(project== txtProjectName.Text.Replace(" ", "_"))
                {
                    exists = true;

                }
            }

            if (!exists)
            {
                if (controller.CheckTextInput(txtProjectName.Text))
                {
                    string folderName = loadProjects.CreateProjectDirectory();
                    string pathString = System.IO.Path.Combine(folderName, txtProjectName.Text.Replace(" ", "_"));
                    System.IO.Directory.CreateDirectory(pathString);
                    f1.newProject = txtProjectName.Text.Replace(" ", "_");
                    this.Hide();
                }
                else if(!rename1)
                {
                    txtProjectName.Text = "";
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Project already exists!");
            }
        }

        private void formCreateNewProject_Load(object sender, EventArgs e)
        {
            txtProjectName.Text = projectName1;
            this.AcceptButton = btnSaveProjectName;
        }
    }
}
