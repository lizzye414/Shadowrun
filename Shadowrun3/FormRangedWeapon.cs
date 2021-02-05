using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingSource = Microsoft.AspNetCore.Mvc.ModelBinding.BindingSource;

namespace Shadowrun3
{
    public partial class FormRangedWeapon : Form
    {
        public FormRangedWeapon()
        {
            InitializeComponent();
        }

        string skillString;

        private void rwIdTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void damAmtNB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void DamTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void modeOfFireCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ammoTypeTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void apNB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rwSkillCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            skillString = rwSkillCB.Text;
        }

        private void rwSubmitButton_Click(object sender, EventArgs e)
        {

            using (var ctx = new Shadowrun3Context())
            {
                RangedWeapon rw = new RangedWeapon();

                rw.RangedWeaponId = nameTB.Text;
                rw = SetVar(rw);

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == skillString);
                rw.skill = newSkill;

                try
                {
                    ctx.RangedWeapons.Add(rw);
                    ctx.SaveChanges();

                    ResetForm();

                }
                catch
                {
                    MessageBox.Show("That weapon already exists");
                }
            }

        }

        private void FormRangedWeapon_Load(object sender, EventArgs e)
        {
            //Fill the skills combobox
            FillSkillsCB();


            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.RangedWeapons' table. You can move, or remove it, as needed.
            this.rangedWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet1.RangedWeapons);


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

                foreach (Skill skill in ctx.Skills.Where(a => a.SkillGroup.SkillGroupId == "Firearms" || a.SkillId == "Exotic Ranged Weapon" || a.SkillId == "Thrown Weapons" ))
                {
                    DataRow skillDR = skillDT.NewRow();
                    skillDR["Skill"] = skill;
                    skillDR["SkillId"] = skill.SkillId;
                    skillDT.Rows.Add(skillDR);
                }

                skillDS.Tables.Add(skillDT);

                rwSkillCB.DataSource = skillDS.Tables["sdt"].DefaultView;
                rwSkillCB.DisplayMember = "SkillId";
                rwSkillCB.BindingContext = this.BindingContext;
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
                
                RangedWeapon rw = ctx.RangedWeapons.First(a => a.RangedWeaponId == nameTB.Text);
                rw = SetVar(rw);

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == skillString);
                rw.skill = newSkill;

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.RangedWeapons.Remove(ctx.RangedWeapons.Single(a => a.RangedWeaponId == nameTB.Text));
                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void ResetForm()
        {
            FormRangedWeapon NewForm = new FormRangedWeapon();
            NewForm.Show();
            this.Dispose(false);
        }

        private RangedWeapon SetVar(RangedWeapon rw)
        {
            rw.DamageAmount = (int)damAmtNB.Value;
            rw.TypeOfDamage = damTypeCB.Text;
            rw.ModeOfFire = modeOfFireCB.Text;
            rw.AmmoType = ammoTypeTB.Text;
            rw.AP = (int)apNB.Value;
            return rw;
        }



    }
}
