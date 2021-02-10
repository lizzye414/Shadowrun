namespace Shadowrun3
{
    partial class FormEncounter
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateRB = new System.Windows.Forms.RadioButton();
            this.newRB = new System.Windows.Forms.RadioButton();
            this.updateButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.shadowrun3ContextDataSet1 = new Shadowrun3.Shadowrun3ContextDataSet1();
            this.encountersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encountersTableAdapter = new Shadowrun3.Shadowrun3ContextDataSet1TableAdapters.EncountersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.neCB = new System.Windows.Forms.ComboBox();
            this.neLB = new System.Windows.Forms.ListBox();
            this.namedEnemiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namedEnemiesTableAdapter = new Shadowrun3.Shadowrun3ContextDataSet1TableAdapters.NamedEnemiesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.encounterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namedEnemiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 55);
            this.label2.TabIndex = 48;
            this.label2.Text = "Encounters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Enabled = false;
            this.nameTB.Location = new System.Drawing.Point(60, 97);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(185, 20);
            this.nameTB.TabIndex = 50;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(460, 124);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 23);
            this.deleteButton.TabIndex = 53;
            this.deleteButton.Text = "Delete Enemy";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateRB);
            this.panel1.Controls.Add(this.newRB);
            this.panel1.Location = new System.Drawing.Point(79, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 109);
            this.panel1.TabIndex = 54;
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
            this.updateRB.CheckedChanged += new System.EventHandler(this.updateRB_CheckedChanged_1);
            // 
            // newRB
            // 
            this.newRB.AutoSize = true;
            this.newRB.Location = new System.Drawing.Point(7, 24);
            this.newRB.Name = "newRB";
            this.newRB.Size = new System.Drawing.Size(124, 17);
            this.newRB.TabIndex = 0;
            this.newRB.Text = "Enter new encounter";
            this.newRB.UseVisualStyleBackColor = true;
            this.newRB.CheckedChanged += new System.EventHandler(this.newRB_CheckedChanged_1);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(373, 124);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 23);
            this.updateButton.TabIndex = 52;
            this.updateButton.Text = "Add Enemy";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(101, 123);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 23);
            this.submitButton.TabIndex = 51;
            this.submitButton.Text = "Create encounter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // shadowrun3ContextDataSet1
            // 
            this.shadowrun3ContextDataSet1.DataSetName = "Shadowrun3ContextDataSet1";
            this.shadowrun3ContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encountersBindingSource
            // 
            this.encountersBindingSource.DataMember = "Encounters";
            this.encountersBindingSource.DataSource = this.shadowrun3ContextDataSet1;
            // 
            // encountersTableAdapter
            // 
            this.encountersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Named Enemy";
            // 
            // neCB
            // 
            this.neCB.DataSource = this.namedEnemiesBindingSource;
            this.neCB.DisplayMember = "NamedEnemyId";
            this.neCB.FormattingEnabled = true;
            this.neCB.Location = new System.Drawing.Point(373, 97);
            this.neCB.Name = "neCB";
            this.neCB.Size = new System.Drawing.Size(171, 21);
            this.neCB.TabIndex = 57;
            this.neCB.ValueMember = "NamedEnemyId";
            // 
            // neLB
            // 
            this.neLB.FormattingEnabled = true;
            this.neLB.Location = new System.Drawing.Point(293, 161);
            this.neLB.Name = "neLB";
            this.neLB.Size = new System.Drawing.Size(251, 251);
            this.neLB.TabIndex = 58;
            // 
            // namedEnemiesBindingSource
            // 
            this.namedEnemiesBindingSource.DataMember = "NamedEnemies";
            this.namedEnemiesBindingSource.DataSource = this.shadowrun3ContextDataSet1;
            // 
            // namedEnemiesTableAdapter
            // 
            this.namedEnemiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.encounterIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.encountersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 150);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // encounterIdDataGridViewTextBoxColumn
            // 
            this.encounterIdDataGridViewTextBoxColumn.DataPropertyName = "EncounterId";
            this.encounterIdDataGridViewTextBoxColumn.HeaderText = "Encounters";
            this.encounterIdDataGridViewTextBoxColumn.Name = "encounterIdDataGridViewTextBoxColumn";
            // 
            // FormEncounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.neLB);
            this.Controls.Add(this.neCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormEncounter";
            this.Text = "FormEncounter";
            this.Load += new System.EventHandler(this.FormEncounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namedEnemiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton updateRB;
        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button submitButton;
        private Shadowrun3ContextDataSet1 shadowrun3ContextDataSet1;
        private System.Windows.Forms.BindingSource encountersBindingSource;
        private Shadowrun3ContextDataSet1TableAdapters.EncountersTableAdapter encountersTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox neCB;
        private System.Windows.Forms.ListBox neLB;
        private System.Windows.Forms.BindingSource namedEnemiesBindingSource;
        private Shadowrun3ContextDataSet1TableAdapters.NamedEnemiesTableAdapter namedEnemiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn encounterIdDataGridViewTextBoxColumn;
    }
}