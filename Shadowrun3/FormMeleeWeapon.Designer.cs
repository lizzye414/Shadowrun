namespace Shadowrun3
{
    partial class FormMeleeWeapon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mwIdTB = new System.Windows.Forms.TextBox();
            this.meleeWeaponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shadowrun3ContextDataSet = new Shadowrun3.Shadowrun3ContextDataSet();
            this.damAmtNB = new System.Windows.Forms.NumericUpDown();
            this.damTypeCB = new System.Windows.Forms.ComboBox();
            this.reachNB = new System.Windows.Forms.NumericUpDown();
            this.apNB = new System.Windows.Forms.NumericUpDown();
            this.mwSubmitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mwSkillCB = new System.Windows.Forms.ComboBox();
            this.meleeWeaponsTableAdapter = new Shadowrun3.Shadowrun3ContextDataSetTableAdapters.MeleeWeaponsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateRB = new System.Windows.Forms.RadioButton();
            this.newRB = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.meleeWeaponIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfDamageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.meleeWeaponsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reachNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 55);
            this.label2.TabIndex = 23;
            this.label2.Text = "Melee Weapons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Damage Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Damage Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Reach";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "AP";
            // 
            // mwIdTB
            // 
            this.mwIdTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meleeWeaponsBindingSource, "MeleeWeaponId", true));
            this.mwIdTB.Location = new System.Drawing.Point(165, 129);
            this.mwIdTB.Name = "mwIdTB";
            this.mwIdTB.Size = new System.Drawing.Size(120, 20);
            this.mwIdTB.TabIndex = 28;
            this.mwIdTB.TextChanged += new System.EventHandler(this.mwIdTB_TextChanged);
            // 
            // meleeWeaponsBindingSource
            // 
            this.meleeWeaponsBindingSource.DataMember = "MeleeWeapons";
            this.meleeWeaponsBindingSource.DataSource = this.shadowrun3ContextDataSet;
            // 
            // shadowrun3ContextDataSet
            // 
            this.shadowrun3ContextDataSet.DataSetName = "Shadowrun3ContextDataSet";
            this.shadowrun3ContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // damAmtNB
            // 
            this.damAmtNB.AllowDrop = true;
            this.damAmtNB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.meleeWeaponsBindingSource, "DamageAmount", true));
            this.damAmtNB.Location = new System.Drawing.Point(165, 159);
            this.damAmtNB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.damAmtNB.Name = "damAmtNB";
            this.damAmtNB.Size = new System.Drawing.Size(120, 20);
            this.damAmtNB.TabIndex = 29;
            this.damAmtNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.damAmtNB.ValueChanged += new System.EventHandler(this.damAmtNB_ValueChanged);
            // 
            // damTypeCB
            // 
            this.damTypeCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meleeWeaponsBindingSource, "TypeOfDamage", true));
            this.damTypeCB.FormattingEnabled = true;
            this.damTypeCB.Items.AddRange(new object[] {
            "P",
            "S",
            "S(e)"});
            this.damTypeCB.Location = new System.Drawing.Point(165, 189);
            this.damTypeCB.Name = "damTypeCB";
            this.damTypeCB.Size = new System.Drawing.Size(121, 21);
            this.damTypeCB.TabIndex = 30;
            this.damTypeCB.SelectedIndexChanged += new System.EventHandler(this.damTypeCB_SelectedIndexChanged);
            // 
            // reachNB
            // 
            this.reachNB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.meleeWeaponsBindingSource, "Reach", true));
            this.reachNB.Location = new System.Drawing.Point(165, 220);
            this.reachNB.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.reachNB.Name = "reachNB";
            this.reachNB.Size = new System.Drawing.Size(120, 20);
            this.reachNB.TabIndex = 31;
            this.reachNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reachNB.ValueChanged += new System.EventHandler(this.reachNB_ValueChanged);
            // 
            // apNB
            // 
            this.apNB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.meleeWeaponsBindingSource, "AP", true));
            this.apNB.Location = new System.Drawing.Point(165, 253);
            this.apNB.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.apNB.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.apNB.Name = "apNB";
            this.apNB.Size = new System.Drawing.Size(120, 20);
            this.apNB.TabIndex = 32;
            this.apNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apNB.ValueChanged += new System.EventHandler(this.apNB_ValueChanged);
            // 
            // mwSubmitButton
            // 
            this.mwSubmitButton.Enabled = false;
            this.mwSubmitButton.Location = new System.Drawing.Point(188, 335);
            this.mwSubmitButton.Name = "mwSubmitButton";
            this.mwSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.mwSubmitButton.TabIndex = 33;
            this.mwSubmitButton.Text = "Submit";
            this.mwSubmitButton.UseVisualStyleBackColor = true;
            this.mwSubmitButton.Click += new System.EventHandler(this.mwSubmitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Skill";
            // 
            // mwSkillCB
            // 
            this.mwSkillCB.FormattingEnabled = true;
            this.mwSkillCB.Items.AddRange(new object[] {
            "Blades",
            "Clubs",
            "Exotic Melee Weapon",
            "Unarmed Combat"});
            this.mwSkillCB.Location = new System.Drawing.Point(165, 288);
            this.mwSkillCB.Name = "mwSkillCB";
            this.mwSkillCB.Size = new System.Drawing.Size(121, 21);
            this.mwSkillCB.TabIndex = 35;
            this.mwSkillCB.SelectedIndexChanged += new System.EventHandler(this.mwSkillCB_SelectedIndexChanged);
            // 
            // meleeWeaponsTableAdapter
            // 
            this.meleeWeaponsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateRB);
            this.panel1.Controls.Add(this.newRB);
            this.panel1.Location = new System.Drawing.Point(30, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 109);
            this.panel1.TabIndex = 37;
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
            this.newRB.Size = new System.Drawing.Size(114, 17);
            this.newRB.TabIndex = 0;
            this.newRB.Text = "Enter new weapon";
            this.newRB.UseVisualStyleBackColor = true;
            this.newRB.CheckedChanged += new System.EventHandler(this.newRB_CheckedChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(188, 394);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(188, 364);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meleeWeaponIdDataGridViewTextBoxColumn,
            this.damageAmountDataGridViewTextBoxColumn,
            this.reachDataGridViewTextBoxColumn,
            this.typeOfDamageDataGridViewTextBoxColumn,
            this.aPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meleeWeaponsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(341, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 288);
            this.dataGridView1.TabIndex = 40;
            // 
            // meleeWeaponIdDataGridViewTextBoxColumn
            // 
            this.meleeWeaponIdDataGridViewTextBoxColumn.DataPropertyName = "MeleeWeaponId";
            this.meleeWeaponIdDataGridViewTextBoxColumn.HeaderText = "MeleeWeaponId";
            this.meleeWeaponIdDataGridViewTextBoxColumn.Name = "meleeWeaponIdDataGridViewTextBoxColumn";
            // 
            // damageAmountDataGridViewTextBoxColumn
            // 
            this.damageAmountDataGridViewTextBoxColumn.DataPropertyName = "DamageAmount";
            this.damageAmountDataGridViewTextBoxColumn.HeaderText = "DamageAmount";
            this.damageAmountDataGridViewTextBoxColumn.Name = "damageAmountDataGridViewTextBoxColumn";
            // 
            // reachDataGridViewTextBoxColumn
            // 
            this.reachDataGridViewTextBoxColumn.DataPropertyName = "Reach";
            this.reachDataGridViewTextBoxColumn.HeaderText = "Reach";
            this.reachDataGridViewTextBoxColumn.Name = "reachDataGridViewTextBoxColumn";
            // 
            // typeOfDamageDataGridViewTextBoxColumn
            // 
            this.typeOfDamageDataGridViewTextBoxColumn.DataPropertyName = "TypeOfDamage";
            this.typeOfDamageDataGridViewTextBoxColumn.HeaderText = "TypeOfDamage";
            this.typeOfDamageDataGridViewTextBoxColumn.Name = "typeOfDamageDataGridViewTextBoxColumn";
            // 
            // aPDataGridViewTextBoxColumn
            // 
            this.aPDataGridViewTextBoxColumn.DataPropertyName = "AP";
            this.aPDataGridViewTextBoxColumn.HeaderText = "AP";
            this.aPDataGridViewTextBoxColumn.Name = "aPDataGridViewTextBoxColumn";
            // 
            // FormMeleeWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mwSkillCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mwSubmitButton);
            this.Controls.Add(this.apNB);
            this.Controls.Add(this.reachNB);
            this.Controls.Add(this.damTypeCB);
            this.Controls.Add(this.damAmtNB);
            this.Controls.Add(this.mwIdTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMeleeWeapon";
            this.Text = "FormMeleeWeapon";
            this.Load += new System.EventHandler(this.FormMeleeWeapon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meleeWeaponsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reachNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mwIdTB;
        private System.Windows.Forms.NumericUpDown damAmtNB;
        private System.Windows.Forms.ComboBox damTypeCB;
        private System.Windows.Forms.NumericUpDown reachNB;
        private System.Windows.Forms.NumericUpDown apNB;
        private System.Windows.Forms.Button mwSubmitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox mwSkillCB;
        private Shadowrun3ContextDataSet shadowrun3ContextDataSet;
        private System.Windows.Forms.BindingSource meleeWeaponsBindingSource;
        private Shadowrun3ContextDataSetTableAdapters.MeleeWeaponsTableAdapter meleeWeaponsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton updateRB;
        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn meleeWeaponIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfDamageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPDataGridViewTextBoxColumn;
    }
}