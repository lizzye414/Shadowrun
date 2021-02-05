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
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.EnemyTypes' table. You can move, or remove it, as needed.
            this.enemyTypesTableAdapter1.Fill(this.shadowrun3ContextDataSet1.EnemyTypes);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.MeleeWeapons' table. You can move, or remove it, as needed.
            this.meleeWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet.MeleeWeapons);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.Spells' table. You can move, or remove it, as needed.
            this.spellsTableAdapter.Fill(this.shadowrun3ContextDataSet.Spells);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.RangedWeapons' table. You can move, or remove it, as needed.
            this.rangedWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet.RangedWeapons);

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mUTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ballisticNB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void impactNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void edgeNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void essenceNB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void magicNB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void resonanceNB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void agilityNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void charismaNB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bodyNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void intuitionNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void reactionNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void logicNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void strengthNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void willpowerNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void addRangedButton_Click(object sender, EventArgs e)
        {
            string rwString = rwAddCB.SelectedValue.ToString();

            using(var ctx = new Shadowrun3Context())
            {
                RangedWeapon newRW = ctx.RangedWeapons.FirstOrDefault(i => i.RangedWeaponId == rwString);

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.RangedWeapons.Add(newRW);

                ctx.SaveChanges();

                ResetForm();

            }

        }

        private void addMeleeButton_Click(object sender, EventArgs e)
        {
            string mwString = mwAddCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                MeleeWeapon newMW = ctx.MeleeWeapons.FirstOrDefault(i => i.MeleeWeaponId == mwString);

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.MeleeWeapons.Add(newMW);

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void addSpellButton_Click(object sender, EventArgs e)
        {
            string spellString = spellAddCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                Spell newSpell = ctx.Spells.FirstOrDefault(i => i.SpellId == spellString);

                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.Spells.Add(newSpell);

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void rwSubmitButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                try
                {
                    EnemyType et = new EnemyType();
                    et.EnemyTypeId = nameTB.Text;
                    et = SetVar(et);
                    
                    ctx.EnemyTypes.Add(et);
                    ctx.SaveChanges();

                    ResetForm();

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

                EnemyType et = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                et = SetVar(et); 
                ctx.SaveChanges();
                ResetForm();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.EnemyTypes.Remove(ctx.EnemyTypes.Single(a => a.EnemyTypeId == nameTB.Text));
                ctx.SaveChanges();

                ResetForm();
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

        private void ResetForm()
        {
            FormEnemyType NewForm = new FormEnemyType();
            NewForm.Show();
            this.Dispose(false);
        }

        private EnemyType SetVar(EnemyType et)
        {
            et.TypeOfMagicUser = mUTypeCB.Text;
            et.Ballistic = (int)ballisticNB.Value;
            et.Impact = (int)impactNB.Value;
            et.Edge = (int)edgeNB.Value;
            et.Essence = (double)essenceNB.Value;
            et.Magic = (int)magicNB.Value;
            et.Resonance = (int)resonanceNB.Value;
            et.Agility = (int)agilityNB.Value;
            et.Charisma = (int)charismaNB.Value;
            et.Body = (int)bodyNB.Value;
            et.Intuition = (int)intuitionNB.Value;
            et.Reaction = (int)reactionNB.Value;
            et.Logic = (int)logicNB.Value;
            et.Strength = (int)strengthNB.Value;
            et.Willpower = (int)willpowerNB.Value;
            et.SystemRating = (int)sysRatingNB.Value;
            return et;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow et = dataGridView1.CurrentRow;
            string etString = et.Cells[0].Value.ToString();

            //MessageBox.Show(et.Cells[0].Value.ToString());
            
            DisplayRW(etString);
            DisplayMW(etString);
            DisplaySpells(etString);
        }

        private void DisplayRW(string et)
        {
            using (var ctx = new Shadowrun3Context())
            {
               
                List<string> rwList = new List<string>();

                foreach(EnemyType etRW in ctx.EnemyTypes.Where(a => a.EnemyTypeId == et))
                {
                    
                    foreach(RangedWeapon rw in etRW.RangedWeapons)
                    {
                        rwList.Add(rw.RangedWeaponId);
                    }
                    
                }

                rwLB.DataSource = rwList;

            }

        }

        private void DisplayMW(string et)
        {
            using (var ctx = new Shadowrun3Context())
            {
                
                List<string> mwList = new List<string>();

                foreach (EnemyType etMW in ctx.EnemyTypes.Where(a => a.EnemyTypeId == et))
                {

                    foreach (MeleeWeapon mw in etMW.MeleeWeapons)
                    {
                        mwList.Add(mw.MeleeWeaponId);
                    }

                }

                mwLB.DataSource = mwList;

            }

        }

        private void DisplaySpells(string et)
        {
            using (var ctx = new Shadowrun3Context())
            {

                List<string> spellList = new List<string>();

                foreach (EnemyType etSpell in ctx.EnemyTypes.Where(a => a.EnemyTypeId == et))
                {

                    foreach (Spell spell in etSpell.Spells)
                    {
                        spellList.Add(spell.SpellId);
                    }

                }

                spellLB.DataSource = spellList;

            }

        }

    }
}
