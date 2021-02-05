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
    public partial class FormMeleeWeapon : Form
    {
        public FormMeleeWeapon()
        {
            InitializeComponent();
        }

        private void FormMeleeWeapon_Load(object sender, EventArgs e)
        {

            FillSkillsCB();

            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.MeleeWeapons' table. You can move, or remove it, as needed.
            this.meleeWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet1.MeleeWeapons);

        }

        string skillString;

        private void mwIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void damAmtNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void damTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void reachNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void apNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void mwSkillCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            skillString = mwSkillCB.Text;
        }

        private void FillSkillsCB()
        {

            using (var ctx = new Shadowrun3Context())
            {
                DataSet skillDS = new DataSet();

                DataTable skillDT = new DataTable("sdt");
                DataColumn skillDC = new DataColumn("Skill", typeof(Skill));
                skillDT.Columns.Add(skillDC);
                DataColumn skillIdDC = new DataColumn("SkillId", typeof(string));
                skillDT.Columns.Add(skillIdDC);

                foreach (Skill skill in ctx.Skills.Where(a => a.SkillGroup.SkillGroupId == "Close Combat" || a.SkillId == "Exotic Melee Weapon"))
                {
                    DataRow skillDR = skillDT.NewRow();
                    skillDR["Skill"] = skill;
                    skillDR["SkillId"] = skill.SkillId;
                    skillDT.Rows.Add(skillDR);
                }

                skillDS.Tables.Add(skillDT);

                mwSkillCB.DataSource = skillDS.Tables["sdt"].DefaultView;
                mwSkillCB.DisplayMember = "SkillId";
                mwSkillCB.BindingContext = this.BindingContext;
            }

        }

        private void mwSubmitButton_Click(object sender, EventArgs e)
        {

            using (var ctx = new Shadowrun3Context())
            {

                MeleeWeapon mw = new MeleeWeapon();
                mw.MeleeWeaponId = nameTB.Text;
                mw = SetVar(mw);
                
                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == skillString);
                mw.skill = newSkill;

                try
                {
                    ctx.MeleeWeapons.Add(mw);
                    ctx.SaveChanges();

                    ResetForm();

                }
                catch
                {
                    MessageBox.Show("That weapon already exists");
                }
            }


        }

        

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                nameTB.Enabled = true;
                submitButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                nameTB.Enabled = false;
                submitButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                MeleeWeapon mw = ctx.MeleeWeapons.First(a => a.MeleeWeaponId == nameTB.Text);
                mw = SetVar(mw);

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == skillString);
                mw.skill = newSkill;

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.MeleeWeapons.Remove(ctx.MeleeWeapons.Single(a => a.MeleeWeaponId == nameTB.Text));
                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void ResetForm()
        {
            FormMeleeWeapon NewForm = new FormMeleeWeapon();
            NewForm.Show();
            this.Dispose(false);
        }

        private MeleeWeapon SetVar(MeleeWeapon mw)
        {
            mw.DamageAmount = (int)damAmtNB.Value;
            mw.TypeOfDamage = damTypeCB.Text;
            mw.Reach = (int)reachNB.Value;
            mw.AP = (int)apNB.Value;
            return mw;
        }

    }
}
