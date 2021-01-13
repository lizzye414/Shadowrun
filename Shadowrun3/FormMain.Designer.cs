namespace Shadowrun3
{
    partial class FormMain
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
            this.RangedWeapons = new System.Windows.Forms.Button();
            this.meleeWeapons = new System.Windows.Forms.Button();
            this.encounter = new System.Windows.Forms.Button();
            this.enemyType = new System.Windows.Forms.Button();
            this.matrixPrograms = new System.Windows.Forms.Button();
            this.namedEnemies = new System.Windows.Forms.Button();
            this.spells = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RangedWeapons
            // 
            this.RangedWeapons.Location = new System.Drawing.Point(85, 242);
            this.RangedWeapons.Name = "RangedWeapons";
            this.RangedWeapons.Size = new System.Drawing.Size(127, 27);
            this.RangedWeapons.TabIndex = 0;
            this.RangedWeapons.Text = "Ranged Weapons";
            this.RangedWeapons.UseVisualStyleBackColor = true;
            this.RangedWeapons.Click += new System.EventHandler(this.button1_Click);
            // 
            // meleeWeapons
            // 
            this.meleeWeapons.Location = new System.Drawing.Point(85, 275);
            this.meleeWeapons.Name = "meleeWeapons";
            this.meleeWeapons.Size = new System.Drawing.Size(127, 27);
            this.meleeWeapons.TabIndex = 1;
            this.meleeWeapons.Text = "Melee Weapons";
            this.meleeWeapons.UseVisualStyleBackColor = true;
            this.meleeWeapons.Click += new System.EventHandler(this.meleeWeapons_Click);
            // 
            // encounter
            // 
            this.encounter.Location = new System.Drawing.Point(85, 143);
            this.encounter.Name = "encounter";
            this.encounter.Size = new System.Drawing.Size(127, 27);
            this.encounter.TabIndex = 2;
            this.encounter.Text = "Encounters";
            this.encounter.UseVisualStyleBackColor = true;
            this.encounter.Click += new System.EventHandler(this.encounter_Click);
            // 
            // enemyType
            // 
            this.enemyType.Location = new System.Drawing.Point(85, 209);
            this.enemyType.Name = "enemyType";
            this.enemyType.Size = new System.Drawing.Size(127, 27);
            this.enemyType.TabIndex = 3;
            this.enemyType.Text = "Enemy Types";
            this.enemyType.UseVisualStyleBackColor = true;
            this.enemyType.Click += new System.EventHandler(this.enemyType_Click);
            // 
            // matrixPrograms
            // 
            this.matrixPrograms.Location = new System.Drawing.Point(85, 308);
            this.matrixPrograms.Name = "matrixPrograms";
            this.matrixPrograms.Size = new System.Drawing.Size(127, 27);
            this.matrixPrograms.TabIndex = 4;
            this.matrixPrograms.Text = "Matrix Programs";
            this.matrixPrograms.UseVisualStyleBackColor = true;
            this.matrixPrograms.Click += new System.EventHandler(this.matrixPrograms_Click);
            // 
            // namedEnemies
            // 
            this.namedEnemies.Location = new System.Drawing.Point(85, 176);
            this.namedEnemies.Name = "namedEnemies";
            this.namedEnemies.Size = new System.Drawing.Size(127, 27);
            this.namedEnemies.TabIndex = 5;
            this.namedEnemies.Text = "Named Enemies";
            this.namedEnemies.UseVisualStyleBackColor = true;
            this.namedEnemies.Click += new System.EventHandler(this.namedEnemies_Click);
            // 
            // spells
            // 
            this.spells.Location = new System.Drawing.Point(85, 341);
            this.spells.Name = "spells";
            this.spells.Size = new System.Drawing.Size(127, 27);
            this.spells.TabIndex = 6;
            this.spells.Text = "Spells";
            this.spells.UseVisualStyleBackColor = true;
            this.spells.Click += new System.EventHandler(this.spells_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spells);
            this.Controls.Add(this.namedEnemies);
            this.Controls.Add(this.matrixPrograms);
            this.Controls.Add(this.enemyType);
            this.Controls.Add(this.encounter);
            this.Controls.Add(this.meleeWeapons);
            this.Controls.Add(this.RangedWeapons);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RangedWeapons;
        private System.Windows.Forms.Button meleeWeapons;
        private System.Windows.Forms.Button encounter;
        private System.Windows.Forms.Button enemyType;
        private System.Windows.Forms.Button matrixPrograms;
        private System.Windows.Forms.Button namedEnemies;
        private System.Windows.Forms.Button spells;
    }
}

