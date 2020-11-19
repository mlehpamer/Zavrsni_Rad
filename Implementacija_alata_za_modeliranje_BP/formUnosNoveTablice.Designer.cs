namespace Implementacija_alata_za_modeliranje_BP
{
    partial class formNovaTablica
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
            this.formNovaTablicaPozadina = new System.Windows.Forms.Button();
            this.lblImeForme = new System.Windows.Forms.Label();
            this.lblImeTablice = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.foreignTab = new System.Windows.Forms.TabPage();
            this.btnDeleteForeignKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFKOnAtribut = new System.Windows.Forms.Label();
            this.cmbSelectedTablePK = new System.Windows.Forms.ComboBox();
            this.cmbCurrentTableAtributes = new System.Windows.Forms.ComboBox();
            this.cmbFKTableName = new System.Windows.Forms.ComboBox();
            this.v = new System.Windows.Forms.Button();
            this.dgvForeignKeys = new System.Windows.Forms.DataGridView();
            this.targetTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromAtribut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toAtribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblForeignTable = new System.Windows.Forms.Label();
            this.lblForeignName = new System.Windows.Forms.Label();
            this.txtForeignName = new System.Windows.Forms.TextBox();
            this.keysTab = new System.Windows.Forms.TabPage();
            this.cmbColumnAtribut = new System.Windows.Forms.ComboBox();
            this.btnKeysAdd = new System.Windows.Forms.Button();
            this.lblKeysTabColumnName = new System.Windows.Forms.Label();
            this.chcboxKeysPrimary = new System.Windows.Forms.CheckBox();
            this.dgvKeys = new System.Windows.Forms.DataGridView();
            this.columnAtributName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAtributType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAtributPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKeyNameTable = new System.Windows.Forms.Label();
            this.txtKeyNameTable = new System.Windows.Forms.TextBox();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.btnNewColumnRemove = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUnosStupca = new System.Windows.Forms.Button();
            this.dgvStupci = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAutoInc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnNotNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnPrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chcoxPrimaryKey = new System.Windows.Forms.CheckBox();
            this.chcboxUnique = new System.Windows.Forms.CheckBox();
            this.chcboxAutoInc = new System.Windows.Forms.CheckBox();
            this.chcBoxNotNull = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.foreignTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForeignKeys)).BeginInit();
            this.keysTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeys)).BeginInit();
            this.dataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStupci)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // formNovaTablicaPozadina
            // 
            this.formNovaTablicaPozadina.BackColor = System.Drawing.Color.Gray;
            this.formNovaTablicaPozadina.Enabled = false;
            this.formNovaTablicaPozadina.Location = new System.Drawing.Point(9, 9);
            this.formNovaTablicaPozadina.Name = "formNovaTablicaPozadina";
            this.formNovaTablicaPozadina.Size = new System.Drawing.Size(1178, 590);
            this.formNovaTablicaPozadina.TabIndex = 0;
            this.formNovaTablicaPozadina.UseVisualStyleBackColor = false;
            // 
            // lblImeForme
            // 
            this.lblImeForme.BackColor = System.Drawing.Color.Gray;
            this.lblImeForme.Enabled = false;
            this.lblImeForme.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeForme.Location = new System.Drawing.Point(26, 20);
            this.lblImeForme.Name = "lblImeForme";
            this.lblImeForme.Size = new System.Drawing.Size(164, 30);
            this.lblImeForme.TabIndex = 2;
            this.lblImeForme.Text = "New table:";
            // 
            // lblImeTablice
            // 
            this.lblImeTablice.BackColor = System.Drawing.Color.Gray;
            this.lblImeTablice.Enabled = false;
            this.lblImeTablice.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeTablice.Location = new System.Drawing.Point(26, 75);
            this.lblImeTablice.Name = "lblImeTablice";
            this.lblImeTablice.Size = new System.Drawing.Size(113, 24);
            this.lblImeTablice.TabIndex = 3;
            this.lblImeTablice.Text = "Table name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Enabled = false;
            this.txtTableName.Location = new System.Drawing.Point(30, 107);
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(191, 23);
            this.txtTableName.TabIndex = 6;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(28, 509);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(81, 35);
            this.btnSpremi.TabIndex = 18;
            this.btnSpremi.Text = "Save";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(174, 509);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(0);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(81, 35);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // foreignTab
            // 
            this.foreignTab.BackColor = System.Drawing.Color.Gray;
            this.foreignTab.Controls.Add(this.btnDeleteForeignKey);
            this.foreignTab.Controls.Add(this.label1);
            this.foreignTab.Controls.Add(this.lblFKOnAtribut);
            this.foreignTab.Controls.Add(this.cmbSelectedTablePK);
            this.foreignTab.Controls.Add(this.cmbCurrentTableAtributes);
            this.foreignTab.Controls.Add(this.cmbFKTableName);
            this.foreignTab.Controls.Add(this.v);
            this.foreignTab.Controls.Add(this.dgvForeignKeys);
            this.foreignTab.Controls.Add(this.lblForeignTable);
            this.foreignTab.Controls.Add(this.lblForeignName);
            this.foreignTab.Controls.Add(this.txtForeignName);
            this.foreignTab.Location = new System.Drawing.Point(4, 28);
            this.foreignTab.Name = "foreignTab";
            this.foreignTab.Padding = new System.Windows.Forms.Padding(3);
            this.foreignTab.Size = new System.Drawing.Size(779, 433);
            this.foreignTab.TabIndex = 4;
            this.foreignTab.Text = "Foreign Key";
            // 
            // btnDeleteForeignKey
            // 
            this.btnDeleteForeignKey.AutoEllipsis = true;
            this.btnDeleteForeignKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteForeignKey.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteForeignKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteForeignKey.FlatAppearance.BorderSize = 0;
            this.btnDeleteForeignKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteForeignKey.Location = new System.Drawing.Point(671, 147);
            this.btnDeleteForeignKey.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteForeignKey.Name = "btnDeleteForeignKey";
            this.btnDeleteForeignKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteForeignKey.Size = new System.Drawing.Size(43, 43);
            this.btnDeleteForeignKey.TabIndex = 53;
            this.btnDeleteForeignKey.Text = "-";
            this.btnDeleteForeignKey.UseVisualStyleBackColor = false;
            this.btnDeleteForeignKey.Click += new System.EventHandler(this.btnDeleteForeignKey_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(346, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "To:";
            // 
            // lblFKOnAtribut
            // 
            this.lblFKOnAtribut.BackColor = System.Drawing.Color.Gray;
            this.lblFKOnAtribut.Enabled = false;
            this.lblFKOnAtribut.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFKOnAtribut.Location = new System.Drawing.Point(346, 33);
            this.lblFKOnAtribut.Name = "lblFKOnAtribut";
            this.lblFKOnAtribut.Size = new System.Drawing.Size(113, 24);
            this.lblFKOnAtribut.TabIndex = 51;
            this.lblFKOnAtribut.Text = "From:";
            // 
            // cmbSelectedTablePK
            // 
            this.cmbSelectedTablePK.FormattingEnabled = true;
            this.cmbSelectedTablePK.Location = new System.Drawing.Point(478, 88);
            this.cmbSelectedTablePK.Name = "cmbSelectedTablePK";
            this.cmbSelectedTablePK.Size = new System.Drawing.Size(121, 24);
            this.cmbSelectedTablePK.TabIndex = 50;
            // 
            // cmbCurrentTableAtributes
            // 
            this.cmbCurrentTableAtributes.FormattingEnabled = true;
            this.cmbCurrentTableAtributes.Location = new System.Drawing.Point(478, 34);
            this.cmbCurrentTableAtributes.Name = "cmbCurrentTableAtributes";
            this.cmbCurrentTableAtributes.Size = new System.Drawing.Size(121, 24);
            this.cmbCurrentTableAtributes.TabIndex = 49;
            // 
            // cmbFKTableName
            // 
            this.cmbFKTableName.FormattingEnabled = true;
            this.cmbFKTableName.Location = new System.Drawing.Point(162, 89);
            this.cmbFKTableName.Name = "cmbFKTableName";
            this.cmbFKTableName.Size = new System.Drawing.Size(121, 24);
            this.cmbFKTableName.TabIndex = 48;
            this.cmbFKTableName.SelectionChangeCommitted += new System.EventHandler(this.cmbFKTableName_SelectionChangeCommitted);
            // 
            // v
            // 
            this.v.AutoEllipsis = true;
            this.v.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.v.BackColor = System.Drawing.Color.Gray;
            this.v.Cursor = System.Windows.Forms.Cursors.Default;
            this.v.FlatAppearance.BorderSize = 0;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v.Location = new System.Drawing.Point(599, 147);
            this.v.Margin = new System.Windows.Forms.Padding(0);
            this.v.Name = "v";
            this.v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.v.Size = new System.Drawing.Size(43, 43);
            this.v.TabIndex = 43;
            this.v.Text = "+";
            this.v.UseVisualStyleBackColor = false;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // dgvForeignKeys
            // 
            this.dgvForeignKeys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForeignKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForeignKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetTable,
            this.fromAtribut,
            this.toAtribute});
            this.dgvForeignKeys.Location = new System.Drawing.Point(34, 205);
            this.dgvForeignKeys.Name = "dgvForeignKeys";
            this.dgvForeignKeys.RowHeadersWidth = 51;
            this.dgvForeignKeys.RowTemplate.Height = 24;
            this.dgvForeignKeys.Size = new System.Drawing.Size(680, 209);
            this.dgvForeignKeys.TabIndex = 11;
            // 
            // targetTable
            // 
            this.targetTable.HeaderText = "Target Table";
            this.targetTable.MinimumWidth = 6;
            this.targetTable.Name = "targetTable";
            // 
            // fromAtribut
            // 
            this.fromAtribut.HeaderText = "From atribute(FK)";
            this.fromAtribut.MinimumWidth = 6;
            this.fromAtribut.Name = "fromAtribut";
            // 
            // toAtribute
            // 
            this.toAtribute.HeaderText = "To atribute(PK)";
            this.toAtribute.MinimumWidth = 6;
            this.toAtribute.Name = "toAtribute";
            // 
            // lblForeignTable
            // 
            this.lblForeignTable.BackColor = System.Drawing.Color.Gray;
            this.lblForeignTable.Enabled = false;
            this.lblForeignTable.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForeignTable.Location = new System.Drawing.Point(30, 89);
            this.lblForeignTable.Name = "lblForeignTable";
            this.lblForeignTable.Size = new System.Drawing.Size(113, 24);
            this.lblForeignTable.TabIndex = 10;
            this.lblForeignTable.Text = "Table name:";
            // 
            // lblForeignName
            // 
            this.lblForeignName.BackColor = System.Drawing.Color.Gray;
            this.lblForeignName.Enabled = false;
            this.lblForeignName.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForeignName.Location = new System.Drawing.Point(30, 35);
            this.lblForeignName.Name = "lblForeignName";
            this.lblForeignName.Size = new System.Drawing.Size(113, 24);
            this.lblForeignName.TabIndex = 8;
            this.lblForeignName.Text = "Name:";
            // 
            // txtForeignName
            // 
            this.txtForeignName.Location = new System.Drawing.Point(162, 35);
            this.txtForeignName.Name = "txtForeignName";
            this.txtForeignName.Size = new System.Drawing.Size(121, 23);
            this.txtForeignName.TabIndex = 7;
            // 
            // keysTab
            // 
            this.keysTab.BackColor = System.Drawing.Color.Gray;
            this.keysTab.Controls.Add(this.cmbColumnAtribut);
            this.keysTab.Controls.Add(this.btnKeysAdd);
            this.keysTab.Controls.Add(this.lblKeysTabColumnName);
            this.keysTab.Controls.Add(this.chcboxKeysPrimary);
            this.keysTab.Controls.Add(this.dgvKeys);
            this.keysTab.Controls.Add(this.lblKeyNameTable);
            this.keysTab.Controls.Add(this.txtKeyNameTable);
            this.keysTab.Location = new System.Drawing.Point(4, 28);
            this.keysTab.Name = "keysTab";
            this.keysTab.Padding = new System.Windows.Forms.Padding(3);
            this.keysTab.Size = new System.Drawing.Size(779, 433);
            this.keysTab.TabIndex = 2;
            this.keysTab.Text = "Keys";
            // 
            // cmbColumnAtribut
            // 
            this.cmbColumnAtribut.FormattingEnabled = true;
            this.cmbColumnAtribut.Location = new System.Drawing.Point(531, 56);
            this.cmbColumnAtribut.Name = "cmbColumnAtribut";
            this.cmbColumnAtribut.Size = new System.Drawing.Size(139, 24);
            this.cmbColumnAtribut.TabIndex = 37;
            // 
            // btnKeysAdd
            // 
            this.btnKeysAdd.AutoEllipsis = true;
            this.btnKeysAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKeysAdd.BackColor = System.Drawing.Color.Gray;
            this.btnKeysAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKeysAdd.FlatAppearance.BorderSize = 0;
            this.btnKeysAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKeysAdd.Location = new System.Drawing.Point(636, 119);
            this.btnKeysAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeysAdd.Name = "btnKeysAdd";
            this.btnKeysAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKeysAdd.Size = new System.Drawing.Size(43, 43);
            this.btnKeysAdd.TabIndex = 35;
            this.btnKeysAdd.Text = "+";
            this.btnKeysAdd.UseVisualStyleBackColor = false;
            this.btnKeysAdd.Click += new System.EventHandler(this.btnKeysAdd_Click);
            // 
            // lblKeysTabColumnName
            // 
            this.lblKeysTabColumnName.BackColor = System.Drawing.Color.Gray;
            this.lblKeysTabColumnName.Enabled = false;
            this.lblKeysTabColumnName.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKeysTabColumnName.Location = new System.Drawing.Point(443, 63);
            this.lblKeysTabColumnName.Name = "lblKeysTabColumnName";
            this.lblKeysTabColumnName.Size = new System.Drawing.Size(82, 29);
            this.lblKeysTabColumnName.TabIndex = 12;
            this.lblKeysTabColumnName.Text = "Column:";
            // 
            // chcboxKeysPrimary
            // 
            this.chcboxKeysPrimary.AutoSize = true;
            this.chcboxKeysPrimary.Checked = true;
            this.chcboxKeysPrimary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcboxKeysPrimary.Location = new System.Drawing.Point(155, 119);
            this.chcboxKeysPrimary.Name = "chcboxKeysPrimary";
            this.chcboxKeysPrimary.Size = new System.Drawing.Size(110, 20);
            this.chcboxKeysPrimary.TabIndex = 10;
            this.chcboxKeysPrimary.Text = "Primary key";
            this.chcboxKeysPrimary.UseVisualStyleBackColor = true;
            // 
            // dgvKeys
            // 
            this.dgvKeys.AllowUserToAddRows = false;
            this.dgvKeys.AllowUserToResizeColumns = false;
            this.dgvKeys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAtributName,
            this.columnAtributType,
            this.columnAtributPK});
            this.dgvKeys.Location = new System.Drawing.Point(41, 197);
            this.dgvKeys.Name = "dgvKeys";
            this.dgvKeys.RowHeadersWidth = 51;
            this.dgvKeys.RowTemplate.Height = 24;
            this.dgvKeys.Size = new System.Drawing.Size(679, 174);
            this.dgvKeys.TabIndex = 9;
            // 
            // columnAtributName
            // 
            this.columnAtributName.HeaderText = "Name";
            this.columnAtributName.MinimumWidth = 6;
            this.columnAtributName.Name = "columnAtributName";
            // 
            // columnAtributType
            // 
            this.columnAtributType.HeaderText = "Type";
            this.columnAtributType.MinimumWidth = 6;
            this.columnAtributType.Name = "columnAtributType";
            // 
            // columnAtributPK
            // 
            this.columnAtributPK.HeaderText = "PK";
            this.columnAtributPK.MinimumWidth = 6;
            this.columnAtributPK.Name = "columnAtributPK";
            // 
            // lblKeyNameTable
            // 
            this.lblKeyNameTable.BackColor = System.Drawing.Color.Gray;
            this.lblKeyNameTable.Enabled = false;
            this.lblKeyNameTable.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKeyNameTable.Location = new System.Drawing.Point(27, 56);
            this.lblKeyNameTable.Name = "lblKeyNameTable";
            this.lblKeyNameTable.Size = new System.Drawing.Size(122, 36);
            this.lblKeyNameTable.TabIndex = 8;
            this.lblKeyNameTable.Text = "Table Name:";
            // 
            // txtKeyNameTable
            // 
            this.txtKeyNameTable.Enabled = false;
            this.txtKeyNameTable.Location = new System.Drawing.Point(155, 56);
            this.txtKeyNameTable.Name = "txtKeyNameTable";
            this.txtKeyNameTable.Size = new System.Drawing.Size(139, 23);
            this.txtKeyNameTable.TabIndex = 7;
            // 
            // dataTab
            // 
            this.dataTab.BackColor = System.Drawing.Color.Gray;
            this.dataTab.Controls.Add(this.btnNewColumnRemove);
            this.dataTab.Controls.Add(this.txtType);
            this.dataTab.Controls.Add(this.txtName);
            this.dataTab.Controls.Add(this.btnUnosStupca);
            this.dataTab.Controls.Add(this.dgvStupci);
            this.dataTab.Controls.Add(this.chcoxPrimaryKey);
            this.dataTab.Controls.Add(this.chcboxUnique);
            this.dataTab.Controls.Add(this.chcboxAutoInc);
            this.dataTab.Controls.Add(this.chcBoxNotNull);
            this.dataTab.Controls.Add(this.lblName);
            this.dataTab.Controls.Add(this.lblType);
            this.dataTab.Location = new System.Drawing.Point(4, 28);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(779, 433);
            this.dataTab.TabIndex = 1;
            this.dataTab.Text = "New column";
            // 
            // btnNewColumnRemove
            // 
            this.btnNewColumnRemove.AutoEllipsis = true;
            this.btnNewColumnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewColumnRemove.BackColor = System.Drawing.Color.Gray;
            this.btnNewColumnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNewColumnRemove.FlatAppearance.BorderSize = 0;
            this.btnNewColumnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewColumnRemove.Location = new System.Drawing.Point(709, 113);
            this.btnNewColumnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewColumnRemove.Name = "btnNewColumnRemove";
            this.btnNewColumnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNewColumnRemove.Size = new System.Drawing.Size(43, 43);
            this.btnNewColumnRemove.TabIndex = 35;
            this.btnNewColumnRemove.Text = "-";
            this.btnNewColumnRemove.UseVisualStyleBackColor = false;
            this.btnNewColumnRemove.Click += new System.EventHandler(this.btnNewColumnRemove_Click);
            // 
            // txtType
            // 
            this.txtType.AutoCompleteCustomSource.AddRange(new string[] {
            "char(n)",
            "varchar(n)",
            "binary(n)",
            "varbinary(n)",
            "tinyblob",
            "tinytext",
            "text(n)",
            "blob(n)",
            "mediumtext",
            "mediumblob",
            "longtext",
            "longblob",
            "bit(n)",
            "tinyint(n)",
            "bool",
            "boolean",
            "smallint(n)",
            "mediumint(n)",
            "int(n)",
            "integer(n)",
            "bigint(n)",
            "float(n)",
            "double(n)",
            "decimal(n)",
            "date()",
            "datettime()",
            "timestamp()",
            "time()",
            "year()"});
            this.txtType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(321, 52);
            this.txtType.Name = "txtType";
            this.txtType.ShortcutsEnabled = false;
            this.txtType.Size = new System.Drawing.Size(136, 25);
            this.txtType.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(72, 52);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 23);
            this.txtName.TabIndex = 19;
            // 
            // btnUnosStupca
            // 
            this.btnUnosStupca.AutoEllipsis = true;
            this.btnUnosStupca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnosStupca.BackColor = System.Drawing.Color.Gray;
            this.btnUnosStupca.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnosStupca.FlatAppearance.BorderSize = 0;
            this.btnUnosStupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnosStupca.Location = new System.Drawing.Point(641, 113);
            this.btnUnosStupca.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnosStupca.Name = "btnUnosStupca";
            this.btnUnosStupca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUnosStupca.Size = new System.Drawing.Size(43, 43);
            this.btnUnosStupca.TabIndex = 34;
            this.btnUnosStupca.Text = "+";
            this.btnUnosStupca.UseVisualStyleBackColor = false;
            this.btnUnosStupca.Click += new System.EventHandler(this.btnUnosStupca_Click);
            // 
            // dgvStupci
            // 
            this.dgvStupci.AllowUserToResizeColumns = false;
            this.dgvStupci.AllowUserToResizeRows = false;
            this.dgvStupci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStupci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvStupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnType,
            this.columnAutoInc,
            this.columnNotNull,
            this.columnPrimaryKey});
            this.dgvStupci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvStupci.Location = new System.Drawing.Point(29, 198);
            this.dgvStupci.Name = "dgvStupci";
            this.dgvStupci.ReadOnly = true;
            this.dgvStupci.RowHeadersWidth = 51;
            this.dgvStupci.RowTemplate.Height = 24;
            this.dgvStupci.Size = new System.Drawing.Size(733, 204);
            this.dgvStupci.TabIndex = 33;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Type";
            this.columnType.MinimumWidth = 6;
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            // 
            // columnAutoInc
            // 
            this.columnAutoInc.HeaderText = "Auto_inc";
            this.columnAutoInc.MinimumWidth = 6;
            this.columnAutoInc.Name = "columnAutoInc";
            this.columnAutoInc.ReadOnly = true;
            this.columnAutoInc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnAutoInc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnNotNull
            // 
            this.columnNotNull.HeaderText = "Not_Null";
            this.columnNotNull.MinimumWidth = 6;
            this.columnNotNull.Name = "columnNotNull";
            this.columnNotNull.ReadOnly = true;
            this.columnNotNull.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnNotNull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnPrimaryKey
            // 
            this.columnPrimaryKey.HeaderText = "Primary_Key";
            this.columnPrimaryKey.MinimumWidth = 6;
            this.columnPrimaryKey.Name = "columnPrimaryKey";
            this.columnPrimaryKey.ReadOnly = true;
            this.columnPrimaryKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnPrimaryKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chcoxPrimaryKey
            // 
            this.chcoxPrimaryKey.AutoSize = true;
            this.chcoxPrimaryKey.Location = new System.Drawing.Point(472, 128);
            this.chcoxPrimaryKey.Name = "chcoxPrimaryKey";
            this.chcoxPrimaryKey.Size = new System.Drawing.Size(110, 20);
            this.chcoxPrimaryKey.TabIndex = 32;
            this.chcoxPrimaryKey.Text = "Primary key";
            this.chcoxPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // chcboxUnique
            // 
            this.chcboxUnique.AutoSize = true;
            this.chcboxUnique.Location = new System.Drawing.Point(343, 128);
            this.chcboxUnique.Name = "chcboxUnique";
            this.chcboxUnique.Size = new System.Drawing.Size(80, 20);
            this.chcboxUnique.TabIndex = 31;
            this.chcboxUnique.Text = "Unique";
            this.chcboxUnique.UseVisualStyleBackColor = true;
            // 
            // chcboxAutoInc
            // 
            this.chcboxAutoInc.AutoSize = true;
            this.chcboxAutoInc.Location = new System.Drawing.Point(203, 128);
            this.chcboxAutoInc.Name = "chcboxAutoInc";
            this.chcboxAutoInc.Size = new System.Drawing.Size(91, 20);
            this.chcboxAutoInc.TabIndex = 30;
            this.chcboxAutoInc.Text = "Auto inc.";
            this.chcboxAutoInc.UseVisualStyleBackColor = true;
            // 
            // chcBoxNotNull
            // 
            this.chcBoxNotNull.AutoSize = true;
            this.chcBoxNotNull.Location = new System.Drawing.Point(72, 128);
            this.chcBoxNotNull.Name = "chcBoxNotNull";
            this.chcBoxNotNull.Size = new System.Drawing.Size(85, 20);
            this.chcBoxNotNull.TabIndex = 29;
            this.chcBoxNotNull.Text = "Not Null";
            this.chcBoxNotNull.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Gray;
            this.lblName.Enabled = false;
            this.lblName.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(6, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 30);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Gray;
            this.lblType.Enabled = false;
            this.lblType.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblType.Location = new System.Drawing.Point(263, 55);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 30);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type:";
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.dataTab);
            this.tabControl.Controls.Add(this.keysTab);
            this.tabControl.Controls.Add(this.foreignTab);
            this.tabControl.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(305, 79);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(787, 465);
            this.tabControl.TabIndex = 17;
            // 
            // formNovaTablica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1199, 611);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.lblImeTablice);
            this.Controls.Add(this.lblImeForme);
            this.Controls.Add(this.formNovaTablicaPozadina);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formNovaTablica";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Unos nove tablice";
            this.Load += new System.EventHandler(this.formNovaTablica_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formNovaTablica_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formNovaTablica_MouseMove);
            this.foreignTab.ResumeLayout(false);
            this.foreignTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForeignKeys)).EndInit();
            this.keysTab.ResumeLayout(false);
            this.keysTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeys)).EndInit();
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStupci)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formNovaTablicaPozadina;
        private System.Windows.Forms.Label lblImeForme;
        private System.Windows.Forms.Label lblImeTablice;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TabPage foreignTab;
        private System.Windows.Forms.Button btnDeleteForeignKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFKOnAtribut;
        private System.Windows.Forms.ComboBox cmbSelectedTablePK;
        private System.Windows.Forms.ComboBox cmbCurrentTableAtributes;
        private System.Windows.Forms.ComboBox cmbFKTableName;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.DataGridView dgvForeignKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromAtribut;
        private System.Windows.Forms.DataGridViewTextBoxColumn toAtribute;
        private System.Windows.Forms.Label lblForeignTable;
        private System.Windows.Forms.Label lblForeignName;
        private System.Windows.Forms.TextBox txtForeignName;
        private System.Windows.Forms.TabPage keysTab;
        private System.Windows.Forms.ComboBox cmbColumnAtribut;
        private System.Windows.Forms.Button btnKeysAdd;
        private System.Windows.Forms.Label lblKeysTabColumnName;
        private System.Windows.Forms.CheckBox chcboxKeysPrimary;
        private System.Windows.Forms.DataGridView dgvKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAtributName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAtributType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAtributPK;
        private System.Windows.Forms.Label lblKeyNameTable;
        private System.Windows.Forms.TextBox txtKeyNameTable;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.Button btnNewColumnRemove;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUnosStupca;
        private System.Windows.Forms.DataGridView dgvStupci;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnAutoInc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnNotNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnPrimaryKey;
        private System.Windows.Forms.CheckBox chcoxPrimaryKey;
        private System.Windows.Forms.CheckBox chcboxUnique;
        private System.Windows.Forms.CheckBox chcboxAutoInc;
        private System.Windows.Forms.CheckBox chcBoxNotNull;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TabControl tabControl;
    }
}

