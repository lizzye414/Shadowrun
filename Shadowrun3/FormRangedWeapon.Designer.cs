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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rwIdTB = new System.Windows.Forms.TextBox();
            this.damAmtNB = new System.Windows.Forms.NumericUpDown();
            this.DamTypeCB = new System.Windows.Forms.ComboBox();
            this.modeOfFireCB = new System.Windows.Forms.ComboBox();
            this.ammoTypeTB = new System.Windows.Forms.TextBox();
            this.apNB = new System.Windows.Forms.NumericUpDown();
            this.rwSubmitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rwSkillCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 55);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ranged Weapons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Damage Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Damage Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mode of Fire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ammo Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "AP";
            // 
            // rwIdTB
            // 
            this.rwIdTB.Location = new System.Drawing.Point(190, 120);
            this.rwIdTB.Name = "rwIdTB";
            this.rwIdTB.Size = new System.Drawing.Size(120, 20);
            this.rwIdTB.TabIndex = 31;
            this.rwIdTB.TextChanged += new System.EventHandler(this.rwIdTB_TextChanged);
            // 
            // damAmtNB
            // 
            this.damAmtNB.Location = new System.Drawing.Point(190, 153);
            this.damAmtNB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.damAmtNB.Name = "damAmtNB";
            this.damAmtNB.Size = new System.Drawing.Size(120, 20);
            this.damAmtNB.TabIndex = 32;
            this.damAmtNB.ValueChanged += new System.EventHandler(this.damAmtNB_ValueChanged);
            // 
            // DamTypeCB
            // 
            this.DamTypeCB.FormattingEnabled = true;
            this.DamTypeCB.Items.AddRange(new object[] {
            "P",
            "S",
            "S(e)"});
            this.DamTypeCB.Location = new System.Drawing.Point(190, 188);
            this.DamTypeCB.Name = "DamTypeCB";
            this.DamTypeCB.Size = new System.Drawing.Size(121, 21);
            this.DamTypeCB.TabIndex = 33;
            this.DamTypeCB.SelectedIndexChanged += new System.EventHandler(this.DamTypeCB_SelectedIndexChanged);
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
            this.modeOfFireCB.Location = new System.Drawing.Point(190, 219);
            this.modeOfFireCB.Name = "modeOfFireCB";
            this.modeOfFireCB.Size = new System.Drawing.Size(121, 21);
            this.modeOfFireCB.TabIndex = 34;
            this.modeOfFireCB.SelectedIndexChanged += new System.EventHandler(this.modeOfFireCB_SelectedIndexChanged);
            // 
            // ammoTypeTB
            // 
            this.ammoTypeTB.Location = new System.Drawing.Point(190, 248);
            this.ammoTypeTB.Name = "ammoTypeTB";
            this.ammoTypeTB.Size = new System.Drawing.Size(120, 20);
            this.ammoTypeTB.TabIndex = 35;
            this.ammoTypeTB.TextChanged += new System.EventHandler(this.ammoTypeTB_TextChanged);
            // 
            // apNB
            // 
            this.apNB.Location = new System.Drawing.Point(190, 277);
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
            this.apNB.ValueChanged += new System.EventHandler(this.apNB_ValueChanged);
            // 
            // rwSubmitButton
            // 
            this.rwSubmitButton.Location = new System.Drawing.Point(212, 359);
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
            this.label8.Location = new System.Drawing.Point(88, 311);
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
            this.rwSkillCB.Location = new System.Drawing.Point(190, 311);
            this.rwSkillCB.Name = "rwSkillCB";
            this.rwSkillCB.Size = new System.Drawing.Size(121, 21);
            this.rwSkillCB.TabIndex = 39;
            this.rwSkillCB.SelectedIndexChanged += new System.EventHandler(this.rwSkillCB_SelectedIndexChanged);
            // 
            // FormRangedWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rwSkillCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rwSubmitButton);
            this.Controls.Add(this.apNB);
            this.Controls.Add(this.ammoTypeTB);
            this.Controls.Add(this.modeOfFireCB);
            this.Controls.Add(this.DamTypeCB);
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
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).EndInit();
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
        private System.Windows.Forms.ComboBox DamTypeCB;
        private System.Windows.Forms.ComboBox modeOfFireCB;
        private System.Windows.Forms.TextBox ammoTypeTB;
        private System.Windows.Forms.NumericUpDown apNB;
        private System.Windows.Forms.Button rwSubmitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rwSkillCB;
    }
}