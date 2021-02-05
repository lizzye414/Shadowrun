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

        private void spellNameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void spellTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void spellCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void spellRangeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void spellDamageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void spellDurationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dvModNB_ValueChanged(object sender, EventArgs e)
        {
            
        }


        private void submitSpell_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                try
                {
                    Spell sp = new Spell();
                    sp.SpellId = nameTB.Text;
                    sp = SetVar(sp);
                    
                    ctx.Spells.Add(sp);
                    ctx.SaveChanges();

                    ResetForm();

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
                nameTB.Enabled = true;
                submitSpell.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                nameTB.Enabled = false;
                submitSpell.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                Spell sp = ctx.Spells.First(a => a.SpellId == nameTB.Text);
                sp = SetVar(sp);
                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.Spells.Remove(ctx.Spells.Single(a => a.SpellId == nameTB.Text));
                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void ResetForm()
        {
            FormSpells NewForm = new FormSpells();
            NewForm.Show();
            this.Dispose(false);
        }

        private Spell SetVar(Spell sp)
        {
            sp.TypeOfSpell = spellTypeCB.Text;
            sp.CategoryOfSpell = spellCategoryCB.Text;
            sp.RangeOfSpell = spellRangeCB.Text;
            sp.DamageOfSpell = spellDamageCB.Text;
            sp.DurationOfSpell = spellDurationCB.Text;
            sp.DVMod = (int)dvModNB.Value;
            return sp;
        }

    }
}
