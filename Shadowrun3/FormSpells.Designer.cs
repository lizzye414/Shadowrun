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
            this.P = new System.Windows.Forms.RadioButton();
            this.M = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spellRange = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LOS = new System.Windows.Forms.RadioButton();
            this.LOSA = new System.Windows.Forms.RadioButton();
            this.Touch = new System.Windows.Forms.RadioButton();
            this.spellDamage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.damP = new System.Windows.Forms.RadioButton();
            this.damS = new System.Windows.Forms.RadioButton();
            this.damNA = new System.Windows.Forms.RadioButton();
            this.duration = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sustained = new System.Windows.Forms.RadioButton();
            this.instant = new System.Windows.Forms.RadioButton();
            this.permanent = new System.Windows.Forms.RadioButton();
            this.dvMod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitSpell = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // spellName
            // 
            this.spellName.AutoSize = true;
            this.spellName.Location = new System.Drawing.Point(44, 66);
            this.spellName.Name = "spellName";
            this.spellName.Size = new System.Drawing.Size(61, 13);
            this.spellName.TabIndex = 0;
            this.spellName.Text = "Spell Name";
            // 
            // spellNameTB
            // 
            this.spellNameTB.Location = new System.Drawing.Point(130, 66);
            this.spellNameTB.Name = "spellNameTB";
            this.spellNameTB.Size = new System.Drawing.Size(100, 20);
            this.spellNameTB.TabIndex = 1;
            // 
            // spellType
            // 
            this.spellType.AutoSize = true;
            this.spellType.Location = new System.Drawing.Point(44, 112);
            this.spellType.Name = "spellType";
            this.spellType.Size = new System.Drawing.Size(57, 13);
            this.spellType.TabIndex = 2;
            this.spellType.Text = "Spell Type";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(12, 2);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(32, 17);
            this.P.TabIndex = 3;
            this.P.TabStop = true;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(50, 3);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(34, 17);
            this.M.TabIndex = 4;
            this.M.TabStop = true;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.P);
            this.panel1.Controls.Add(this.M);
            this.panel1.Location = new System.Drawing.Point(130, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 22);
            this.panel1.TabIndex = 5;
            // 
            // spellRange
            // 
            this.spellRange.AutoSize = true;
            this.spellRange.Location = new System.Drawing.Point(44, 166);
            this.spellRange.Name = "spellRange";
            this.spellRange.Size = new System.Drawing.Size(65, 13);
            this.spellRange.TabIndex = 6;
            this.spellRange.Text = "Spell Range";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Touch);
            this.panel2.Controls.Add(this.LOSA);
            this.panel2.Controls.Add(this.LOS);
            this.panel2.Location = new System.Drawing.Point(130, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 27);
            this.panel2.TabIndex = 7;
            // 
            // LOS
            // 
            this.LOS.AutoSize = true;
            this.LOS.Location = new System.Drawing.Point(3, 5);
            this.LOS.Name = "LOS";
            this.LOS.Size = new System.Drawing.Size(46, 17);
            this.LOS.TabIndex = 8;
            this.LOS.TabStop = true;
            this.LOS.Text = "LOS";
            this.LOS.UseVisualStyleBackColor = true;
            // 
            // LOSA
            // 
            this.LOSA.AutoSize = true;
            this.LOSA.Location = new System.Drawing.Point(55, 5);
            this.LOSA.Name = "LOSA";
            this.LOSA.Size = new System.Drawing.Size(59, 17);
            this.LOSA.TabIndex = 9;
            this.LOSA.TabStop = true;
            this.LOSA.Text = "LOS(A)";
            this.LOSA.UseVisualStyleBackColor = true;
            // 
            // Touch
            // 
            this.Touch.AutoSize = true;
            this.Touch.Location = new System.Drawing.Point(120, 5);
            this.Touch.Name = "Touch";
            this.Touch.Size = new System.Drawing.Size(56, 17);
            this.Touch.TabIndex = 10;
            this.Touch.TabStop = true;
            this.Touch.Text = "Touch";
            this.Touch.UseVisualStyleBackColor = true;
            // 
            // spellDamage
            // 
            this.spellDamage.AutoSize = true;
            this.spellDamage.Location = new System.Drawing.Point(47, 217);
            this.spellDamage.Name = "spellDamage";
            this.spellDamage.Size = new System.Drawing.Size(73, 13);
            this.spellDamage.TabIndex = 8;
            this.spellDamage.Text = "Spell Damage";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.damNA);
            this.panel3.Controls.Add(this.damS);
            this.panel3.Controls.Add(this.damP);
            this.panel3.Location = new System.Drawing.Point(130, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 26);
            this.panel3.TabIndex = 9;
            // 
            // damP
            // 
            this.damP.AutoSize = true;
            this.damP.Location = new System.Drawing.Point(3, 3);
            this.damP.Name = "damP";
            this.damP.Size = new System.Drawing.Size(32, 17);
            this.damP.TabIndex = 0;
            this.damP.TabStop = true;
            this.damP.Text = "P";
            this.damP.UseVisualStyleBackColor = true;
            // 
            // damS
            // 
            this.damS.AutoSize = true;
            this.damS.Location = new System.Drawing.Point(36, 3);
            this.damS.Name = "damS";
            this.damS.Size = new System.Drawing.Size(32, 17);
            this.damS.TabIndex = 10;
            this.damS.TabStop = true;
            this.damS.Text = "S";
            this.damS.UseVisualStyleBackColor = true;
            // 
            // damNA
            // 
            this.damNA.AutoSize = true;
            this.damNA.Location = new System.Drawing.Point(74, 3);
            this.damNA.Name = "damNA";
            this.damNA.Size = new System.Drawing.Size(45, 17);
            this.damNA.TabIndex = 11;
            this.damNA.TabStop = true;
            this.damNA.Text = "N/A";
            this.damNA.UseVisualStyleBackColor = true;
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(50, 269);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(47, 13);
            this.duration.TabIndex = 10;
            this.duration.Text = "Duration";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.permanent);
            this.panel4.Controls.Add(this.instant);
            this.panel4.Controls.Add(this.sustained);
            this.panel4.Location = new System.Drawing.Point(130, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 27);
            this.panel4.TabIndex = 11;
            // 
            // sustained
            // 
            this.sustained.AutoSize = true;
            this.sustained.Location = new System.Drawing.Point(4, 5);
            this.sustained.Name = "sustained";
            this.sustained.Size = new System.Drawing.Size(72, 17);
            this.sustained.TabIndex = 0;
            this.sustained.TabStop = true;
            this.sustained.Text = "Sustained";
            this.sustained.UseVisualStyleBackColor = true;
            // 
            // instant
            // 
            this.instant.AutoSize = true;
            this.instant.Location = new System.Drawing.Point(83, 5);
            this.instant.Name = "instant";
            this.instant.Size = new System.Drawing.Size(57, 17);
            this.instant.TabIndex = 1;
            this.instant.TabStop = true;
            this.instant.Text = "Instant";
            this.instant.UseVisualStyleBackColor = true;
            // 
            // permanent
            // 
            this.permanent.AutoSize = true;
            this.permanent.Location = new System.Drawing.Point(147, 5);
            this.permanent.Name = "permanent";
            this.permanent.Size = new System.Drawing.Size(76, 17);
            this.permanent.TabIndex = 2;
            this.permanent.TabStop = true;
            this.permanent.Text = "Permanent";
            this.permanent.UseVisualStyleBackColor = true;
            // 
            // dvMod
            // 
            this.dvMod.AutoSize = true;
            this.dvMod.Location = new System.Drawing.Point(53, 327);
            this.dvMod.Name = "dvMod";
            this.dvMod.Size = new System.Drawing.Size(49, 13);
            this.dvMod.TabIndex = 12;
            this.dvMod.Text = "D.V.Mod";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 13;
            // 
            // submitSpell
            // 
            this.submitSpell.Location = new System.Drawing.Point(130, 388);
            this.submitSpell.Name = "submitSpell";
            this.submitSpell.Size = new System.Drawing.Size(75, 23);
            this.submitSpell.TabIndex = 14;
            this.submitSpell.Text = "Submit";
            this.submitSpell.UseVisualStyleBackColor = true;
            // 
            // FormSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitSpell);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dvMod);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.spellDamage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.spellRange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spellType);
            this.Controls.Add(this.spellNameTB);
            this.Controls.Add(this.spellName);
            this.Name = "FormSpells";
            this.Text = "FormSpells";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spellName;
        private System.Windows.Forms.TextBox spellNameTB;
        private System.Windows.Forms.Label spellType;
        private System.Windows.Forms.RadioButton P;
        private System.Windows.Forms.RadioButton M;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label spellRange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Touch;
        private System.Windows.Forms.RadioButton LOSA;
        private System.Windows.Forms.RadioButton LOS;
        private System.Windows.Forms.Label spellDamage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton damNA;
        private System.Windows.Forms.RadioButton damS;
        private System.Windows.Forms.RadioButton damP;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton permanent;
        private System.Windows.Forms.RadioButton instant;
        private System.Windows.Forms.RadioButton sustained;
        private System.Windows.Forms.Label dvMod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitSpell;
    }
}