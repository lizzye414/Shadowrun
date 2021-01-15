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


        private void DVModTB_TextChanged(object sender, EventArgs e)
        {
            newSpell.DVMod = Int32.Parse(DVModTB.Text);
            DVModNegCB.Enabled = true;
        }

        private void DVModNegCB_CheckedChanged(object sender, EventArgs e)
        {
            newSpell.DVMod = (newSpell.DVMod * (-1));
        }

        private void submitSpell_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                ctx.Spells.Add(newSpell);
                ctx.SaveChanges();
            }

        }


    }
}
