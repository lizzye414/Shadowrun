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
            this.spellName = new System.Windows.Forms.Label();
            this.spellNameTB = new System.Windows.Forms.TextBox();
            this.spellType = new System.Windows.Forms.Label();
            this.spellRange = new System.Windows.Forms.Label();
            this.spellDamage = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.dvMod = new System.Windows.Forms.Label();
            this.DVModTB = new System.Windows.Forms.TextBox();
            this.submitSpell = new System.Windows.Forms.Button();
            this.spellCategory = new System.Windows.Forms.Label();
            this.spellTypeCB = new System.Windows.Forms.ComboBox();
            this.spellCategoryCB = new System.Windows.Forms.ComboBox();
            this.spellRangeCB = new System.Windows.Forms.ComboBox();
            this.spellDamageCB = new System.Windows.Forms.ComboBox();
            this.spellDurationCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DVModNegCB = new System.Windows.Forms.CheckBox();
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
            this.spellNameTB.Location = new System.Drawing.Point(129, 95);
            this.spellNameTB.Name = "spellNameTB";
            this.spellNameTB.Size = new System.Drawing.Size(121, 20);
            this.spellNameTB.TabIndex = 1;
            this.spellNameTB.TextChanged += new System.EventHandler(this.spellNameTB_TextChanged);
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
            // DVModTB
            // 
            this.DVModTB.Location = new System.Drawing.Point(129, 308);
            this.DVModTB.Name = "DVModTB";
            this.DVModTB.Size = new System.Drawing.Size(121, 20);
            this.DVModTB.TabIndex = 13;
            this.DVModTB.TextChanged += new System.EventHandler(this.DVModTB_TextChanged);
            // 
            // submitSpell
            // 
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
            this.label1.Location = new System.Drawing.Point(287, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 22;
            this.label1.Text = "Spells";
            // 
            // DVModNegCB
            // 
            this.DVModNegCB.AutoSize = true;
            this.DVModNegCB.Enabled = false;
            this.DVModNegCB.Location = new System.Drawing.Point(256, 311);
            this.DVModNegCB.Name = "DVModNegCB";
            this.DVModNegCB.Size = new System.Drawing.Size(73, 17);
            this.DVModNegCB.TabIndex = 23;
            this.DVModNegCB.Text = "negative?";
            this.DVModNegCB.UseVisualStyleBackColor = true;
            this.DVModNegCB.CheckedChanged += new System.EventHandler(this.DVModNegCB_CheckedChanged);
            // 
            // FormSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DVModNegCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spellDurationCB);
            this.Controls.Add(this.spellDamageCB);
            this.Controls.Add(this.spellRangeCB);
            this.Controls.Add(this.spellCategoryCB);
            this.Controls.Add(this.spellTypeCB);
            this.Controls.Add(this.spellCategory);
            this.Controls.Add(this.submitSpell);
            this.Controls.Add(this.DVModTB);
            this.Controls.Add(this.dvMod);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.spellDamage);
            this.Controls.Add(this.spellRange);
            this.Controls.Add(this.spellType);
            this.Controls.Add(this.spellNameTB);
            this.Controls.Add(this.spellName);
            this.Name = "FormSpells";
            this.Text = "FormSpells";
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
        private System.Windows.Forms.TextBox DVModTB;
        private System.Windows.Forms.Button submitSpell;
        private System.Windows.Forms.Label spellCategory;
        private System.Windows.Forms.ComboBox spellTypeCB;
        private System.Windows.Forms.ComboBox spellCategoryCB;
        private System.Windows.Forms.ComboBox spellRangeCB;
        private System.Windows.Forms.ComboBox spellDamageCB;
        private System.Windows.Forms.ComboBox spellDurationCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DVModNegCB;
    }
}