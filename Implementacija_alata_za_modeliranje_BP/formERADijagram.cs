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
    public partial class formERADijagram : Form
    {
        bool isFileMenuPanelOpen = false;
        string projectName = "";
        bool isProjectMenuOpen = false;

        public formERADijagram( )
        {
            InitializeComponent();
        }
        


        private void btnMinimaze_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        

    private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximaze_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        Point lastPoint;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formNovaTablica frmNovaTablica = new formNovaTablica();
            frmNovaTablica.Show();
        }

        private void lblFile_Click(object sender, EventArgs e)
        {
            timer1.Start();
            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isFileMenuPanelOpen)
            {
                filePanel.Height -= 20;
                if (filePanel.Height == 0)
                {
                    timer1.Stop();
                    isFileMenuPanelOpen = false;
                }

            }
            else if (!isFileMenuPanelOpen)
            {
                filePanel.Height += 20;
                if(filePanel.Height== 200)
                {
                    timer1.Stop();
                    isFileMenuPanelOpen = true;
                }
            }
        }

        private void formERADijagram_Load(object sender, EventArgs e)
        {

        }


        private void panel3_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void panelERADijagrama_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void lblNewProject_Click(object sender, EventArgs e)
        {
            formCreateNewProject frmNewProject = new formCreateNewProject();
            frmNewProject.Show();
        }

        private void panelLeftProjects_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void treeProject_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void formERADijagram_Activated(object sender, EventArgs e)
        {
            treeProject.Nodes[0].Nodes.Clear();
            LoadProjects loadProjects = new LoadProjects();
            foreach (var item in loadProjects.projectList())
            {
                treeProject.Nodes[0].Nodes.Add(item.ToString());
            }
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;
        }
        Point clickedPoint;
        private void treeProject_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Right)
            {
                clickedPoint = new Point(72, e.Y);
                timer2.Start();
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            projectOptionsPanel.Location = clickedPoint;
           // projectOptionsPanel.DragOver = panelERADijagrama.;
            if (isProjectMenuOpen)
            {
                projectOptionsPanel.Height -= 20;
                if (projectOptionsPanel.Height == 0)
                {
                    timer2.Stop();
                    isProjectMenuOpen = false;
                }

            }
            else if (!isProjectMenuOpen)
            {
                projectOptionsPanel.Height += 20;
                if (projectOptionsPanel.Height == 160)
                {
                    timer2.Stop();
                    isProjectMenuOpen = true;
                }
            }
        }

        private void treeProject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickedPoint = new Point(72, e.Y);
                timer2.Start();
            }
        }
    }
}
