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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mwIdTB = new System.Windows.Forms.TextBox();
            this.damAmtNB = new System.Windows.Forms.NumericUpDown();
            this.damTypeCB = new System.Windows.Forms.ComboBox();
            this.reachNB = new System.Windows.Forms.NumericUpDown();
            this.apNB = new System.Windows.Forms.NumericUpDown();
            this.mwSubmitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mwSkillCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reachNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(196, 9);
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
            this.mwIdTB.Location = new System.Drawing.Point(165, 129);
            this.mwIdTB.Name = "mwIdTB";
            this.mwIdTB.Size = new System.Drawing.Size(120, 20);
            this.mwIdTB.TabIndex = 28;
            this.mwIdTB.TextChanged += new System.EventHandler(this.mwIdTB_TextChanged);
            // 
            // damAmtNB
            // 
            this.damAmtNB.AllowDrop = true;
            this.damAmtNB.Location = new System.Drawing.Point(165, 159);
            this.damAmtNB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.damAmtNB.Name = "damAmtNB";
            this.damAmtNB.Size = new System.Drawing.Size(120, 20);
            this.damAmtNB.TabIndex = 29;
            this.damAmtNB.ValueChanged += new System.EventHandler(this.damAmtNB_ValueChanged);
            // 
            // damTypeCB
            // 
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
            this.reachNB.Location = new System.Drawing.Point(165, 220);
            this.reachNB.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.reachNB.Name = "reachNB";
            this.reachNB.Size = new System.Drawing.Size(120, 20);
            this.reachNB.TabIndex = 31;
            this.reachNB.ValueChanged += new System.EventHandler(this.reachNB_ValueChanged);
            // 
            // apNB
            // 
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
            this.apNB.ValueChanged += new System.EventHandler(this.apNB_ValueChanged);
            // 
            // mwSubmitButton
            // 
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
            "Unarmed Combat",
            "Exotic Melee Weapon"});
            this.mwSkillCB.Location = new System.Drawing.Point(165, 288);
            this.mwSkillCB.Name = "mwSkillCB";
            this.mwSkillCB.Size = new System.Drawing.Size(121, 21);
            this.mwSkillCB.TabIndex = 35;
            this.mwSkillCB.SelectedIndexChanged += new System.EventHandler(this.mwSkillCB_SelectedIndexChanged);
            // 
            // FormMeleeWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.damAmtNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reachNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apNB)).EndInit();
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
    }
}