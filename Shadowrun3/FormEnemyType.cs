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
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.Skills' table. You can move, or remove it, as needed.
            this.skillsTableAdapter.Fill(this.shadowrun3ContextDataSet1.Skills);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.SkillGroups' table. You can move, or remove it, as needed.
            this.skillGroupsTableAdapter.Fill(this.shadowrun3ContextDataSet1.SkillGroups);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.EnemySkillGroups' table. You can move, or remove it, as needed.
            //this.enemySkillGroupsTableAdapter.Fill(this.shadowrun3ContextDataSet1.EnemySkillGroups);
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
                remRangedButton.Enabled = false;
                remMeleeButton.Enabled = false;
                remSpellButton.Enabled = false;
                addSButton.Enabled = false;
                updateSButton.Enabled = false;
                removeSButton.Enabled = false;
                addSGButton.Enabled = false;
                updateSGButton.Enabled = false;
                removeSGButton.Enabled = false;
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
                remRangedButton.Enabled = true;
                remMeleeButton.Enabled = true;
                remSpellButton.Enabled = true;
                addSButton.Enabled = true;
                updateSButton.Enabled = true;
                removeSButton.Enabled = true;
                addSGButton.Enabled = true;
                updateSGButton.Enabled = true;
                removeSGButton.Enabled = true;
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
            
            DisplayRW(etString);
            DisplayMW(etString);
            DisplaySpells(etString);

            DisplaySG(etString);
            DisplayS(etString);
        }

        private void addRangedButton_Click(object sender, EventArgs e)
        {
            string rwString = rwAddCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
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

        private void remRangedButton_Click(object sender, EventArgs e)
        {
            string rwString = rwLB.SelectedItem.ToString();
            using (var ctx = new Shadowrun3Context())
            {
                RangedWeapon remRW = ctx.RangedWeapons.FirstOrDefault(i => i.RangedWeaponId == rwString);
                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.RangedWeapons.Remove(remRW);

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void remMeleeButton_Click(object sender, EventArgs e)
        {
            string mwString = mwLB.SelectedItem.ToString();
            using (var ctx = new Shadowrun3Context())
            {
                MeleeWeapon remMW = ctx.MeleeWeapons.FirstOrDefault(i => i.MeleeWeaponId == mwString);
                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.MeleeWeapons.Remove(remMW);

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void remSpellButton_Click(object sender, EventArgs e)
        {
            string spellString = spellLB.SelectedItem.ToString();
            using (var ctx = new Shadowrun3Context())
            {
                Spell remSpell = ctx.Spells.FirstOrDefault(i => i.SpellId == spellString);
                EnemyType updatedET = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                updatedET.Spells.Remove(remSpell);

                ctx.SaveChanges();

                ResetForm();
            }
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

        private void addSGButton_Click(object sender, EventArgs e)
        {
            string sgString = skillGroupCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                SkillGroup sg = ctx.SkillGroups.FirstOrDefault(i => i.SkillGroupId == sgString);
                EnemyType et = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                int rank = (int)skillGroupRankNB.Value;
                EnemySkillGroup esg = new EnemySkillGroup();

                esg.SkillGroup = sg;
                esg.EnemyType = et;
                esg.Rank = rank;

                ctx.EnemySkillGroups.Add(esg);

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void updateSGButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                DataGridViewRow sg = sgDGV.CurrentRow;
                string sgString = sg.Cells[0].Value.ToString();

                EnemySkillGroup esg = ctx.EnemySkillGroups.FirstOrDefault(i => i.SkillGroup.SkillGroupId == sgString);

                esg.Rank = (int)skillGroupRankNB.Value;

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void removeSGButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                DataGridViewRow sg = sgDGV.CurrentRow;
                string sgString = sg.Cells[0].Value.ToString();

                EnemySkillGroup esg = ctx.EnemySkillGroups.FirstOrDefault(i => i.SkillGroup.SkillGroupId == sgString);

                ctx.EnemySkillGroups.Remove(esg);

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void addSButton_Click(object sender, EventArgs e)
        {
            string sString = skillCB.SelectedValue.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                Skill s = ctx.Skills.FirstOrDefault(i => i.SkillId == sString);
                EnemyType et = ctx.EnemyTypes.First(a => a.EnemyTypeId == nameTB.Text);
                int rank = (int)skillRankNB.Value;
                EnemySkill es = new EnemySkill();

                es.Skill = s;
                es.EnemyType = et;
                es.EnemySkillRank = rank;

                ctx.EnemySkills.Add(es);

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void updateSButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                DataGridViewRow s = sDGV.CurrentRow;
                string sString = s.Cells[0].Value.ToString();

                EnemySkill es = ctx.EnemySkills.FirstOrDefault(i => i.Skill.SkillId == sString);

                es.EnemySkillRank = (int)skillRankNB.Value;

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void removeSButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                DataGridViewRow s = sDGV.CurrentRow;
                string sString = s.Cells[0].Value.ToString();

                EnemySkill es = ctx.EnemySkills.FirstOrDefault(i => i.Skill.SkillId == sString);

                ctx.EnemySkills.Remove(es);

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void DisplaySG(string et)
        {
            using (var ctx = new Shadowrun3Context())
            {

                DataSet esgDS = new DataSet();

                DataTable esgDT = new DataTable("esgDT");
                DataColumn esgDC = new DataColumn("Skill Group", typeof(string));
                esgDT.Columns.Add(esgDC);
                DataColumn rankDC = new DataColumn("Rank", typeof(int));
                esgDT.Columns.Add(rankDC);

                foreach (EnemySkillGroup etSG in ctx.EnemySkillGroups.Where(a => a.EnemyType.EnemyTypeId == et))
                {
                    DataRow esgDR = esgDT.NewRow();
                    esgDR["Skill Group"] = etSG.SkillGroup.SkillGroupId;
                    esgDR["Rank"] = etSG.Rank;
                    esgDT.Rows.Add(esgDR);
                }

                esgDS.Tables.Add(esgDT);

                sgDGV.DataSource = esgDS.Tables["esgDT"].DefaultView;
                sgDGV.BindingContext = this.BindingContext;

            }
        }

        private void DisplayS(string et)
        {
            using (var ctx = new Shadowrun3Context())
            {

                DataSet esDS = new DataSet();

                DataTable esDT = new DataTable("esDT");
                DataColumn esDC = new DataColumn("Skill", typeof(string));
                esDT.Columns.Add(esDC);
                DataColumn rankDC = new DataColumn("Rank", typeof(int));
                esDT.Columns.Add(rankDC);

                foreach (EnemySkill etS in ctx.EnemySkills.Where(a => a.EnemyType.EnemyTypeId == et))
                {
                    DataRow esDR = esDT.NewRow();
                    esDR["Skill"] = etS.Skill.SkillId;
                    esDR["Rank"] = etS.EnemySkillRank;
                    esDT.Rows.Add(esDR);
                }

                esDS.Tables.Add(esDT);

                sDGV.DataSource = esDS.Tables["esDT"].DefaultView;
                sDGV.BindingContext = this.BindingContext;

            }
        }

        private void sgDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
