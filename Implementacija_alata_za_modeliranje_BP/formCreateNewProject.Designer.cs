namespace Implementacija_alata_za_modeliranje_BP
{
    partial class formCreateNewProject
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnSaveProjectName = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnCloseFormNewProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProjectName.Location = new System.Drawing.Point(160, 81);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(183, 25);
            this.txtProjectName.TabIndex = 0;
            // 
            // btnSaveProjectName
            // 
            this.btnSaveProjectName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveProjectName.Location = new System.Drawing.Point(260, 140);
            this.btnSaveProjectName.Name = "btnSaveProjectName";
            this.btnSaveProjectName.Size = new System.Drawing.Size(83, 24);
            this.btnSaveProjectName.TabIndex = 3;
            this.btnSaveProjectName.Text = "Save";
            this.btnSaveProjectName.UseVisualStyleBackColor = false;
            this.btnSaveProjectName.Click += new System.EventHandler(this.btnSaveProjectName_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjectName.Location = new System.Drawing.Point(45, 81);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(99, 17);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "Project name:";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCloseFormNewProject
            // 
            this.btnCloseFormNewProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCloseFormNewProject.Location = new System.Drawing.Point(160, 140);
            this.btnCloseFormNewProject.Name = "btnCloseFormNewProject";
            this.btnCloseFormNewProject.Size = new System.Drawing.Size(83, 24);
            this.btnCloseFormNewProject.TabIndex = 6;
            this.btnCloseFormNewProject.Text = "Close";
            this.btnCloseFormNewProject.UseVisualStyleBackColor = false;
            this.btnCloseFormNewProject.Click += new System.EventHandler(this.btnCloseFormNewProject_Click);
            // 
            // formCreateNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 246);
            this.Controls.Add(this.btnCloseFormNewProject);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnSaveProjectName);
            this.Controls.Add(this.txtProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCreateNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCreateNewProject";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formCreateNewProject_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formCreateNewProject_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnSaveProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnCloseFormNewProject;
    }
}