using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowrun3
{
    public partial class FormSpells : Form
    {
        public FormSpells()
        {
            InitializeComponent();
            
        }

        Spell newSpell = new Spell();

        private void spellNameTB_TextChanged(object sender, EventArgs e)
        {
            newSpell.SpellId = spellNameTB.Text;
        }

        private void spellTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSpell.TypeOfSpell = spellTypeCB.Text;
        }

        private void spellCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSpell.CategoryOfSpell = spellCategoryCB.Text;
        }

        private void spellRangeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSpell.RangeOfSpell = spellRangeCB.Text;
        }

        private void spellDamageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSpell.DamageOfSpell = spellDamageCB.Text;
        }

        private void spellDurationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSpell.DurationOfSpell = spellDurationCB.Text;
        }

        private void dvModNB_ValueChanged(object sender, EventArgs e)
        {
            newSpell.DVMod = (int)dvModNB.Value;
        }


        private void submitSpell_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                try
                {
                    ctx.Spells.Add(newSpell);
                    ctx.SaveChanges();

                    FormSpells NewForm = new FormSpells();
                    NewForm.Show();
                    this.Dispose(false);

                }
                catch
                {
                    MessageBox.Show("That spell already exists");
                }
            }

        }

        private void FormSpells_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.Spells' table. You can move, or remove it, as needed.
            this.spellsTableAdapter.Fill(this.shadowrun3ContextDataSet.Spells);

        }

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                spellNameTB.Enabled = true;
                submitSpell.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                spellNameTB.Enabled = false;
                submitSpell.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                Spell updatedSpell = ctx.Spells.First(a => a.SpellId == spellNameTB.Text);
                updatedSpell.TypeOfSpell = spellTypeCB.Text;
                updatedSpell.CategoryOfSpell = spellCategoryCB.Text;
                updatedSpell.RangeOfSpell = spellRangeCB.Text;
                updatedSpell.DamageOfSpell = spellDamageCB.Text;
                updatedSpell.DurationOfSpell = spellDurationCB.Text;
                updatedSpell.DVMod = (int)dvModNB.Value;
                ctx.SaveChanges();

                FormSpells NewForm = new FormSpells();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.Spells.Remove(ctx.Spells.Single(a => a.SpellId == spellNameTB.Text));
                ctx.SaveChanges();

                FormSpells NewForm = new FormSpells();
                NewForm.Show();
                this.Dispose(false);
            }
        }
    }
}
