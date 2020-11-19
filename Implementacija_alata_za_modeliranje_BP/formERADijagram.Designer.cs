namespace Implementacija_alata_za_modeliranje_BP
{
    partial class formERADijagram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formERADijagram));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Projects");
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnMaximaze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLeftProjects = new System.Windows.Forms.Panel();
            this.panelTableOptions = new System.Windows.Forms.Panel();
            this.lblDeleteTable = new System.Windows.Forms.Label();
            this.lblRenameTable = new System.Windows.Forms.Label();
            this.lblOpenTable = new System.Windows.Forms.Label();
            this.projectOptionsPanel = new System.Windows.Forms.Panel();
            this.convertToSQL = new System.Windows.Forms.Label();
            this.lblGenerateERA = new System.Windows.Forms.Label();
            this.lblCloseProject = new System.Windows.Forms.Label();
            this.lblNewTable = new System.Windows.Forms.Label();
            this.lblDeleteProjectRightClick = new System.Windows.Forms.Label();
            this.lblRenameProjectRightClick = new System.Windows.Forms.Label();
            this.filePanel = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblSaveAll = new System.Windows.Forms.Label();
            this.lblOpenProject = new System.Windows.Forms.Label();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.treeProject = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRenameProject = new System.Windows.Forms.Label();
            this.panelERADijagrama = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelLeftProjects.SuspendLayout();
            this.panelTableOptions.SuspendLayout();
            this.projectOptionsPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.panelERADijagrama.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblFile);
            this.panel3.Controls.Add(this.btnMinimaze);
            this.panel3.Controls.Add(this.btnMaximaze);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 21);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(670, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conceptual Database Modeler";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFile.Location = new System.Drawing.Point(3, 1);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(31, 17);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            this.lblFile.Click += new System.EventHandler(this.lblFile_Click);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimaze.BackgroundImage")));
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Location = new System.Drawing.Point(1255, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(20, 21);
            this.btnMinimaze.TabIndex = 5;
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click_1);
            // 
            // btnMaximaze
            // 
            this.btnMaximaze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximaze.BackgroundImage")));
            this.btnMaximaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximaze.FlatAppearance.BorderSize = 0;
            this.btnMaximaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximaze.Location = new System.Drawing.Point(1275, 0);
            this.btnMaximaze.Name = "btnMaximaze";
            this.btnMaximaze.Size = new System.Drawing.Size(20, 21);
            this.btnMaximaze.TabIndex = 4;
            this.btnMaximaze.UseVisualStyleBackColor = true;
            this.btnMaximaze.Click += new System.EventHandler(this.btnMaximaze_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1295, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 21);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelLeftProjects
            // 
            this.panelLeftProjects.BackColor = System.Drawing.Color.Silver;
            this.panelLeftProjects.Controls.Add(this.panelTableOptions);
            this.panelLeftProjects.Controls.Add(this.projectOptionsPanel);
            this.panelLeftProjects.Controls.Add(this.filePanel);
            this.panelLeftProjects.Controls.Add(this.treeProject);
            this.panelLeftProjects.Controls.Add(this.panel1);
            this.panelLeftProjects.Controls.Add(this.panel4);
            this.panelLeftProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftProjects.Location = new System.Drawing.Point(0, 20);
            this.panelLeftProjects.Name = "panelLeftProjects";
            this.panelLeftProjects.Size = new System.Drawing.Size(216, 572);
            this.panelLeftProjects.TabIndex = 2;
            this.panelLeftProjects.Click += new System.EventHandler(this.panelLeftProjects_Click);
            // 
            // panelTableOptions
            // 
            this.panelTableOptions.BackColor = System.Drawing.Color.DarkGray;
            this.panelTableOptions.Controls.Add(this.lblDeleteTable);
            this.panelTableOptions.Controls.Add(this.lblRenameTable);
            this.panelTableOptions.Controls.Add(this.lblOpenTable);
            this.panelTableOptions.Location = new System.Drawing.Point(104, 100);
            this.panelTableOptions.Name = "panelTableOptions";
            this.panelTableOptions.Size = new System.Drawing.Size(109, 0);
            this.panelTableOptions.TabIndex = 0;
            // 
            // lblDeleteTable
            // 
            this.lblDeleteTable.AutoSize = true;
            this.lblDeleteTable.Location = new System.Drawing.Point(6, 105);
            this.lblDeleteTable.Name = "lblDeleteTable";
            this.lblDeleteTable.Size = new System.Drawing.Size(84, 17);
            this.lblDeleteTable.TabIndex = 2;
            this.lblDeleteTable.Text = "Delete table";
            this.lblDeleteTable.Click += new System.EventHandler(this.lblDeleteTable_Click);
            // 
            // lblRenameTable
            // 
            this.lblRenameTable.AutoSize = true;
            this.lblRenameTable.Location = new System.Drawing.Point(6, 60);
            this.lblRenameTable.Name = "lblRenameTable";
            this.lblRenameTable.Size = new System.Drawing.Size(96, 17);
            this.lblRenameTable.TabIndex = 1;
            this.lblRenameTable.Text = "Rename table";
            this.lblRenameTable.Click += new System.EventHandler(this.lblRenameTable_Click);
            // 
            // lblOpenTable
            // 
            this.lblOpenTable.AutoSize = true;
            this.lblOpenTable.Location = new System.Drawing.Point(6, 15);
            this.lblOpenTable.Name = "lblOpenTable";
            this.lblOpenTable.Size = new System.Drawing.Size(78, 17);
            this.lblOpenTable.TabIndex = 0;
            this.lblOpenTable.Text = "Open table";
            this.lblOpenTable.Click += new System.EventHandler(this.lblOpenTable_Click);
            // 
            // projectOptionsPanel
            // 
            this.projectOptionsPanel.BackColor = System.Drawing.Color.DarkGray;
            this.projectOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectOptionsPanel.CausesValidation = false;
            this.projectOptionsPanel.Controls.Add(this.convertToSQL);
            this.projectOptionsPanel.Controls.Add(this.lblGenerateERA);
            this.projectOptionsPanel.Controls.Add(this.lblCloseProject);
            this.projectOptionsPanel.Controls.Add(this.lblNewTable);
            this.projectOptionsPanel.Controls.Add(this.lblDeleteProjectRightClick);
            this.projectOptionsPanel.Controls.Add(this.lblRenameProjectRightClick);
            this.projectOptionsPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectOptionsPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.projectOptionsPanel.Location = new System.Drawing.Point(72, 80);
            this.projectOptionsPanel.Name = "projectOptionsPanel";
            this.projectOptionsPanel.Padding = new System.Windows.Forms.Padding(2);
            this.projectOptionsPanel.Size = new System.Drawing.Size(125, 0);
            this.projectOptionsPanel.TabIndex = 4;
            // 
            // convertToSQL
            // 
            this.convertToSQL.AutoSize = true;
            this.convertToSQL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.convertToSQL.Location = new System.Drawing.Point(5, 201);
            this.convertToSQL.Name = "convertToSQL";
            this.convertToSQL.Size = new System.Drawing.Size(109, 17);
            this.convertToSQL.TabIndex = 5;
            this.convertToSQL.Text = "Convert to SQL";
            this.convertToSQL.Click += new System.EventHandler(this.convertToSQL_Click);
            // 
            // lblGenerateERA
            // 
            this.lblGenerateERA.AutoSize = true;
            this.lblGenerateERA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGenerateERA.Location = new System.Drawing.Point(5, 154);
            this.lblGenerateERA.Name = "lblGenerateERA";
            this.lblGenerateERA.Size = new System.Drawing.Size(102, 17);
            this.lblGenerateERA.TabIndex = 4;
            this.lblGenerateERA.Text = "Generate ERA";
            this.lblGenerateERA.Click += new System.EventHandler(this.lblGenerateERA_Click);
            // 
            // lblCloseProject
            // 
            this.lblCloseProject.AutoSize = true;
            this.lblCloseProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCloseProject.Location = new System.Drawing.Point(5, 107);
            this.lblCloseProject.Name = "lblCloseProject";
            this.lblCloseProject.Size = new System.Drawing.Size(94, 17);
            this.lblCloseProject.TabIndex = 3;
            this.lblCloseProject.Text = "Close project";
            this.lblCloseProject.Click += new System.EventHandler(this.lblCloseProject_Click);
            // 
            // lblNewTable
            // 
            this.lblNewTable.AutoSize = true;
            this.lblNewTable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewTable.Location = new System.Drawing.Point(5, 17);
            this.lblNewTable.Name = "lblNewTable";
            this.lblNewTable.Size = new System.Drawing.Size(72, 17);
            this.lblNewTable.TabIndex = 0;
            this.lblNewTable.Text = "New table";
            this.lblNewTable.Click += new System.EventHandler(this.lblNewTable_Click);
            // 
            // lblDeleteProjectRightClick
            // 
            this.lblDeleteProjectRightClick.AutoSize = true;
            this.lblDeleteProjectRightClick.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteProjectRightClick.Location = new System.Drawing.Point(5, 248);
            this.lblDeleteProjectRightClick.Name = "lblDeleteProjectRightClick";
            this.lblDeleteProjectRightClick.Size = new System.Drawing.Size(98, 17);
            this.lblDeleteProjectRightClick.TabIndex = 2;
            this.lblDeleteProjectRightClick.Text = "Delete project";
            this.lblDeleteProjectRightClick.Click += new System.EventHandler(this.lblDeleteProjectRightClick_Click);
            // 
            // lblRenameProjectRightClick
            // 
            this.lblRenameProjectRightClick.AutoSize = true;
            this.lblRenameProjectRightClick.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRenameProjectRightClick.Location = new System.Drawing.Point(5, 60);
            this.lblRenameProjectRightClick.Name = "lblRenameProjectRightClick";
            this.lblRenameProjectRightClick.Size = new System.Drawing.Size(112, 17);
            this.lblRenameProjectRightClick.TabIndex = 1;
            this.lblRenameProjectRightClick.Text = "Rename project";
            this.lblRenameProjectRightClick.Click += new System.EventHandler(this.lblRenameProjectRightClick_Click);
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.filePanel.Controls.Add(this.lblExit);
            this.filePanel.Controls.Add(this.lblExport);
            this.filePanel.Controls.Add(this.lblSaveAll);
            this.filePanel.Controls.Add(this.lblOpenProject);
            this.filePanel.Controls.Add(this.lblNewProject);
            this.filePanel.Location = new System.Drawing.Point(0, 0);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(139, 0);
            this.filePanel.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExit.Location = new System.Drawing.Point(20, 175);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 17);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExport.Location = new System.Drawing.Point(20, 95);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(50, 17);
            this.lblExport.TabIndex = 4;
            this.lblExport.Text = "Export";
            this.lblExport.Click += new System.EventHandler(this.lblExport_Click);
            // 
            // lblSaveAll
            // 
            this.lblSaveAll.AutoSize = true;
            this.lblSaveAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSaveAll.Location = new System.Drawing.Point(20, 135);
            this.lblSaveAll.Name = "lblSaveAll";
            this.lblSaveAll.Size = new System.Drawing.Size(59, 17);
            this.lblSaveAll.TabIndex = 3;
            this.lblSaveAll.Text = "Save All";
            this.lblSaveAll.Click += new System.EventHandler(this.lblSaveAll_Click);
            // 
            // lblOpenProject
            // 
            this.lblOpenProject.AutoSize = true;
            this.lblOpenProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpenProject.Location = new System.Drawing.Point(20, 55);
            this.lblOpenProject.Name = "lblOpenProject";
            this.lblOpenProject.Size = new System.Drawing.Size(94, 17);
            this.lblOpenProject.TabIndex = 2;
            this.lblOpenProject.Text = "Open Project";
            this.lblOpenProject.Click += new System.EventHandler(this.lblOpenProject_Click);
            // 
            // lblNewProject
            // 
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewProject.Location = new System.Drawing.Point(20, 20);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(87, 17);
            this.lblNewProject.TabIndex = 1;
            this.lblNewProject.Text = "New Project";
            this.lblNewProject.Click += new System.EventHandler(this.lblNewProject_Click);
            // 
            // treeProject
            // 
            this.treeProject.BackColor = System.Drawing.Color.Silver;
            this.treeProject.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeProject.Location = new System.Drawing.Point(28, 23);
            this.treeProject.Name = "treeProject";
            treeNode1.Name = "projectNode";
            treeNode1.Text = "Projects";
            this.treeProject.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeProject.Size = new System.Drawing.Size(160, 549);
            this.treeProject.TabIndex = 4;
            this.treeProject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeProject_NodeMouseClick);
            this.treeProject.Click += new System.EventHandler(this.treeProject_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(28, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 23);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 572);
            this.panel4.TabIndex = 5;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // lblRenameProject
            // 
            this.lblRenameProject.AutoSize = true;
            this.lblRenameProject.Location = new System.Drawing.Point(0, 0);
            this.lblRenameProject.Name = "lblRenameProject";
            this.lblRenameProject.Size = new System.Drawing.Size(109, 17);
            this.lblRenameProject.TabIndex = 5;
            this.lblRenameProject.Text = "Rename Project";
            // 
            // panelERADijagrama
            // 
            this.panelERADijagrama.BackColor = System.Drawing.Color.White;
            this.panelERADijagrama.Controls.Add(this.lblRenameProject);
            this.panelERADijagrama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelERADijagrama.Location = new System.Drawing.Point(0, 0);
            this.panelERADijagrama.Name = "panelERADijagrama";
            this.panelERADijagrama.Size = new System.Drawing.Size(1315, 592);
            this.panelERADijagrama.TabIndex = 3;
            this.panelERADijagrama.Click += new System.EventHandler(this.panelERADijagrama_Click);
            this.panelERADijagrama.Paint += new System.Windows.Forms.PaintEventHandler(this.panelERADijagrama_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // formERADijagram
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1315, 592);
            this.Controls.Add(this.panelLeftProjects);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelERADijagrama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formERADijagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formERADijagram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.formERADijagram_Activated);
            this.Load += new System.EventHandler(this.formERADijagram_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelLeftProjects.ResumeLayout(false);
            this.panelTableOptions.ResumeLayout(false);
            this.panelTableOptions.PerformLayout();
            this.projectOptionsPanel.ResumeLayout(false);
            this.projectOptionsPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.panelERADijagrama.ResumeLayout(false);
            this.panelERADijagrama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLeftProjects;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnMaximaze;
        private System.Windows.Forms.Panel panelERADijagrama;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Label lblOpenProject;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.Label lblSaveAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblRenameProject;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.TreeView treeProject;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel projectOptionsPanel;
        private System.Windows.Forms.Label lblDeleteProjectRightClick;
        private System.Windows.Forms.Label lblRenameProjectRightClick;
        private System.Windows.Forms.Label lblNewTable;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelTableOptions;
        private System.Windows.Forms.Label lblDeleteTable;
        private System.Windows.Forms.Label lblRenameTable;
        private System.Windows.Forms.Label lblOpenTable;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblCloseProject;
        private System.Windows.Forms.Label lblGenerateERA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label convertToSQL;
    }
}