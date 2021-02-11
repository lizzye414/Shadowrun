namespace Shadowrun3
{
    partial class FormMatrixPrograms
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
            this.programName = new System.Windows.Forms.Label();
            this.programNameTB = new System.Windows.Forms.TextBox();
            this.matrixProgramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shadowrun3ContextDataSet1 = new Shadowrun3.Shadowrun3ContextDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.skillCB = new System.Windows.Forms.ComboBox();
            this.programSubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateRB = new System.Windows.Forms.RadioButton();
            this.newRB = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matrixProgramIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillSkillIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrixProgramsTableAdapter = new Shadowrun3.Shadowrun3ContextDataSet1TableAdapters.MatrixProgramsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.matrixProgramsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Location = new System.Drawing.Point(76, 119);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(35, 13);
            this.programName.TabIndex = 0;
            this.programName.Text = "Name";
            // 
            // programNameTB
            // 
            this.programNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrixProgramsBindingSource, "MatrixProgramId", true));
            this.programNameTB.Location = new System.Drawing.Point(117, 116);
            this.programNameTB.Name = "programNameTB";
            this.programNameTB.Size = new System.Drawing.Size(162, 20);
            this.programNameTB.TabIndex = 1;
            this.programNameTB.TextChanged += new System.EventHandler(this.programNameTB_TextChanged);
            // 
            // matrixProgramsBindingSource
            // 
            this.matrixProgramsBindingSource.DataMember = "MatrixPrograms";
            this.matrixProgramsBindingSource.DataSource = this.shadowrun3ContextDataSet1;
            // 
            // shadowrun3ContextDataSet1
            // 
            this.shadowrun3ContextDataSet1.DataSetName = "Shadowrun3ContextDataSet1";
            this.shadowrun3ContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Associated Skill";
            // 
            // skillCB
            // 
            this.skillCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrixProgramsBindingSource, "skill_SkillId", true));
            this.skillCB.FormattingEnabled = true;
            this.skillCB.Location = new System.Drawing.Point(117, 182);
            this.skillCB.Name = "skillCB";
            this.skillCB.Size = new System.Drawing.Size(162, 21);
            this.skillCB.TabIndex = 3;
            this.skillCB.SelectedIndexChanged += new System.EventHandler(this.skillCB_SelectedIndexChanged);
            // 
            // programSubmitButton
            // 
            this.programSubmitButton.Enabled = false;
            this.programSubmitButton.Location = new System.Drawing.Point(204, 251);
            this.programSubmitButton.Name = "programSubmitButton";
            this.programSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.programSubmitButton.TabIndex = 4;
            this.programSubmitButton.Text = "Submit";
            this.programSubmitButton.UseVisualStyleBackColor = true;
            this.programSubmitButton.Click += new System.EventHandler(this.programSubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 55);
            this.label2.TabIndex = 25;
            this.label2.Text = "Matrix Programs";
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(204, 295);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(204, 341);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateRB);
            this.panel1.Controls.Add(this.newRB);
            this.panel1.Location = new System.Drawing.Point(46, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 109);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.newRB.Location = new System.Drawing.Point(7, 18);
            this.newRB.Name = "newRB";
            this.newRB.Size = new System.Drawing.Size(114, 17);
            this.newRB.TabIndex = 0;
            this.newRB.Text = "Enter new program";
            this.newRB.UseVisualStyleBackColor = true;
            this.newRB.CheckedChanged += new System.EventHandler(this.newRB_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrixProgramIdDataGridViewTextBoxColumn,
            this.skillSkillIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matrixProgramsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(345, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 248);
            this.dataGridView1.TabIndex = 32;
            // 
            // matrixProgramIdDataGridViewTextBoxColumn
            // 
            this.matrixProgramIdDataGridViewTextBoxColumn.DataPropertyName = "MatrixProgramId";
            this.matrixProgramIdDataGridViewTextBoxColumn.HeaderText = "Matrix Program";
            this.matrixProgramIdDataGridViewTextBoxColumn.Name = "matrixProgramIdDataGridViewTextBoxColumn";
            // 
            // skillSkillIdDataGridViewTextBoxColumn
            // 
            this.skillSkillIdDataGridViewTextBoxColumn.DataPropertyName = "skill_SkillId";
            this.skillSkillIdDataGridViewTextBoxColumn.HeaderText = "Skill";
            this.skillSkillIdDataGridViewTextBoxColumn.Name = "skillSkillIdDataGridViewTextBoxColumn";
            // 
            // matrixProgramsTableAdapter
            // 
            this.matrixProgramsTableAdapter.ClearBeforeFill = true;
            // 
            // FormMatrixPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programSubmitButton);
            this.Controls.Add(this.skillCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programNameTB);
            this.Controls.Add(this.programName);
            this.Name = "FormMatrixPrograms";
            this.Text = "FormMatrixPrograms";
            this.Load += new System.EventHandler(this.FormMatrixPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrixProgramsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.TextBox programNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button programSubmitButton;
        public System.Windows.Forms.ComboBox skillCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton updateRB;
        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Shadowrun3ContextDataSet1 shadowrun3ContextDataSet1;
        private System.Windows.Forms.BindingSource matrixProgramsBindingSource;
        private Shadowrun3ContextDataSet1TableAdapters.MatrixProgramsTableAdapter matrixProgramsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrixProgramIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillSkillIdDataGridViewTextBoxColumn;
    }
}