namespace Shadowrun3
{
    partial class FormSpells
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
            this.spellName = new System.Windows.Forms.Label();
            this.spellNameTB = new System.Windows.Forms.TextBox();
            this.spellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shadowrun3ContextDataSet = new Shadowrun3.Shadowrun3ContextDataSet();
            this.spellType = new System.Windows.Forms.Label();
            this.spellRange = new System.Windows.Forms.Label();
            this.spellDamage = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.dvMod = new System.Windows.Forms.Label();
            this.submitSpell = new System.Windows.Forms.Button();
            this.spellCategory = new System.Windows.Forms.Label();
            this.spellTypeCB = new System.Windows.Forms.ComboBox();
            this.spellCategoryCB = new System.Windows.Forms.ComboBox();
            this.spellRangeCB = new System.Windows.Forms.ComboBox();
            this.spellDamageCB = new System.Windows.Forms.ComboBox();
            this.spellDurationCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvModNB = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateRB = new System.Windows.Forms.RadioButton();
            this.newRB = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spellIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofSpellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryOfSpellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeofSpellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageOfSpellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationOfSpellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVModDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellsTableAdapter = new Shadowrun3.Shadowrun3ContextDataSetTableAdapters.SpellsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvModNB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // spellName
            // 
            this.spellName.AutoSize = true;
            this.spellName.Location = new System.Drawing.Point(71, 98);
            this.spellName.Name = "spellName";
            this.spellName.Size = new System.Drawing.Size(35, 13);
            this.spellName.TabIndex = 0;
            this.spellName.Text = "Name";
            // 
            // spellNameTB
            // 
            this.spellNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "SpellId", true));
            this.spellNameTB.Location = new System.Drawing.Point(129, 95);
            this.spellNameTB.Name = "spellNameTB";
            this.spellNameTB.Size = new System.Drawing.Size(121, 20);
            this.spellNameTB.TabIndex = 1;
            this.spellNameTB.TextChanged += new System.EventHandler(this.spellNameTB_TextChanged);
            // 
            // spellsBindingSource
            // 
            this.spellsBindingSource.DataMember = "Spells";
            this.spellsBindingSource.DataSource = this.shadowrun3ContextDataSet;
            // 
            // shadowrun3ContextDataSet
            // 
            this.shadowrun3ContextDataSet.DataSetName = "Shadowrun3ContextDataSet";
            this.shadowrun3ContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spellType
            // 
            this.spellType.AutoSize = true;
            this.spellType.Location = new System.Drawing.Point(71, 129);
            this.spellType.Name = "spellType";
            this.spellType.Size = new System.Drawing.Size(31, 13);
            this.spellType.TabIndex = 2;
            this.spellType.Text = "Type";
            // 
            // spellRange
            // 
            this.spellRange.AutoSize = true;
            this.spellRange.Location = new System.Drawing.Point(71, 198);
            this.spellRange.Name = "spellRange";
            this.spellRange.Size = new System.Drawing.Size(39, 13);
            this.spellRange.TabIndex = 6;
            this.spellRange.Text = "Range";
            // 
            // spellDamage
            // 
            this.spellDamage.AutoSize = true;
            this.spellDamage.Location = new System.Drawing.Point(71, 236);
            this.spellDamage.Name = "spellDamage";
            this.spellDamage.Size = new System.Drawing.Size(47, 13);
            this.spellDamage.TabIndex = 8;
            this.spellDamage.Text = "Damage";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(71, 273);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(47, 13);
            this.duration.TabIndex = 10;
            this.duration.Text = "Duration";
            // 
            // dvMod
            // 
            this.dvMod.AutoSize = true;
            this.dvMod.Location = new System.Drawing.Point(71, 311);
            this.dvMod.Name = "dvMod";
            this.dvMod.Size = new System.Drawing.Size(49, 13);
            this.dvMod.TabIndex = 12;
            this.dvMod.Text = "D.V.Mod";
            // 
            // submitSpell
            // 
            this.submitSpell.Enabled = false;
            this.submitSpell.Location = new System.Drawing.Point(149, 349);
            this.submitSpell.Name = "submitSpell";
            this.submitSpell.Size = new System.Drawing.Size(75, 23);
            this.submitSpell.TabIndex = 14;
            this.submitSpell.Text = "Submit";
            this.submitSpell.UseVisualStyleBackColor = true;
            this.submitSpell.Click += new System.EventHandler(this.submitSpell_Click);
            // 
            // spellCategory
            // 
            this.spellCategory.AutoSize = true;
            this.spellCategory.Location = new System.Drawing.Point(71, 162);
            this.spellCategory.Name = "spellCategory";
            this.spellCategory.Size = new System.Drawing.Size(49, 13);
            this.spellCategory.TabIndex = 15;
            this.spellCategory.Text = "Category";
            // 
            // spellTypeCB
            // 
            this.spellTypeCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "TypeofSpell", true));
            this.spellTypeCB.FormattingEnabled = true;
            this.spellTypeCB.Items.AddRange(new object[] {
            "P",
            "M"});
            this.spellTypeCB.Location = new System.Drawing.Point(129, 126);
            this.spellTypeCB.Name = "spellTypeCB";
            this.spellTypeCB.Size = new System.Drawing.Size(121, 21);
            this.spellTypeCB.TabIndex = 17;
            this.spellTypeCB.SelectedIndexChanged += new System.EventHandler(this.spellTypeCB_SelectedIndexChanged);
            // 
            // spellCategoryCB
            // 
            this.spellCategoryCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "CategoryOfSpell", true));
            this.spellCategoryCB.FormattingEnabled = true;
            this.spellCategoryCB.Items.AddRange(new object[] {
            "Combat",
            "Detection",
            "Health",
            "Illusion",
            "Manipulation"});
            this.spellCategoryCB.Location = new System.Drawing.Point(129, 159);
            this.spellCategoryCB.Name = "spellCategoryCB";
            this.spellCategoryCB.Size = new System.Drawing.Size(121, 21);
            this.spellCategoryCB.TabIndex = 18;
            this.spellCategoryCB.SelectedIndexChanged += new System.EventHandler(this.spellCategoryCB_SelectedIndexChanged);
            // 
            // spellRangeCB
            // 
            this.spellRangeCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "RangeofSpell", true));
            this.spellRangeCB.FormattingEnabled = true;
            this.spellRangeCB.Items.AddRange(new object[] {
            "LOS",
            "LOS(A)",
            "Touch"});
            this.spellRangeCB.Location = new System.Drawing.Point(129, 195);
            this.spellRangeCB.Name = "spellRangeCB";
            this.spellRangeCB.Size = new System.Drawing.Size(121, 21);
            this.spellRangeCB.TabIndex = 19;
            this.spellRangeCB.SelectedIndexChanged += new System.EventHandler(this.spellRangeCB_SelectedIndexChanged);
            // 
            // spellDamageCB
            // 
            this.spellDamageCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "DamageOfSpell", true));
            this.spellDamageCB.FormattingEnabled = true;
            this.spellDamageCB.Items.AddRange(new object[] {
            "P",
            "S",
            "N/A"});
            this.spellDamageCB.Location = new System.Drawing.Point(129, 233);
            this.spellDamageCB.Name = "spellDamageCB";
            this.spellDamageCB.Size = new System.Drawing.Size(121, 21);
            this.spellDamageCB.TabIndex = 20;
            this.spellDamageCB.SelectedIndexChanged += new System.EventHandler(this.spellDamageCB_SelectedIndexChanged);
            // 
            // spellDurationCB
            // 
            this.spellDurationCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "DurationOfSpell", true));
            this.spellDurationCB.FormattingEnabled = true;
            this.spellDurationCB.Items.AddRange(new object[] {
            "Instant",
            "Sustained",
            "Permanent"});
            this.spellDurationCB.Location = new System.Drawing.Point(129, 270);
            this.spellDurationCB.Name = "spellDurationCB";
            this.spellDurationCB.Size = new System.Drawing.Size(121, 21);
            this.spellDurationCB.TabIndex = 21;
            this.spellDurationCB.SelectedIndexChanged += new System.EventHandler(this.spellDurationCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 22;
            this.label1.Text = "Spells";
            // 
            // dvModNB
            // 
            this.dvModNB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spellsBindingSource, "DVMod", true));
            this.dvModNB.Location = new System.Drawing.Point(129, 311);
            this.dvModNB.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dvModNB.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.dvModNB.Name = "dvModNB";
            this.dvModNB.Size = new System.Drawing.Size(120, 20);
            this.dvModNB.TabIndex = 23;
            this.dvModNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dvModNB.ValueChanged += new System.EventHandler(this.dvModNB_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateRB);
            this.panel1.Controls.Add(this.newRB);
            this.panel1.Location = new System.Drawing.Point(12, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 109);
            this.panel1.TabIndex = 32;
            // 
            // updateRB
            // 
            this.updateRB.AutoSize = true;
            this.updateRB.Location = new System.Drawing.Point(7, 64);
            this.updateRB.Name = "updateRB";
            this.updateRB.Size = new System.Drawing.Size(104, 17);
            this.updateRB.TabIndex = 1;
            this.updateRB.Text = "Update or delete";
            this.updateRB.UseVisualStyleBackColor = true;
            this.updateRB.CheckedChanged += new System.EventHandler(this.updateRB_CheckedChanged);
            // 
            // newRB
            // 
            this.newRB.AutoSize = true;
            this.newRB.Location = new System.Drawing.Point(7, 24);
            this.newRB.Name = "newRB";
            this.newRB.Size = new System.Drawing.Size(97, 17);
            this.newRB.TabIndex = 0;
            this.newRB.Text = "Enter new spell";
            this.newRB.UseVisualStyleBackColor = true;
            this.newRB.CheckedChanged += new System.EventHandler(this.newRB_CheckedChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(149, 410);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(149, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spellIdDataGridViewTextBoxColumn,
            this.typeofSpellDataGridViewTextBoxColumn,
            this.categoryOfSpellDataGridViewTextBoxColumn,
            this.rangeofSpellDataGridViewTextBoxColumn,
            this.damageOfSpellDataGridViewTextBoxColumn,
            this.durationOfSpellDataGridViewTextBoxColumn,
            this.dVModDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spellsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(274, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 338);
            this.dataGridView1.TabIndex = 35;
            // 
            // spellIdDataGridViewTextBoxColumn
            // 
            this.spellIdDataGridViewTextBoxColumn.DataPropertyName = "SpellId";
            this.spellIdDataGridViewTextBoxColumn.HeaderText = "SpellId";
            this.spellIdDataGridViewTextBoxColumn.Name = "spellIdDataGridViewTextBoxColumn";
            // 
            // typeofSpellDataGridViewTextBoxColumn
            // 
            this.typeofSpellDataGridViewTextBoxColumn.DataPropertyName = "TypeofSpell";
            this.typeofSpellDataGridViewTextBoxColumn.HeaderText = "TypeofSpell";
            this.typeofSpellDataGridViewTextBoxColumn.Name = "typeofSpellDataGridViewTextBoxColumn";
            // 
            // categoryOfSpellDataGridViewTextBoxColumn
            // 
            this.categoryOfSpellDataGridViewTextBoxColumn.DataPropertyName = "CategoryOfSpell";
            this.categoryOfSpellDataGridViewTextBoxColumn.HeaderText = "CategoryOfSpell";
            this.categoryOfSpellDataGridViewTextBoxColumn.Name = "categoryOfSpellDataGridViewTextBoxColumn";
            // 
            // rangeofSpellDataGridViewTextBoxColumn
            // 
            this.rangeofSpellDataGridViewTextBoxColumn.DataPropertyName = "RangeofSpell";
            this.rangeofSpellDataGridViewTextBoxColumn.HeaderText = "RangeofSpell";
            this.rangeofSpellDataGridViewTextBoxColumn.Name = "rangeofSpellDataGridViewTextBoxColumn";
            // 
            // damageOfSpellDataGridViewTextBoxColumn
            // 
            this.damageOfSpellDataGridViewTextBoxColumn.DataPropertyName = "DamageOfSpell";
            this.damageOfSpellDataGridViewTextBoxColumn.HeaderText = "DamageOfSpell";
            this.damageOfSpellDataGridViewTextBoxColumn.Name = "damageOfSpellDataGridViewTextBoxColumn";
            // 
            // durationOfSpellDataGridViewTextBoxColumn
            // 
            this.durationOfSpellDataGridViewTextBoxColumn.DataPropertyName = "DurationOfSpell";
            this.durationOfSpellDataGridViewTextBoxColumn.HeaderText = "DurationOfSpell";
            this.durationOfSpellDataGridViewTextBoxColumn.Name = "durationOfSpellDataGridViewTextBoxColumn";
            // 
            // dVModDataGridViewTextBoxColumn
            // 
            this.dVModDataGridViewTextBoxColumn.DataPropertyName = "DVMod";
            this.dVModDataGridViewTextBoxColumn.HeaderText = "DVMod";
            this.dVModDataGridViewTextBoxColumn.Name = "dVModDataGridViewTextBoxColumn";
            // 
            // spellsTableAdapter
            // 
            this.spellsTableAdapter.ClearBeforeFill = true;
            // 
            // FormSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvModNB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spellDurationCB);
            this.Controls.Add(this.spellDamageCB);
            this.Controls.Add(this.spellRangeCB);
            this.Controls.Add(this.spellCategoryCB);
            this.Controls.Add(this.spellTypeCB);
            this.Controls.Add(this.spellCategory);
            this.Controls.Add(this.submitSpell);
            this.Controls.Add(this.dvMod);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.spellDamage);
            this.Controls.Add(this.spellRange);
            this.Controls.Add(this.spellType);
            this.Controls.Add(this.spellNameTB);
            this.Controls.Add(this.spellName);
            this.Name = "FormSpells";
            this.Text = "FormSpells";
            this.Load += new System.EventHandler(this.FormSpells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvModNB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spellName;
        private System.Windows.Forms.TextBox spellNameTB;
        private System.Windows.Forms.Label spellType;
        private System.Windows.Forms.Label spellRange;
        private System.Windows.Forms.Label spellDamage;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label dvMod;
        private System.Windows.Forms.Button submitSpell;
        private System.Windows.Forms.Label spellCategory;
        private System.Windows.Forms.ComboBox spellTypeCB;
        private System.Windows.Forms.ComboBox spellCategoryCB;
        private System.Windows.Forms.ComboBox spellRangeCB;
        private System.Windows.Forms.ComboBox spellDamageCB;
        private System.Windows.Forms.ComboBox spellDurationCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dvModNB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton updateRB;
        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Shadowrun3ContextDataSet shadowrun3ContextDataSet;
        private System.Windows.Forms.BindingSource spellsBindingSource;
        private Shadowrun3ContextDataSetTableAdapters.SpellsTableAdapter spellsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofSpellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryOfSpellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeofSpellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageOfSpellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationOfSpellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVModDataGridViewTextBoxColumn;
    }
}