namespace Shadowrun3
{
    partial class FormNamedEnemy
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateRB = new System.Windows.Forms.RadioButton();
            this.newRB = new System.Windows.Forms.RadioButton();
            this.submitSpell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SysRatingNB = new System.Windows.Forms.NumericUpDown();
            this.HPNB = new System.Windows.Forms.NumericUpDown();
            this.EdgeNB = new System.Windows.Forms.NumericUpDown();
            this.MatrixNB = new System.Windows.Forms.NumericUpDown();
            this.StunNB = new System.Windows.Forms.NumericUpDown();
            this.AmmoNB = new System.Windows.Forms.NumericUpDown();
            this.enemyTypeCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SysRatingNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoNB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Named Enemy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enemy Type";
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(149, 390);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(149, 360);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 37;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateRB);
            this.panel1.Controls.Add(this.newRB);
            this.panel1.Location = new System.Drawing.Point(12, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 109);
            this.panel1.TabIndex = 36;
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
            // 
            // newRB
            // 
            this.newRB.AutoSize = true;
            this.newRB.Location = new System.Drawing.Point(7, 24);
            this.newRB.Name = "newRB";
            this.newRB.Size = new System.Drawing.Size(107, 17);
            this.newRB.TabIndex = 0;
            this.newRB.Text = "Enter new enemy";
            this.newRB.UseVisualStyleBackColor = true;
            // 
            // submitSpell
            // 
            this.submitSpell.Enabled = false;
            this.submitSpell.Location = new System.Drawing.Point(149, 329);
            this.submitSpell.Name = "submitSpell";
            this.submitSpell.Size = new System.Drawing.Size(75, 23);
            this.submitSpell.TabIndex = 35;
            this.submitSpell.Text = "Submit";
            this.submitSpell.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Current HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Current Stun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Current Matrix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Current Ammo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Current Edge";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "System Rating";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 45;
            // 
            // SysRatingNB
            // 
            this.SysRatingNB.Location = new System.Drawing.Point(134, 250);
            this.SysRatingNB.Name = "SysRatingNB";
            this.SysRatingNB.Size = new System.Drawing.Size(120, 20);
            this.SysRatingNB.TabIndex = 47;
            this.SysRatingNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HPNB
            // 
            this.HPNB.Location = new System.Drawing.Point(134, 140);
            this.HPNB.Name = "HPNB";
            this.HPNB.Size = new System.Drawing.Size(120, 20);
            this.HPNB.TabIndex = 48;
            this.HPNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EdgeNB
            // 
            this.EdgeNB.Location = new System.Drawing.Point(134, 228);
            this.EdgeNB.Name = "EdgeNB";
            this.EdgeNB.Size = new System.Drawing.Size(120, 20);
            this.EdgeNB.TabIndex = 49;
            this.EdgeNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatrixNB
            // 
            this.MatrixNB.Location = new System.Drawing.Point(134, 184);
            this.MatrixNB.Name = "MatrixNB";
            this.MatrixNB.Size = new System.Drawing.Size(120, 20);
            this.MatrixNB.TabIndex = 50;
            this.MatrixNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StunNB
            // 
            this.StunNB.Location = new System.Drawing.Point(134, 162);
            this.StunNB.Name = "StunNB";
            this.StunNB.Size = new System.Drawing.Size(120, 20);
            this.StunNB.TabIndex = 51;
            this.StunNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmmoNB
            // 
            this.AmmoNB.Location = new System.Drawing.Point(134, 206);
            this.AmmoNB.Name = "AmmoNB";
            this.AmmoNB.Size = new System.Drawing.Size(120, 20);
            this.AmmoNB.TabIndex = 52;
            this.AmmoNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enemyTypeCB
            // 
            this.enemyTypeCB.FormattingEnabled = true;
            this.enemyTypeCB.Location = new System.Drawing.Point(134, 117);
            this.enemyTypeCB.Name = "enemyTypeCB";
            this.enemyTypeCB.Size = new System.Drawing.Size(120, 21);
            this.enemyTypeCB.TabIndex = 53;
            this.enemyTypeCB.SelectedIndexChanged += new System.EventHandler(this.enemyTypeCB_SelectedIndexChanged);
            // 
            // FormNamedEnemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enemyTypeCB);
            this.Controls.Add(this.AmmoNB);
            this.Controls.Add(this.StunNB);
            this.Controls.Add(this.MatrixNB);
            this.Controls.Add(this.EdgeNB);
            this.Controls.Add(this.HPNB);
            this.Controls.Add(this.SysRatingNB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitSpell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNamedEnemy";
            this.Text = "FormNamedEnemy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SysRatingNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton updateRB;
        private System.Windows.Forms.RadioButton newRB;
        private System.Windows.Forms.Button submitSpell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown SysRatingNB;
        private System.Windows.Forms.NumericUpDown HPNB;
        private System.Windows.Forms.NumericUpDown EdgeNB;
        private System.Windows.Forms.NumericUpDown MatrixNB;
        private System.Windows.Forms.NumericUpDown StunNB;
        private System.Windows.Forms.NumericUpDown AmmoNB;
        private System.Windows.Forms.ComboBox enemyTypeCB;
    }
}