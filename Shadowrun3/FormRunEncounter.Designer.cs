namespace Shadowrun3
{
    partial class FormRunEncounter
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
            this.encounterCB = new System.Windows.Forms.ComboBox();
            this.encountersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shadowrun3ContextDataSet1 = new Shadowrun3.Shadowrun3ContextDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.enemyDGV = new System.Windows.Forms.DataGridView();
            this.seeEnemyButton = new System.Windows.Forms.Button();
            this.encountersTableAdapter = new Shadowrun3.Shadowrun3ContextDataSet1TableAdapters.EncountersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 55);
            this.label2.TabIndex = 48;
            this.label2.Text = "Run Encounter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Encounter";
            // 
            // encounterCB
            // 
            this.encounterCB.DataSource = this.encountersBindingSource;
            this.encounterCB.DisplayMember = "EncounterId";
            this.encounterCB.FormattingEnabled = true;
            this.encounterCB.Location = new System.Drawing.Point(110, 109);
            this.encounterCB.Name = "encounterCB";
            this.encounterCB.Size = new System.Drawing.Size(180, 21);
            this.encounterCB.TabIndex = 50;
            this.encounterCB.ValueMember = "EncounterId";
            this.encounterCB.SelectedIndexChanged += new System.EventHandler(this.encounterCB_SelectedIndexChanged);
            // 
            // encountersBindingSource
            // 
            this.encountersBindingSource.DataMember = "Encounters";
            this.encountersBindingSource.DataSource = this.shadowrun3ContextDataSet1;
            // 
            // shadowrun3ContextDataSet1
            // 
            this.shadowrun3ContextDataSet1.DataSetName = "Shadowrun3ContextDataSet1";
            this.shadowrun3ContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Enemies";
            // 
            // enemyDGV
            // 
            this.enemyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enemyDGV.Location = new System.Drawing.Point(50, 182);
            this.enemyDGV.Name = "enemyDGV";
            this.enemyDGV.Size = new System.Drawing.Size(240, 194);
            this.enemyDGV.TabIndex = 52;
            // 
            // seeEnemyButton
            // 
            this.seeEnemyButton.Location = new System.Drawing.Point(126, 382);
            this.seeEnemyButton.Name = "seeEnemyButton";
            this.seeEnemyButton.Size = new System.Drawing.Size(75, 23);
            this.seeEnemyButton.TabIndex = 53;
            this.seeEnemyButton.Text = "See enemy";
            this.seeEnemyButton.UseVisualStyleBackColor = true;
            this.seeEnemyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // encountersTableAdapter
            // 
            this.encountersTableAdapter.ClearBeforeFill = true;
            // 
            // FormRunEncounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seeEnemyButton);
            this.Controls.Add(this.enemyDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encounterCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormRunEncounter";
            this.Text = "FormRunEncounter";
            this.Load += new System.EventHandler(this.FormRunEncounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowrun3ContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox encounterCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView enemyDGV;
        private System.Windows.Forms.Button seeEnemyButton;
        private Shadowrun3ContextDataSet1 shadowrun3ContextDataSet1;
        private System.Windows.Forms.BindingSource encountersBindingSource;
        private Shadowrun3ContextDataSet1TableAdapters.EncountersTableAdapter encountersTableAdapter;
    }
}