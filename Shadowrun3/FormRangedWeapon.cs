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
    public partial class FormRangedWeapon : Form
    {
        public FormRangedWeapon()
        {
            InitializeComponent();
        }

        RangedWeapon newRW = new RangedWeapon();
        string newSkillId;

        private void rwIdTB_TextChanged(object sender, EventArgs e)
        {
            newRW.RangedWeaponId = rwIdTB.Text;
        }

        private void damAmtNB_ValueChanged(object sender, EventArgs e)
        {
            newRW.DamageAmount = (int)damAmtNB.Value;
        }

        private void DamTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newRW.TypeOfDamage = damTypeCB.Text;
        }

        private void modeOfFireCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newRW.ModeOfFire = modeOfFireCB.Text;
        }

        private void ammoTypeTB_TextChanged(object sender, EventArgs e)
        {
            newRW.AmmoType = ammoTypeTB.Text;
        }

        private void apNB_ValueChanged(object sender, EventArgs e)
        {
            newRW.AP = (int)apNB.Value;
        }

        private void rwSkillCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSkillId = rwSkillCB.Text;
        }

        private void rwSubmitButton_Click(object sender, EventArgs e)
        {

            using (var ctx = new Shadowrun3Context())
            {

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == newSkillId);
                newRW.skill = newSkill;

                try
                {
                    ctx.RangedWeapons.Add(newRW);
                    ctx.SaveChanges();

                    FormRangedWeapon NewForm = new FormRangedWeapon();
                    NewForm.Show();
                    this.Dispose(false);

                }
                catch
                {
                    MessageBox.Show("That weapon already exists");
                }
            }

        }

        private void FormRangedWeapon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.RangedWeapons' table. You can move, or remove it, as needed.
            this.rangedWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet.RangedWeapons);

        }

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                rwIdTB.Enabled = true;
                rwSubmitButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                rwIdTB.Enabled = false;
                rwSubmitButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                string rwString = rwSkillCB.SelectedValue?.ToString();
                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == rwString);

                RangedWeapon updatedRW = ctx.RangedWeapons.First(a => a.RangedWeaponId == rwIdTB.Text);
                updatedRW.DamageAmount = (int)damAmtNB.Value;
                updatedRW.TypeOfDamage = damTypeCB.Text;
                updatedRW.ModeOfFire = modeOfFireCB.Text;
                updatedRW.AmmoType = ammoTypeTB.Text;
                updatedRW.AP = (int)apNB.Value;
                updatedRW.skill = newSkill;
                ctx.SaveChanges();

                FormRangedWeapon NewForm = new FormRangedWeapon();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.RangedWeapons.Remove(ctx.RangedWeapons.Single(a => a.RangedWeaponId == rwIdTB.Text));
                ctx.SaveChanges();

                FormRangedWeapon NewForm = new FormRangedWeapon();
                NewForm.Show();
                this.Dispose(false);
            }
        }
    }
}
