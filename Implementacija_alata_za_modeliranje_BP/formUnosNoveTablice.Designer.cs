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
            this.btnUgasiFormu = new System.Windows.Forms.Button();
            this.lblImeForme = new System.Windows.Forms.Label();
            this.lblImeTablice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.txtType = new System.Windows.Forms.TextBox();
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.keysTab = new System.Windows.Forms.TabPage();
            this.btnKeysAdd = new System.Windows.Forms.Button();
            this.lblKeysTabColumnName = new System.Windows.Forms.Label();
            this.txtkeysColumn = new System.Windows.Forms.TextBox();
            this.chcboxKeysPrimary = new System.Windows.Forms.CheckBox();
            this.dgvKeys = new System.Windows.Forms.DataGridView();
            this.lblKeyName = new System.Windows.Forms.Label();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.indicesTab = new System.Windows.Forms.TabPage();
            this.btnIndiciesAdd = new System.Windows.Forms.Button();
            this.lblIndicieColumn = new System.Windows.Forms.Label();
            this.txtIndiciesColumn = new System.Windows.Forms.TextBox();
            this.chckBoxUnique = new System.Windows.Forms.CheckBox();
            this.dgvIndicies = new System.Windows.Forms.DataGridView();
            this.lblIndicesName = new System.Windows.Forms.Label();
            this.txtIndiciesName = new System.Windows.Forms.TextBox();
            this.foreignTab = new System.Windows.Forms.TabPage();
            this.cmbOnDelete = new System.Windows.Forms.ComboBox();
            this.cmbOnUpdate = new System.Windows.Forms.ComboBox();
            this.lblForeignDelete = new System.Windows.Forms.Label();
            this.lblForeignUpdate = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Button();
            this.dgvForeignKeys = new System.Windows.Forms.DataGridView();
            this.lblForeignTable = new System.Windows.Forms.Label();
            this.txtForeignTable = new System.Windows.Forms.TextBox();
            this.lblForeignName = new System.Windows.Forms.Label();
            this.txtForeignName = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStupci)).BeginInit();
            this.tabControl.SuspendLayout();
            this.keysTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeys)).BeginInit();
            this.indicesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicies)).BeginInit();
            this.foreignTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForeignKeys)).BeginInit();
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
            // btnUgasiFormu
            // 
            this.btnUgasiFormu.AutoEllipsis = true;
            this.btnUgasiFormu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUgasiFormu.BackColor = System.Drawing.Color.Gray;
            this.btnUgasiFormu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUgasiFormu.FlatAppearance.BorderSize = 0;
            this.btnUgasiFormu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUgasiFormu.Location = new System.Drawing.Point(1130, 20);
            this.btnUgasiFormu.Margin = new System.Windows.Forms.Padding(0);
            this.btnUgasiFormu.Name = "btnUgasiFormu";
            this.btnUgasiFormu.Size = new System.Drawing.Size(41, 39);
            this.btnUgasiFormu.TabIndex = 1;
            this.btnUgasiFormu.Text = "X";
            this.btnUgasiFormu.UseVisualStyleBackColor = false;
            this.btnUgasiFormu.Click += new System.EventHandler(this.btnUgasiFormu_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 31);
            this.textBox1.TabIndex = 6;
            // 
            // dataTab
            // 
            this.dataTab.BackColor = System.Drawing.Color.Gray;
            this.dataTab.Controls.Add(this.txtType);
            this.dataTab.Controls.Add(this.btnUnosStupca);
            this.dataTab.Controls.Add(this.dgvStupci);
            this.dataTab.Controls.Add(this.chcoxPrimaryKey);
            this.dataTab.Controls.Add(this.chcboxUnique);
            this.dataTab.Controls.Add(this.chcboxAutoInc);
            this.dataTab.Controls.Add(this.chcBoxNotNull);
            this.dataTab.Controls.Add(this.txtName);
            this.dataTab.Controls.Add(this.lblName);
            this.dataTab.Controls.Add(this.lblType);
            this.dataTab.Location = new System.Drawing.Point(4, 28);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(754, 433);
            this.dataTab.TabIndex = 1;
            this.dataTab.Text = "New column";
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
            // btnUnosStupca
            // 
            this.btnUnosStupca.AutoEllipsis = true;
            this.btnUnosStupca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUnosStupca.BackColor = System.Drawing.Color.Gray;
            this.btnUnosStupca.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnosStupca.FlatAppearance.BorderSize = 0;
            this.btnUnosStupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnosStupca.Location = new System.Drawing.Point(647, 113);
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
            this.dgvStupci.Size = new System.Drawing.Size(675, 204);
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(72, 52);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 23);
            this.txtName.TabIndex = 19;
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
            this.tabControl.Controls.Add(this.indicesTab);
            this.tabControl.Controls.Add(this.foreignTab);
            this.tabControl.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(305, 79);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(762, 465);
            this.tabControl.TabIndex = 17;
            // 
            // keysTab
            // 
            this.keysTab.BackColor = System.Drawing.Color.Gray;
            this.keysTab.Controls.Add(this.btnKeysAdd);
            this.keysTab.Controls.Add(this.lblKeysTabColumnName);
            this.keysTab.Controls.Add(this.txtkeysColumn);
            this.keysTab.Controls.Add(this.chcboxKeysPrimary);
            this.keysTab.Controls.Add(this.dgvKeys);
            this.keysTab.Controls.Add(this.lblKeyName);
            this.keysTab.Controls.Add(this.txtKeyName);
            this.keysTab.Location = new System.Drawing.Point(4, 28);
            this.keysTab.Name = "keysTab";
            this.keysTab.Padding = new System.Windows.Forms.Padding(3);
            this.keysTab.Size = new System.Drawing.Size(754, 433);
            this.keysTab.TabIndex = 2;
            this.keysTab.Text = "Keys";
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
            // txtkeysColumn
            // 
            this.txtkeysColumn.Location = new System.Drawing.Point(540, 56);
            this.txtkeysColumn.Name = "txtkeysColumn";
            this.txtkeysColumn.Size = new System.Drawing.Size(139, 23);
            this.txtkeysColumn.TabIndex = 11;
            // 
            // chcboxKeysPrimary
            // 
            this.chcboxKeysPrimary.AutoSize = true;
            this.chcboxKeysPrimary.Location = new System.Drawing.Point(104, 119);
            this.chcboxKeysPrimary.Name = "chcboxKeysPrimary";
            this.chcboxKeysPrimary.Size = new System.Drawing.Size(110, 20);
            this.chcboxKeysPrimary.TabIndex = 10;
            this.chcboxKeysPrimary.Text = "Primary key";
            this.chcboxKeysPrimary.UseVisualStyleBackColor = true;
            // 
            // dgvKeys
            // 
            this.dgvKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeys.Location = new System.Drawing.Point(41, 197);
            this.dgvKeys.Name = "dgvKeys";
            this.dgvKeys.RowHeadersWidth = 51;
            this.dgvKeys.RowTemplate.Height = 24;
            this.dgvKeys.Size = new System.Drawing.Size(679, 174);
            this.dgvKeys.TabIndex = 9;
            // 
            // lblKeyName
            // 
            this.lblKeyName.BackColor = System.Drawing.Color.Gray;
            this.lblKeyName.Enabled = false;
            this.lblKeyName.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKeyName.Location = new System.Drawing.Point(27, 56);
            this.lblKeyName.Name = "lblKeyName";
            this.lblKeyName.Size = new System.Drawing.Size(61, 26);
            this.lblKeyName.TabIndex = 8;
            this.lblKeyName.Text = "Name:";
            // 
            // txtKeyName
            // 
            this.txtKeyName.Location = new System.Drawing.Point(104, 53);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.Size = new System.Drawing.Size(139, 23);
            this.txtKeyName.TabIndex = 7;
            // 
            // indicesTab
            // 
            this.indicesTab.BackColor = System.Drawing.Color.Gray;
            this.indicesTab.Controls.Add(this.btnIndiciesAdd);
            this.indicesTab.Controls.Add(this.lblIndicieColumn);
            this.indicesTab.Controls.Add(this.txtIndiciesColumn);
            this.indicesTab.Controls.Add(this.chckBoxUnique);
            this.indicesTab.Controls.Add(this.dgvIndicies);
            this.indicesTab.Controls.Add(this.lblIndicesName);
            this.indicesTab.Controls.Add(this.txtIndiciesName);
            this.indicesTab.Location = new System.Drawing.Point(4, 28);
            this.indicesTab.Name = "indicesTab";
            this.indicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.indicesTab.Size = new System.Drawing.Size(754, 433);
            this.indicesTab.TabIndex = 3;
            this.indicesTab.Text = "Indices";
            // 
            // btnIndiciesAdd
            // 
            this.btnIndiciesAdd.AutoEllipsis = true;
            this.btnIndiciesAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIndiciesAdd.BackColor = System.Drawing.Color.Gray;
            this.btnIndiciesAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIndiciesAdd.FlatAppearance.BorderSize = 0;
            this.btnIndiciesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIndiciesAdd.Location = new System.Drawing.Point(636, 119);
            this.btnIndiciesAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnIndiciesAdd.Name = "btnIndiciesAdd";
            this.btnIndiciesAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIndiciesAdd.Size = new System.Drawing.Size(43, 43);
            this.btnIndiciesAdd.TabIndex = 42;
            this.btnIndiciesAdd.Text = "+";
            this.btnIndiciesAdd.UseVisualStyleBackColor = false;
            // 
            // lblIndicieColumn
            // 
            this.lblIndicieColumn.BackColor = System.Drawing.Color.Gray;
            this.lblIndicieColumn.Enabled = false;
            this.lblIndicieColumn.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIndicieColumn.Location = new System.Drawing.Point(443, 63);
            this.lblIndicieColumn.Name = "lblIndicieColumn";
            this.lblIndicieColumn.Size = new System.Drawing.Size(82, 29);
            this.lblIndicieColumn.TabIndex = 12;
            this.lblIndicieColumn.Text = "Column:";
            // 
            // txtIndiciesColumn
            // 
            this.txtIndiciesColumn.Location = new System.Drawing.Point(540, 56);
            this.txtIndiciesColumn.Name = "txtIndiciesColumn";
            this.txtIndiciesColumn.Size = new System.Drawing.Size(139, 23);
            this.txtIndiciesColumn.TabIndex = 40;
            // 
            // chckBoxUnique
            // 
            this.chckBoxUnique.AutoSize = true;
            this.chckBoxUnique.Location = new System.Drawing.Point(104, 119);
            this.chckBoxUnique.Name = "chckBoxUnique";
            this.chckBoxUnique.Size = new System.Drawing.Size(80, 20);
            this.chckBoxUnique.TabIndex = 39;
            this.chckBoxUnique.Text = "Unique";
            this.chckBoxUnique.UseVisualStyleBackColor = true;
            // 
            // dgvIndicies
            // 
            this.dgvIndicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicies.Location = new System.Drawing.Point(41, 197);
            this.dgvIndicies.Name = "dgvIndicies";
            this.dgvIndicies.RowHeadersWidth = 51;
            this.dgvIndicies.RowTemplate.Height = 24;
            this.dgvIndicies.Size = new System.Drawing.Size(679, 174);
            this.dgvIndicies.TabIndex = 38;
            // 
            // lblIndicesName
            // 
            this.lblIndicesName.BackColor = System.Drawing.Color.Gray;
            this.lblIndicesName.Enabled = false;
            this.lblIndicesName.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIndicesName.Location = new System.Drawing.Point(27, 56);
            this.lblIndicesName.Name = "lblIndicesName";
            this.lblIndicesName.Size = new System.Drawing.Size(61, 26);
            this.lblIndicesName.TabIndex = 37;
            this.lblIndicesName.Text = "Name:";
            // 
            // txtIndiciesName
            // 
            this.txtIndiciesName.Location = new System.Drawing.Point(104, 53);
            this.txtIndiciesName.Name = "txtIndiciesName";
            this.txtIndiciesName.Size = new System.Drawing.Size(139, 23);
            this.txtIndiciesName.TabIndex = 36;
            // 
            // foreignTab
            // 
            this.foreignTab.BackColor = System.Drawing.Color.Gray;
            this.foreignTab.Controls.Add(this.cmbOnDelete);
            this.foreignTab.Controls.Add(this.cmbOnUpdate);
            this.foreignTab.Controls.Add(this.lblForeignDelete);
            this.foreignTab.Controls.Add(this.lblForeignUpdate);
            this.foreignTab.Controls.Add(this.v);
            this.foreignTab.Controls.Add(this.dgvForeignKeys);
            this.foreignTab.Controls.Add(this.lblForeignTable);
            this.foreignTab.Controls.Add(this.txtForeignTable);
            this.foreignTab.Controls.Add(this.lblForeignName);
            this.foreignTab.Controls.Add(this.txtForeignName);
            this.foreignTab.Location = new System.Drawing.Point(4, 28);
            this.foreignTab.Name = "foreignTab";
            this.foreignTab.Padding = new System.Windows.Forms.Padding(3);
            this.foreignTab.Size = new System.Drawing.Size(754, 433);
            this.foreignTab.TabIndex = 4;
            this.foreignTab.Text = "Foreign Key";
            // 
            // cmbOnDelete
            // 
            this.cmbOnDelete.AutoCompleteCustomSource.AddRange(new string[] {
            "No action",
            "Restrict",
            "Set null",
            "Set default",
            "Cascade"});
            this.cmbOnDelete.FormattingEnabled = true;
            this.cmbOnDelete.Items.AddRange(new object[] {
            "No action",
            "Restrict",
            "Set null",
            "Set default",
            "Cascade"});
            this.cmbOnDelete.Location = new System.Drawing.Point(506, 73);
            this.cmbOnDelete.Name = "cmbOnDelete";
            this.cmbOnDelete.Size = new System.Drawing.Size(102, 24);
            this.cmbOnDelete.TabIndex = 47;
            // 
            // cmbOnUpdate
            // 
            this.cmbOnUpdate.AutoCompleteCustomSource.AddRange(new string[] {
            "No action",
            "Restrict",
            "Set null",
            "Set default",
            "Cascade"});
            this.cmbOnUpdate.FormattingEnabled = true;
            this.cmbOnUpdate.Items.AddRange(new object[] {
            "No action",
            "Restrict",
            "Set null",
            "Set default",
            "Cascade"});
            this.cmbOnUpdate.Location = new System.Drawing.Point(361, 73);
            this.cmbOnUpdate.Name = "cmbOnUpdate";
            this.cmbOnUpdate.Size = new System.Drawing.Size(102, 24);
            this.cmbOnUpdate.TabIndex = 46;
            // 
            // lblForeignDelete
            // 
            this.lblForeignDelete.BackColor = System.Drawing.Color.Gray;
            this.lblForeignDelete.Enabled = false;
            this.lblForeignDelete.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForeignDelete.Location = new System.Drawing.Point(502, 34);
            this.lblForeignDelete.Name = "lblForeignDelete";
            this.lblForeignDelete.Size = new System.Drawing.Size(113, 24);
            this.lblForeignDelete.TabIndex = 45;
            this.lblForeignDelete.Text = "On delete:";
            // 
            // lblForeignUpdate
            // 
            this.lblForeignUpdate.BackColor = System.Drawing.Color.Gray;
            this.lblForeignUpdate.Enabled = false;
            this.lblForeignUpdate.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForeignUpdate.Location = new System.Drawing.Point(366, 34);
            this.lblForeignUpdate.Name = "lblForeignUpdate";
            this.lblForeignUpdate.Size = new System.Drawing.Size(113, 24);
            this.lblForeignUpdate.TabIndex = 44;
            this.lblForeignUpdate.Text = "On update:";
            // 
            // v
            // 
            this.v.AutoEllipsis = true;
            this.v.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.v.BackColor = System.Drawing.Color.Gray;
            this.v.Cursor = System.Windows.Forms.Cursors.Default;
            this.v.FlatAppearance.BorderSize = 0;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v.Location = new System.Drawing.Point(671, 136);
            this.v.Margin = new System.Windows.Forms.Padding(0);
            this.v.Name = "v";
            this.v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.v.Size = new System.Drawing.Size(43, 43);
            this.v.TabIndex = 43;
            this.v.Text = "+";
            this.v.UseVisualStyleBackColor = false;
            // 
            // dgvForeignKeys
            // 
            this.dgvForeignKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForeignKeys.Location = new System.Drawing.Point(34, 205);
            this.dgvForeignKeys.Name = "dgvForeignKeys";
            this.dgvForeignKeys.RowHeadersWidth = 51;
            this.dgvForeignKeys.RowTemplate.Height = 24;
            this.dgvForeignKeys.Size = new System.Drawing.Size(680, 209);
            this.dgvForeignKeys.TabIndex = 11;
            // 
            // lblForeignTable
            // 
            this.lblForeignTable.BackColor = System.Drawing.Color.Gray;
            this.lblForeignTable.Enabled = false;
            this.lblForeignTable.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForeignTable.Location = new System.Drawing.Point(30, 101);
            this.lblForeignTable.Name = "lblForeignTable";
            this.lblForeignTable.Size = new System.Drawing.Size(113, 24);
            this.lblForeignTable.TabIndex = 10;
            this.lblForeignTable.Text = "Table name:";
            // 
            // txtForeignTable
            // 
            this.txtForeignTable.Location = new System.Drawing.Point(171, 101);
            this.txtForeignTable.Name = "txtForeignTable";
            this.txtForeignTable.Size = new System.Drawing.Size(112, 23);
            this.txtForeignTable.TabIndex = 9;
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
            this.txtForeignName.Location = new System.Drawing.Point(171, 35);
            this.txtForeignName.Name = "txtForeignName";
            this.txtForeignName.Size = new System.Drawing.Size(112, 23);
            this.txtForeignName.TabIndex = 7;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblImeTablice);
            this.Controls.Add(this.lblImeForme);
            this.Controls.Add(this.btnUgasiFormu);
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
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStupci)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.keysTab.ResumeLayout(false);
            this.keysTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeys)).EndInit();
            this.indicesTab.ResumeLayout(false);
            this.indicesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicies)).EndInit();
            this.foreignTab.ResumeLayout(false);
            this.foreignTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForeignKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formNovaTablicaPozadina;
        private System.Windows.Forms.Button btnUgasiFormu;
        private System.Windows.Forms.Label lblImeForme;
        private System.Windows.Forms.Label lblImeTablice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TabPage keysTab;
        private System.Windows.Forms.TabPage indicesTab;
        private System.Windows.Forms.TabPage foreignTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblKeyName;
        private System.Windows.Forms.TextBox txtKeyName;
        private System.Windows.Forms.CheckBox chcboxAutoInc;
        private System.Windows.Forms.CheckBox chcBoxNotNull;
        private System.Windows.Forms.CheckBox chcboxUnique;
        private System.Windows.Forms.Button btnUnosStupca;
        private System.Windows.Forms.DataGridView dgvStupci;
        private System.Windows.Forms.CheckBox chcoxPrimaryKey;
        private System.Windows.Forms.Button btnKeysAdd;
        private System.Windows.Forms.Label lblKeysTabColumnName;
        private System.Windows.Forms.TextBox txtkeysColumn;
        private System.Windows.Forms.CheckBox chcboxKeysPrimary;
        private System.Windows.Forms.DataGridView dgvKeys;
        private System.Windows.Forms.Button btnIndiciesAdd;
        private System.Windows.Forms.Label lblIndicieColumn;
        private System.Windows.Forms.TextBox txtIndiciesColumn;
        private System.Windows.Forms.CheckBox chckBoxUnique;
        private System.Windows.Forms.DataGridView dgvIndicies;
        private System.Windows.Forms.Label lblIndicesName;
        private System.Windows.Forms.TextBox txtIndiciesName;
        private System.Windows.Forms.DataGridView dgvForeignKeys;
        private System.Windows.Forms.Label lblForeignTable;
        private System.Windows.Forms.TextBox txtForeignTable;
        private System.Windows.Forms.Label lblForeignName;
        private System.Windows.Forms.TextBox txtForeignName;
        private System.Windows.Forms.ComboBox cmbOnDelete;
        private System.Windows.Forms.ComboBox cmbOnUpdate;
        private System.Windows.Forms.Label lblForeignDelete;
        private System.Windows.Forms.Label lblForeignUpdate;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnAutoInc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnNotNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnPrimaryKey;
    }
}

