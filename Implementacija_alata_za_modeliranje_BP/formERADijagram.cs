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
using System.Drawing.Drawing2D;

namespace Implementacija_alata_za_modeliranje_BP
{

    public partial class formERADijagram : Form
    {
        bool isFileMenuPanelOpen = false;
        bool isProjectMenuOpen = false;
        bool isTableMenuOpen = false;
        List<String> newProjectList = new List<string>();
        public string newProject = "";
        public bool projectIsRenamed = false;
        public string oldName = "";

        public formERADijagram()
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


        private void lblFile_Click(object sender, EventArgs e)
        {
            timer1.Start();
            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
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
                if (filePanel.Height == 200)
                {
                    timer1.Stop();
                    isFileMenuPanelOpen = true;
                }
            }

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void formERADijagram_Load(object sender, EventArgs e)
        {
            LoadProjects loadProjects = new LoadProjects();
            loadProjects.CreateProjectDirectory();
            newProjectList = loadProjects.ProjectList();
            formERADijagram_Activated(sender, e);
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void panelERADijagrama_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void lblNewProject_Click(object sender, EventArgs e)
        {
            formCreateNewProject frmNewProject = new formCreateNewProject(this, newProject, false);
            frmNewProject.Show();
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void panelLeftProjects_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void treeProject_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void formERADijagram_Activated(object sender, EventArgs e)
        {
            treeProject.Nodes.Clear();
            treeProject.Nodes.Add("Projects");

            LoadProjects loadProjects = new LoadProjects();
            // newProjectList = loadProjects.ProjectList();
            if (newProject != "" && !projectIsRenamed)
            {
                newProjectList.Add(newProject);
                newProject = "";
            }

            if (projectIsRenamed)
            {
                newProjectList.Remove(oldName);
                newProjectList.Add(newProject);
                System.Console.WriteLine("oldname" + oldName);
                System.Console.WriteLine("new name" + newProject);
                projectIsRenamed = false;
                newProject = "";
            }
            foreach (var item in newProjectList)
            {
                TreeNode node;
                node = treeProject.Nodes[0].Nodes.Add(item.ToString());
                foreach (var table in loadProjects.LoadTables(item.ToString()))
                {
                    node.Nodes.Add(table.ToString());
                }
            }
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;
            treeProject.ExpandAll();
        }

        Point clickedPoint;


        private void timer2_Tick(object sender, EventArgs e)
        {
            projectOptionsPanel.Location = clickedPoint;
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
                if (projectOptionsPanel.Height == 300)
                {
                    timer2.Stop();
                    isProjectMenuOpen = true;
                }
            }

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void treeProject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeProject.SelectedNode = e.Node;
            TreeNode rootNode = treeProject.Nodes[0].FirstNode; //Projects-root

            try
            {
                TreeNode tableNode = rootNode.FirstNode;

                try
                {
                    while (tableNode != null)
                    {
                        if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                        {
                            clickedPoint = new Point(104, e.Y);
                            timer3.Start();
                        }
                        tableNode = tableNode.NextNode;
                    }

                }
                catch (Exception i)
                {

                }

                try
                {
                    if (e.Button == MouseButtons.Right && rootNode.IsSelected)
                    {
                        clickedPoint = new Point(72, e.Y);
                        timer2.Start();
                    }
                }
                catch
                {

                }

                while (rootNode.NextNode != null)
                {

                    try
                    {

                        if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                        {
                            clickedPoint = new Point(104, e.Y);
                            timer3.Start();
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        while (tableNode.NextNode != null)
                        {
                            try
                            {
                                if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                                {
                                    clickedPoint = new Point(104, e.Y);
                                    timer3.Start();
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                tableNode = tableNode.NextNode;
                                if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                                {
                                    clickedPoint = new Point(104, e.Y);
                                    timer3.Start();
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    catch
                    {

                    }

                    try
                    {
                        if (e.Button == MouseButtons.Right && rootNode.IsSelected)
                        {
                            clickedPoint = new Point(72, e.Y);
                            timer2.Start();
                        }
                    }
                    catch
                    {

                    }

                    rootNode = rootNode.NextNode;
                    try
                    {
                        tableNode = rootNode.FirstNode;

                        if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                        {
                            clickedPoint = new Point(104, e.Y);
                            timer3.Start();
                        }

                        while (tableNode.NextNode != null)
                        {
                            if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                            {
                                clickedPoint = new Point(104, e.Y);
                                timer3.Start();
                            }
                            tableNode = tableNode.NextNode;
                            if (e.Button == MouseButtons.Right && tableNode.IsSelected)
                            {
                                clickedPoint = new Point(104, e.Y);
                                timer3.Start();
                            }
                        }

                    }
                    catch (Exception o)
                    {

                    }

                    if (e.Button == MouseButtons.Right && rootNode.IsSelected)
                    {
                        clickedPoint = new Point(72, e.Y);
                        timer2.Start();
                    }

                }
            }
            catch (Exception f)
            {
            }
        }

        private void lblNewTable_Click(object sender, EventArgs e)
        {
            string selectedNode = treeProject.SelectedNode.Text;
            frmNewTableName newTabelName = new frmNewTableName(selectedNode);
            newTabelName.Show();

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;
        }

        private void lblDeleteProjectRightClick_Click(object sender, EventArgs e)
        {
            string selectedNode = treeProject.SelectedNode.Text;
            LoadProjects loadProjects = new LoadProjects();
            string projectPath = loadProjects.CreateProjectDirectory() + "\\" + selectedNode;
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Delete project: " + selectedNode, MessageBoxButtons.YesNo);
            if (Directory.Exists(projectPath) && dialogResult == DialogResult.Yes)
            {
                Directory.Delete(projectPath, true);
                projectOptionsPanel.Height = 0;
                isProjectMenuOpen = false;
                newProjectList.Remove(selectedNode);
                formERADijagram_Activated(sender, e);
            }
        }

        private void lblRenameTable_Click(object sender, EventArgs e)
        {
            LoadProjects loadProjects = new LoadProjects();
            string tableName = treeProject.SelectedNode.Text;
            string projectName = treeProject.SelectedNode.Parent.Text;
            frmNewTableName newTableName = new frmNewTableName(tableName, true, projectName);
            newTableName.Show();

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;



        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panelTableOptions.Location = clickedPoint;
            if (isTableMenuOpen)
            {
                panelTableOptions.Height -= 20;
                if (panelTableOptions.Height == 0)
                {
                    timer3.Stop();
                    isTableMenuOpen = false;
                }

            }
            else if (!isTableMenuOpen)
            {
                panelTableOptions.Height += 20;
                if (panelTableOptions.Height == 160)
                {
                    timer3.Stop();
                    isTableMenuOpen = true;
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSaveAll_Click(object sender, EventArgs e)
        {
            filePanel.Height = 0;
            isFileMenuPanelOpen = false;
        }

        private void lblRenameProjectRightClick_Click(object sender, EventArgs e)
        {
            string projectName = treeProject.SelectedNode.Text;
            //formCreateNewProject createNewProject = new formCreateNewProject(projectName, true);
            formCreateNewProject createNewProject = new formCreateNewProject(this, projectName, true);

            createNewProject.Show();

            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
        }

        private void lblDeleteTable_Click(object sender, EventArgs e)
        {
            LoadProjects loadProjects = new LoadProjects();
            string projectName = treeProject.SelectedNode.Parent.Text;
            string tableName = treeProject.SelectedNode.Text;
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{dirPath}\Projects\" + projectName + "\\" + tableName;
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Delete table: " + tableName, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(dirName);
                panelTableOptions.Height = 0;
                isTableMenuOpen = false;
                loadProjects.DeleteTableDependece(projectName, tableName);
                formERADijagram_Activated(sender, e);
            }
        }

        private void lblOpenTable_Click(object sender, EventArgs e)
        {
            string selectedTable = treeProject.SelectedNode.Text;
            string projectName = treeProject.SelectedNode.Parent.Text;

            formNovaTablica newTable = new formNovaTablica(selectedTable, projectName, true);
            newTable.Show();

            panelTableOptions.Height = 0;
            isTableMenuOpen = false;

        }

        private void lblGenerateERA_Click(object sender, EventArgs e)
        {
            Graphics gr = panelERADijagrama.CreateGraphics();
            gr.Clear(Color.White);
            panelERADijagrama.Controls.Clear();

            LoadProjects loadProjects = new LoadProjects();
            GeneratingERA generatingERA = new GeneratingERA();
            List<string> listOfTablePositionAndArea = new List<string>();

            listOfEndTableTypePoints.Clear();
            listOfEndPointsTable.Clear();
            listOfDockingLinesPoints.Clear();
            listOfStartTablePoints.Clear();
            listOfStartTableTypePoints.Clear();
            listOfRandomColor.Clear();

            //Initilize drawing area
            int eraPanelWidth = panelERADijagrama.Width - (panel4.Width + panel1.Width);
            int eraPanelHeight = panelERADijagrama.Height - panel3.Height;
            int realEraPanelHeight = panelERADijagrama.Height;
            int realEraPanelWidth = panelERADijagrama.Width;

            //Initilaze starting position for drawing
            int eraStartingPositionX = panel4.Width + panel1.Width;
            int eraStartingPositionY = panel3.Height;
            

            Canvas canvas = new Canvas(eraPanelHeight, eraPanelWidth, eraStartingPositionX, eraStartingPositionY, realEraPanelHeight, realEraPanelWidth);

            //Making string path for selected project
            string projectName = treeProject.SelectedNode.Text;
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var projectPath = $@"{dirPath}\Projects\" + projectName;

            // generatingERA.TableArea(projectPath,eraPanelWidth,eraPanelHeight);
            int numberOfTables = generatingERA.NumberOfTables(projectName);

            //Creating grid for drawing surface
            int biggestWidth = generatingERA.BiggestTableWidthAndHeight(projectPath, projectName).ElementAt(0);
            int biggestHeight = generatingERA.BiggestTableWidthAndHeight(projectPath, projectName).ElementAt(1);


            //Making empty canvas for tables
            canvas.SetMatrixToEmpty();

            //Loading every table in project
            foreach (var table in loadProjects.LoadTables(projectName))
            {
                string tablePath = projectPath + "\\" + table;

                int height = (generatingERA.NumberOfLinesInFile(tablePath) * 15 + 17);
                int width = (generatingERA.LengthOfNameAndType(tablePath, table) * 8) + 46;

                //Giving dimenisions for every table one by one and geting back coordinates
                int[,] point = canvas.StartingTablePoints(biggestWidth, biggestHeight, width, height, numberOfTables);
                int pointX = point.GetLength(0);
                int pointY = point.GetLength(1);



                //Creating panels for every table
                Panel tablePanel = new Panel();
                tablePanel.Size = new System.Drawing.Size(width, height);
                tablePanel.Location = new Point(pointX, pointY);
                tablePanel.BorderStyle = BorderStyle.FixedSingle;
                tablePanel.BringToFront();
                Color myCOlor = Color.FromArgb(169, 186, 171);
                tablePanel.BackColor = myCOlor;
                panelERADijagrama.Controls.Add(tablePanel);

                //Creating list for later drawings of connections
                string positionAndName = "[(" + pointX + "," + pointY + ");(" + width + "," + height + ");:" + table + "]";
                listOfTablePositionAndArea.Add(positionAndName);

                //Creating label for table name
                Label lblTableName = new Label();
                lblTableName.Text = table.Substring(0, table.IndexOf('.'));
                lblTableName.Font = new Font("Arial", 9, FontStyle.Bold);
                int tableNameWidth = table.Substring(0, table.IndexOf('.')).Length * 8;
                lblTableName.AutoSize = true;
                lblTableName.Location = new Point((width - tableNameWidth) / 2, 0);
                tablePanel.Controls.Add(lblTableName);

                //Drawing line to seperate table name from atributtes
                tablePanel.Paint += new PaintEventHandler(tablePanelPaint);
                tablePanel.Refresh();


                int newY = 18;

                //Loop for placing labels which are PK
                foreach (var PK in generatingERA.ListOfPrimaryKeyInTable(tablePath))
                {
                    string[] parts = PK.Split(',');

                    //Creating label for primary keys
                    Label lbPK = new Label();
                    lbPK.Text = parts[0].ToString();
                    lbPK.Font = new Font("Arial", 8, FontStyle.Bold);
                    lbPK.Location = new System.Drawing.Point(20, newY);
                    lbPK.AutoSize = true;
                    tablePanel.Controls.Add(lbPK);

                    //Creating label for primary key type
                    Label lbTypePK = new Label();
                    lbTypePK.Text = parts[1].ToString();
                    lbTypePK.Font = new Font("Arial", 8, FontStyle.Bold);
                    lbTypePK.Location = new System.Drawing.Point(width - (width - (generatingERA.BiggestAttribute(tablePath)) * 8) + 26, newY);
                    lbTypePK.AutoSize = true;
                    tablePanel.Controls.Add(lbTypePK);

                    //Creating Label for PK indicator
                    Label lblPk1 = new Label();
                    lblPk1.Text = "PK";
                    lblPk1.Font = new Font("Arial", 8, FontStyle.Bold);
                    lblPk1.Location = new System.Drawing.Point(0, newY);
                    lblPk1.AutoSize = true;
                    tablePanel.Controls.Add(lblPk1);
                    newY += 15;
                    lbTypePK.BringToFront();


                }


                //Loop for placing labels that are normal atributes
                foreach (var attribute in generatingERA.AtributeNameAndTypeInFile(tablePath))
                {
                    string[] parts = attribute.Split(',');

                    //Creating labels for every atribute
                    Label lb = new Label();
                    lb.Text = parts[0].ToString();
                    lb.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb.Location = new System.Drawing.Point(20, newY);
                    lb.AutoSize = true;
                    tablePanel.Controls.Add(lb);

                    //Creating label for type
                    Label lbType = new Label();
                    lbType.Text = parts[1].ToString();
                    lbType.Font = new Font("Arial", 8, FontStyle.Regular);
                    lbType.Location = new System.Drawing.Point(width - (width - (generatingERA.BiggestAttribute(tablePath)) * 8) + 26, newY);
                    //lbType.Location = new System.Drawing.Point(width - lb.Width-10, newY);
                    lbType.AutoSize = true;
                    tablePanel.Controls.Add(lbType);

                    newY += 15;
                    lbType.BringToFront();

                }

                //Adding foreing keys to table panel
                foreach (var PK in generatingERA.ListOfFKAtributeAndType(tablePath))
                {
                    string[] parts = PK.Split(',');

                    //Creating laber from FK keys
                    Label lbFK = new Label();
                    lbFK.Text = parts[0].ToString();
                    lbFK.Font = new Font("Arial", 8, FontStyle.Bold);
                    lbFK.Location = new System.Drawing.Point(20, newY);
                    lbFK.AutoSize = true;
                    tablePanel.Controls.Add(lbFK);

                    //Creating label for FK key type
                    Label lbTypeFK = new Label();
                    lbTypeFK.Text = parts[1].ToString();
                    lbTypeFK.Font = new Font("Arial", 8, FontStyle.Bold);
                    lbTypeFK.Location = new System.Drawing.Point(width - (width - (generatingERA.BiggestAttribute(tablePath)) * 8) + 26, newY);
                    lbTypeFK.AutoSize = true;
                    tablePanel.Controls.Add(lbTypeFK);

                    //Creating Label for FK indicator
                    Label lblFk1 = new Label();
                    lblFk1.Text = "FK";
                    lblFk1.Font = new Font("Arial", 8, FontStyle.Bold);
                    lblFk1.Location = new System.Drawing.Point(0, newY);
                    lblFk1.AutoSize = true;
                    tablePanel.Controls.Add(lblFk1);
                    newY += 15;
                    lbTypeFK.BringToFront();

                }
            };

            //Loop for drawing lines
            foreach (var item in listOfTablePositionAndArea)
            {
                string[] parts = item.Split(';');

                string tableName = item.Substring(item.LastIndexOf(':') + 1, item.IndexOf(']') - item.IndexOf(':') - 1);
                int pointX = int.Parse(parts[0].Substring(item.IndexOf('(') + 1, item.IndexOf(',') - 2));
                int pointY = int.Parse(parts[0].Substring(item.IndexOf(',') + 1, item.IndexOf(')') - item.IndexOf(',') - 1));
                int width = int.Parse(parts[1].Substring(parts[1].IndexOf('(') + 1, parts[1].IndexOf(',') - 1));
                int height = int.Parse(parts[1].Substring(parts[1].IndexOf(',') + 1, parts[1].IndexOf(')') - parts[1].IndexOf(',') - 1));

                //Checks if table has a FK-that would be child table
                if (generatingERA.TableHasFK(projectPath + "\\" + tableName))
                {
                    //Checks list of FK for that table(how many of FK child table has )
                    foreach (var FK in generatingERA.ListOfTableFK(projectPath + "\\" + tableName))
                    {

                        //Finding again coordinates for table that is the parent
                        foreach (var tableFK in listOfTablePositionAndArea)
                        {
                            string[] newParts = tableFK.Split(';');
                            string parentTable = newParts[2].Substring(newParts[2].IndexOf(':') + 1, newParts[2].IndexOf('.') - newParts[2].IndexOf(':') - 1);


                            //FK== item from list where child table has FK that FK is acctualy nake of primary table
                            if (FK == parentTable)
                            {
                                //Primary table coordinates and dimension
                                int newPointX = int.Parse(newParts[0].Substring(newParts[0].IndexOf('(') + 1, newParts[0].IndexOf(',') - 2));
                                int newPointY = int.Parse(newParts[0].Substring(newParts[0].IndexOf(',') + 1, newParts[0].IndexOf(')') - newParts[0].IndexOf(',') - 1));
                                int newWidth = int.Parse(newParts[1].Substring(newParts[1].IndexOf('(') + 1, newParts[1].IndexOf(',') - 1));
                                int newHeight = int.Parse(newParts[1].Substring(newParts[1].IndexOf(',') + 1, newParts[1].IndexOf(')') - newParts[1].IndexOf(',') - 1));

                                //Sada ovdje treba provijeriti na koji nacin su povezane te dvije tablice
                                //Provijeriti tablica u kojoj se nalazi FK kojeg je tipa atribut
                                //Onda na koordinate od child tablice staviti vezu
                                //I na koordinate od parent tablice staviti takoker tip veze
                                // tableName- ime tablice sa FK
                                // parentTable- ime tablice sa PK

                                Dictionary<string, string> typeOfConnection = generatingERA.TypeOfConnection(tableName, parentTable, projectPath);
                                string childTableConnectionType = "";
                                string parentTableConnectionType = "";
                                try
                                {
                                    foreach (var type in typeOfConnection)
                                    {
                                        childTableConnectionType = type.Key;
                                        parentTableConnectionType = type.Value;
                                    }
                                }
                                catch { }

                                canvas.NewStartingCoordinates(newPointX, newPointY, pointX, pointY, newWidth, newHeight, width, height);

                                Point[] pointsEndTable = canvas.MyDrawingPathEndTable(pointX, pointY, width, height);
                                Point[] pointsStartTable = canvas.MyDrawingPathStartTable(newPointX, newPointY, newWidth, newHeight);
                                Point[] startTabletypePoints = canvas.TableConnectionStartTable(parentTableConnectionType);
                                Point[] endTableTypePoints = canvas.TableConnectionsEndTable(childTableConnectionType, parentTableConnectionType);
                                Point[] dokcingPoints = canvas.AgainMyTry();


                              
                                try
                                {
                                    listOfEndPointsTable.Add(pointsEndTable);
                                    listOfStartTablePoints.Add(pointsStartTable);
                                    listOfStartTableTypePoints.Add(startTabletypePoints);
                                    listOfEndTableTypePoints.Add(endTableTypePoints);
                                    listOfDockingLinesPoints.Add(dokcingPoints);

                                    Random rnd = new Random();
                                    Color randomColor = Color.FromArgb(rnd.Next(150), rnd.Next(150), rnd.Next(150));
                                    try
                                    {
                                        while (listOfRandomColor.Contains(randomColor))
                                        {
                                            randomColor = Color.FromArgb(rnd.Next(150), rnd.Next(150), rnd.Next(150));
                                        }
                                        listOfRandomColor.Add(randomColor);
                                    }
                                    catch {
                                        listOfRandomColor.Add(randomColor);
                                    }


                                }
                                catch
                                {
                                    System.Console.WriteLine("Not work");
                                }
                            }
                        }
                    }
                }
            }
            //canvas.PrintMatrix();
            panelERADijagrama.Invalidate();
            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;

        }


        private void lblOpenProject_Click(object sender, EventArgs e)
        {
            bool realProject = true;
            try
            {

                FolderBrowserDialog ads = new FolderBrowserDialog();
                ads.ShowDialog();
                string filePath = ads.SelectedPath;
                string fileName = filePath.Substring(filePath.LastIndexOf('\\') + 1, filePath.Length - filePath.LastIndexOf('\\') - 1);
                var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var dirName = $@"{dirPath}\Projects\" + fileName;
                string[] subDirectories = Directory.GetFiles(filePath);

                foreach (var item in subDirectories)
                {
                    if (!item.Contains(".dat"))
                    {
                        realProject = false;
                    }
                }

                filePanel.Height = 0;
                isFileMenuPanelOpen = false;

                if (realProject)
                {
                    System.Console.WriteLine(filePath);

                    if (Directory.Exists(dirName) && !newProjectList.Contains(fileName))
                    {
                        newProjectList.Add(fileName);
                        System.Console.WriteLine("if");
                    }
                    else
                    {
                        Directory.Move(filePath, dirName);
                        System.Console.WriteLine("else");

                        newProjectList.Add(fileName);
                    }
                    formERADijagram_Activated(sender, e);
                }
                else
                {
                    MessageBox.Show("Plese select real project!");
                }

            }
            catch
            {


            }
        }

        private void lblCloseProject_Click(object sender, EventArgs e)
        {
            string selectedProject = treeProject.SelectedNode.Text;
            try
            {
                foreach (var item in newProjectList)
                {
                    if (item == selectedProject)
                    {
                        newProjectList.Remove(item);
                        projectOptionsPanel.Height = 0;
                        isProjectMenuOpen = false;
                        formERADijagram_Activated(sender, e);
                    }
                }
            }
            catch
            {

            }
        }

        private void convertToSQL_Click(object sender, EventArgs e)
        {

            string projectName = treeProject.SelectedNode.Text;
            projectOptionsPanel.Height = 0;
            isProjectMenuOpen = false;
            sqlCode sqlCode = new sqlCode(projectName);
            sqlCode.ShowDialog();

        }

        private void lblExport_Click(object sender, EventArgs e)
        {
            int eraStartingPositionX = panel4.Width + panel1.Width;
            int eraStartingPositionY = panel3.Height;
            using (var picture = new Bitmap(panelERADijagrama.Width+eraStartingPositionX*2, panelERADijagrama.Height+eraStartingPositionY*2))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "*.jpg|*.jpg";
                DialogResult dr = sfd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string pictureName = sfd.FileName;
                    //string path=sfd.
                    this.DrawToBitmap(picture, new Rectangle(eraStartingPositionX + 1, eraStartingPositionY + 1, picture.Width, picture.Height));
                    picture.Save(pictureName);
                }


            }
        }
        private void tablePanelPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            Pen myp = new Pen(System.Drawing.Color.Black, 2);
            g.DrawLine(myp, 0, 17, panelERADijagrama.Width, 17);
        }

        //Graphics list
        private List<Point[]> listOfEndPointsTable = new List<Point[]>();
        private List<Point[]> listOfStartTablePoints = new List<Point[]>();
        private List<Point[]> listOfDockingLinesPoints = new List<Point[]>();
        private List<Point[]> listOfEndTableTypePoints = new List<Point[]>();
        private List<Point[]> listOfStartTableTypePoints = new List<Point[]>();
        private List<Color> listOfRandomColor = new List<Color>();

        private void panelERADijagrama_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                int i = 0;
                    


                    base.OnPaint(e);
                    //End table points
                    foreach (var endTablePoint in listOfEndPointsTable)
                    {
                    Pen pen = new Pen(listOfRandomColor.ElementAt(i), 1);
                    GraphicsPath endLine = new GraphicsPath();
                        endLine.AddLines(endTablePoint);
                        e.Graphics.DrawPath(pen, endLine);
                    i++;
                    }
                i = 0;
                //Start table points
                foreach (var startTablePoint in listOfStartTablePoints)
                    {

                    Pen pen = new Pen(listOfRandomColor.ElementAt(i), 1);
                    GraphicsPath startLine = new GraphicsPath();
                        startLine.AddLines(startTablePoint);
                        e.Graphics.DrawPath(pen, startLine);
                    i++;
                    }
                i = 0;
                    //Start table type
                    foreach (var startTableTypePoint in listOfStartTableTypePoints)
                    {
                    Pen pen = new Pen(listOfRandomColor.ElementAt(i), 1);
                    GraphicsPath startTableType = new GraphicsPath();
                        startTableType.AddLines(startTableTypePoint);
                        e.Graphics.DrawPath(pen, startTableType);
                    i++;
                    }

                i = 0;
                    //End table type
                    foreach (var endTableTypePoints in listOfEndTableTypePoints)
                    {
                    Pen pen = new Pen(listOfRandomColor.ElementAt(i), 1);

                    GraphicsPath endTableType = new GraphicsPath();
                        endTableType.AddLines(endTableTypePoints);
                        e.Graphics.DrawPath(pen, endTableType);
                    i++;
                    }
                i = 0;
                    //Docking lines
                    foreach (var dokcingPoints in listOfDockingLinesPoints)
                    {
                    Pen pen = new Pen(listOfRandomColor.ElementAt(i), 1);
                    GraphicsPath dockingLines = new GraphicsPath();
                        dockingLines.AddLines(dokcingPoints);
                        e.Graphics.DrawPath(pen, dockingLines);
                    i++;
                    }
                
            }
            catch {

            }
        }
    }
}
