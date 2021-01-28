namespace Shadowrun3
{
    partial class FormRangedWeapon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rwIdTB = new System.Windows.Forms.TextBox();
            this.damAmtNB = new System.Windows.Forms.NumericUpDown();
            this.damTypeCB = new System.Windows.Forms.ComboBox();
            this.modeOfFireCB = new System.Windows.Forms.ComboBox();
            this.ammoTypeTB = new System.Windows.Forms.TextBox();
            this.apNB = new System.Windows.Forms.NumericUpDown();
            this.rwSubmitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rwSkillCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rangedWeaponIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfDamageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeOfFireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammoTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangedWeaponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shadowrun3ContextDataSet = new Shadowrun3.Shadowrun3ContextDataSet();
            this.rangedWeaponsTableAdapter = new Shadowrun3.Shadowrun3ContextDataSetTableAdapters.RangedWeaponsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateRB = new System.Windows.Forms.RadioButton();
            this.newRB = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangedWeaponsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 55);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ranged Weapons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Damage Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Damage Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mode of Fire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ammo Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "AP";
            // 
            // rwIdTB
            // 
            this.rwIdTB.Location = new System.Drawing.Point(139, 113);
            this.rwIdTB.Name = "rwIdTB";
            this.rwIdTB.Size = new System.Drawing.Size(120, 20);
            this.rwIdTB.TabIndex = 31;
            this.rwIdTB.TextChanged += new System.EventHandler(this.rwIdTB_TextChanged);
            // 
            // damAmtNB
            // 
            this.damAmtNB.Location = new System.Drawing.Point(139, 146);
            this.damAmtNB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.damAmtNB.Name = "damAmtNB";
            this.damAmtNB.Size = new System.Drawing.Size(120, 20);
            this.damAmtNB.TabIndex = 32;
            this.damAmtNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.damAmtNB.ValueChanged += new System.EventHandler(this.damAmtNB_ValueChanged);
            // 
            // damTypeCB
            // 
            this.damTypeCB.FormattingEnabled = true;
            this.damTypeCB.Items.AddRange(new object[] {
            "P",
            "S",
            "S(e)"});
            this.damTypeCB.Location = new System.Drawing.Point(139, 181);
            this.damTypeCB.Name = "damTypeCB";
            this.damTypeCB.Size = new System.Drawing.Size(121, 21);
            this.damTypeCB.TabIndex = 33;
            this.damTypeCB.SelectedIndexChanged += new System.EventHandler(this.DamTypeCB_SelectedIndexChanged);
            // 
            // modeOfFireCB
            // 
            this.modeOfFireCB.FormattingEnabled = true;
            this.modeOfFireCB.Items.AddRange(new object[] {
            "SS",
            "SA",
            "BF",
            "FA",
            "SSBF",
            "SABF",
            "BFFA",
            "SSSA",
            "SAFA",
            "SABFFA"});
            this.modeOfFireCB.Location = new System.Drawing.Point(139, 212);
            this.modeOfFireCB.Name = "modeOfFireCB";
            this.modeOfFireCB.Size = new System.Drawing.Size(121, 21);
            this.modeOfFireCB.TabIndex = 34;
            this.modeOfFireCB.SelectedIndexChanged += new System.EventHandler(this.modeOfFireCB_SelectedIndexChanged);
            // 
            // ammoTypeTB
            // 
            this.ammoTypeTB.Location = new System.Drawing.Point(139, 241);
            this.ammoTypeTB.Name = "ammoTypeTB";
            this.ammoTypeTB.Size = new System.Drawing.Size(120, 20);
            this.ammoTypeTB.TabIndex = 35;
            this.ammoTypeTB.TextChanged += new System.EventHandler(this.ammoTypeTB_TextChanged);
            // 
            // apNB
            // 
            this.apNB.Location = new System.Drawing.Point(139, 270);
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
            this.apNB.TabIndex = 36;
            this.apNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apNB.ValueChanged += new System.EventHandler(this.apNB_ValueChanged);
            // 
            // rwSubmitButton
            // 
            this.rwSubmitButton.Enabled = false;
            this.rwSubmitButton.Location = new System.Drawing.Point(161, 352);
            this.rwSubmitButton.Name = "rwSubmitButton";
            this.rwSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.rwSubmitButton.TabIndex = 37;
            this.rwSubmitButton.Text = "Submit";
            this.rwSubmitButton.UseVisualStyleBackColor = true;
            this.rwSubmitButton.Click += new System.EventHandler(this.rwSubmitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Skill";
            // 
            // rwSkillCB
            // 
            this.rwSkillCB.FormattingEnabled = true;
            this.rwSkillCB.Items.AddRange(new object[] {
            "Automatics",
            "Exotic Ranged Weapons",
            "Heavy Weapons",
            "Longarms",
            "Pistols",
            "Thrown Weapons"});
            this.rwSkillCB.Location = new System.Drawing.Point(139, 304);
            this.rwSkillCB.Name = "rwSkillCB";
            this.rwSkillCB.Size = new System.Drawing.Size(121, 21);
            this.rwSkillCB.TabIndex = 39;
            this.rwSkillCB.SelectedIndexChanged += new System.EventHandler(this.rwSkillCB_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rangedWeaponIdDataGridViewTextBoxColumn,
            this.damageAmountDataGridViewTextBoxColumn,
            this.typeOfDamageDataGridViewTextBoxColumn,
            this.modeOfFireDataGridViewTextBoxColumn,
            this.ammoTypeDataGridViewTextBoxColumn,
            this.aPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rangedWeaponsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(312, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 321);
            this.dataGridView1.TabIndex = 40;
            // 
            // rangedWeaponIdDataGridViewTextBoxColumn
            // 
            this.rangedWeaponIdDataGridViewTextBoxColumn.DataPropertyName = "RangedWeaponId";
            this.rangedWeaponIdDataGridViewTextBoxColumn.HeaderText = "RangedWeaponId";
            this.rangedWeaponIdDataGridViewTextBoxColumn.Name = "rangedWeaponIdDataGridViewTextBoxColumn";
            // 
            // damageAmountDataGridViewTextBoxColumn
            // 
            this.damageAmountDataGridViewTextBoxColumn.DataPropertyName = "DamageAmount";
            this.damageAmountDataGridViewTextBoxColumn.HeaderText = "DamageAmount";
            this.damageAmountDataGridViewTextBoxColumn.Name = "damageAmountDataGridViewTextBoxColumn";
            // 
            // typeOfDamageDataGridViewTextBoxColumn
            // 
            this.typeOfDamageDataGridViewTextBoxColumn.DataPropertyName = "TypeOfDamage";
            this.typeOfDamageDataGridViewTextBoxColumn.HeaderText = "TypeOfDamage";
            this.typeOfDamageDataGridViewTextBoxColumn.Name = "typeOfDamageDataGridViewTextBoxColumn";
            // 
            // modeOfFireDataGridViewTextBoxColumn
            // 
            this.modeOfFireDataGridViewTextBoxColumn.DataPropertyName = "ModeOfFire";
            this.modeOfFireDataGridViewTextBoxColumn.HeaderText = "ModeOfFire";
            this.modeOfFireDataGridViewTextBoxColumn.Name = "modeOfFireDataGridViewTextBoxColumn";
            // 
            // ammoTypeDataGridViewTextBoxColumn
            // 
            this.ammoTypeDataGridViewTextBoxColumn.DataPropertyName = "AmmoType";
            this.ammoTypeDataGridViewTextBoxColumn.HeaderText = "AmmoType";
            this.ammoTypeDataGridViewTextBoxColumn.Name = "ammoTypeDataGridViewTextBoxColumn";
            // 
            // aPDataGridViewTextBoxColumn
            // 
            this.aPDataGridViewTextBoxColumn.DataPropertyName = "AP";
            this.aPDataGridViewTextBoxColumn.HeaderText = "AP";
            this.aPDataGridViewTextBoxColumn.Name = "aPDataGridViewTextBoxColumn";
            // 
            // rangedWeaponsBindingSource
            // 
            this.rangedWeaponsBindingSource.DataMember = "RangedWeapons";
            this.rangedWeaponsBindingSource.DataSource = this.shadowrun3ContextDataSet;
            // 
            // shadowrun3ContextDataSet
            // 
            this.shadowrun3ContextDataSet.DataSetName = "Shadowrun3ContextDataSet";
            this.shadowrun3ContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rangedWeaponsTableAdapter
            // 
            this.rangedWeaponsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateRB);
            this.panel1.Controls.Add(this.newRB);
            this.panel1.Location = new System.Drawing.Point(12, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 109);
            this.panel1.TabIndex = 41;
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
            this.deleteButton.Location = new System.Drawing.Point(161, 411);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 41;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(161, 381);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 40;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // FormRangedWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rwSkillCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rwSubmitButton);
            this.Controls.Add(this.apNB);
            this.Controls.Add(this.ammoTypeTB);
            this.Controls.Add(this.modeOfFireCB);
            this.Controls.Add(this.damTypeCB);
            this.Controls.Add(this.damAmtNB);
            this.Controls.Add(this.rwIdTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormRangedWeapon";
            this.Text = "FormRangedWeapon";
            this.Load += new System.EventHandler(this.FormRangedWeapon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangedWeaponsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rwIdTB;
        private System.Windows.Forms.NumericUpDown damAmtNB;
        private System.Windows.Forms.ComboBox damTypeCB;
        private System.Windows.Forms.ComboBox modeOfFireCB;
        private System.Windows.Forms.TextBox ammoTypeTB;
        private System.Windows.Forms.NumericUpDown apNB;
        private System.Windows.Forms.Button rwSubmitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rwSkillCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Shadowrun3ContextDataSet shadowrun3ContextDataSet;
        private System.Windows.Forms.BindingSource rangedWeaponsBindingSource;
        private Shadowrun3ContextDataSetTableAdapters.RangedWeaponsTableAdapter rangedWeaponsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangedWeaponIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfDamageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeOfFireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammoTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton updateRB;
        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}