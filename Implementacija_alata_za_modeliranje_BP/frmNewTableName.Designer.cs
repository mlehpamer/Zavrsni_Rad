namespace Implementacija_alata_za_modeliranje_BP
{
    partial class frmNewTableName
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
            this.btnCloseFormNewTable = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnSaveTableName = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCloseFormNewTable
            // 
            this.btnCloseFormNewTable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCloseFormNewTable.Location = new System.Drawing.Point(160, 140);
            this.btnCloseFormNewTable.Name = "btnCloseFormNewTable";
            this.btnCloseFormNewTable.Size = new System.Drawing.Size(83, 24);
            this.btnCloseFormNewTable.TabIndex = 10;
            this.btnCloseFormNewTable.Text = "Close";
            this.btnCloseFormNewTable.UseVisualStyleBackColor = false;
            this.btnCloseFormNewTable.Click += new System.EventHandler(this.btnCloseFormNewTable_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTableName.Location = new System.Drawing.Point(45, 81);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(87, 17);
            this.lblTableName.TabIndex = 9;
            this.lblTableName.Text = "Table name:";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveTableName
            // 
            this.btnSaveTableName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveTableName.Location = new System.Drawing.Point(260, 140);
            this.btnSaveTableName.Name = "btnSaveTableName";
            this.btnSaveTableName.Size = new System.Drawing.Size(83, 24);
            this.btnSaveTableName.TabIndex = 8;
            this.btnSaveTableName.Text = "Save";
            this.btnSaveTableName.UseVisualStyleBackColor = false;
            this.btnSaveTableName.Click += new System.EventHandler(this.btnSaveTableName_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTableName.Location = new System.Drawing.Point(160, 81);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(183, 25);
            this.txtTableName.TabIndex = 7;
            // 
            // frmNewTableName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 246);
            this.Controls.Add(this.btnCloseFormNewTable);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.btnSaveTableName);
            this.Controls.Add(this.txtTableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewTableName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewTableName";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNewTableName_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmNewTableName_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseFormNewTable;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnSaveTableName;
        private System.Windows.Forms.TextBox txtTableName;
    }
}