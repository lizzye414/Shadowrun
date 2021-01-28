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
    public partial class FormEnemyType : Form
    {
        public FormEnemyType()
        {
            InitializeComponent();
        }

        private void FormEnemyType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.MeleeWeapons' table. You can move, or remove it, as needed.
            this.meleeWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet.MeleeWeapons);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.Spells' table. You can move, or remove it, as needed.
            this.spellsTableAdapter.Fill(this.shadowrun3ContextDataSet.Spells);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.RangedWeapons' table. You can move, or remove it, as needed.
            this.rangedWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet.RangedWeapons);

        }

        EnemyType newEnemy = new EnemyType();
        string rwString;
        string mwString;
        string spellString;

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            newEnemy.EnemyTypeId = nameTB.Text;
        }

        private void mUTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newEnemy.TypeOfMagicUser = mUTypeCB.Text;
        }

        private void ballisticNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Ballistic = (int)ballisticNB.Value;
        }

        private void impactNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Impact = (int)impactNB.Value;
        }

        private void edgeNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Edge = (int)edgeNB.Value;
        }

        private void essenceNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Essence = (double)essenceNB.Value;
        }

        private void magicNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Magic = (int)magicNB.Value;
        }

        private void resonanceNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Resonance = (int)resonanceNB.Value;
        }

        private void agilityNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Agility = (int)agilityNB.Value;
        }

        private void charismaNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Charisma = (int)charismaNB.Value;
        }

        private void bodyNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Body = (int)bodyNB.Value;
        }

        private void intuitionNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Intuition = (int)intuitionNB.Value;
        }

        private void reactionNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Reaction = (int)reactionNB.Value;
        }

        private void logicNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Logic = (int)logicNB.Value;
        }

        private void strengthNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Strength = (int)strengthNB.Value;
        }

        private void willpowerNB_ValueChanged(object sender, EventArgs e)
        {
            newEnemy.Willpower = (int)willpowerNB.Value;
        }

        private void addRangedButton_Click(object sender, EventArgs e)
        {
            rwString = rwAddCB.SelectedValue.ToString();

            using(var ctx = new Shadowrun3Context())
            {
                RangedWeapon newRW = ctx.RangedWeapons.FirstOrDefault(i => i.RangedWeaponId == rwString);

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.RangedWeapons.Add(newRW);

                ctx.SaveChanges();

                FormEnemyType NewForm = new FormEnemyType();
                NewForm.Show();
                this.Dispose(false);

            }

        }

        private void addMeleeButton_Click(object sender, EventArgs e)
        {
            mwString = mwAddCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                MeleeWeapon newMW = ctx.MeleeWeapons.FirstOrDefault(i => i.MeleeWeaponId == mwString);

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.MeleeWeapons.Add(newMW);

                ctx.SaveChanges();

                FormEnemyType NewForm = new FormEnemyType();
                NewForm.Show();
                this.Dispose(false);

            }
        }

        private void addSpellButton_Click(object sender, EventArgs e)
        {
            spellString = spellAddCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                Spell newSpell = ctx.Spells.FirstOrDefault(i => i.SpellId == spellString);

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.Spells.Add(newSpell);

                ctx.SaveChanges();

                FormEnemyType NewForm = new FormEnemyType();
                NewForm.Show();
                this.Dispose(false);

            }
        }

        private void rwSubmitButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                try
                {
                    ctx.EnemyTypes.Add(newEnemy);
                    ctx.SaveChanges();

                    FormEnemyType NewForm = new FormEnemyType();
                    NewForm.Show();
                    this.Dispose(false);

                }
                catch
                {
                    MessageBox.Show("That enemy type already exists");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.TypeOfMagicUser = mUTypeCB.Text;
                updatedET.Ballistic = (int)ballisticNB.Value;
                updatedET.Impact = (int)impactNB.Value;
                updatedET.Edge = (int)edgeNB.Value;
                updatedET.Essence = (double)essenceNB.Value;
                updatedET.Magic = (int)magicNB.Value;
                updatedET.Resonance = (int)resonanceNB.Value;
                updatedET.Agility = (int)agilityNB.Value;
                updatedET.Charisma = (int)charismaNB.Value;
                updatedET.Body = (int)bodyNB.Value;
                updatedET.Intuition = (int)intuitionNB.Value;
                updatedET.Reaction = (int)reactionNB.Value;
                updatedET.Logic = (int)logicNB.Value;
                updatedET.Strength = (int)strengthNB.Value;
                updatedET.Willpower = (int)willpowerNB.Value;
                ctx.SaveChanges();

                FormEnemyType NewForm = new FormEnemyType();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.EnemyTypes.Remove(ctx.EnemyTypes.Single(a => a.EnemyTypeId == nameTB.Text));
                ctx.SaveChanges();

                FormEnemyType NewForm = new FormEnemyType();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                nameTB.Enabled = true;
                rwSubmitButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                addRangedButton.Enabled = false;
                addMeleeButton.Enabled = false;
                addSpellButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                nameTB.Enabled = false;
                rwSubmitButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                addRangedButton.Enabled = true;
                addMeleeButton.Enabled = true;
                addSpellButton.Enabled = true;
            }
        }

    }
}
