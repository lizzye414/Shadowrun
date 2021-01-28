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

        MeleeWeapon newMW = new MeleeWeapon();
        string newSkillId;

        private void mwIdTB_TextChanged(object sender, EventArgs e)
        {

            newMW.MeleeWeaponId = mwIdTB.Text;

        }

        private void damAmtNB_ValueChanged(object sender, EventArgs e)
        {
            newMW.DamageAmount = (int)damAmtNB.Value;
        }

        private void damTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newMW.TypeOfDamage = damTypeCB.Text;
        }

        private void reachNB_ValueChanged(object sender, EventArgs e)
        {
            newMW.Reach = (int)reachNB.Value;
        }

        private void apNB_ValueChanged(object sender, EventArgs e)
        {
            newMW.AP = (int)apNB.Value;
        }

        private void mwSkillCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSkillId = mwSkillCB.Text;
        }

        private void mwSubmitButton_Click(object sender, EventArgs e)
        {

            using (var ctx = new Shadowrun3Context())
            {

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == newSkillId);
                newMW.skill = newSkill;

                try
                {
                    ctx.MeleeWeapons.Add(newMW);
                    ctx.SaveChanges();

                    FormMeleeWeapon NewForm = new FormMeleeWeapon();
                    NewForm.Show();
                    this.Dispose(false);

                }
                catch
                {
                    MessageBox.Show("That weapon already exists");
                }
            }


        }

        private void FormMeleeWeapon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.MeleeWeapons' table. You can move, or remove it, as needed.
            this.meleeWeaponsTableAdapter.Fill(this.shadowrun3ContextDataSet.MeleeWeapons);

        }

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                mwIdTB.Enabled = true;
                mwSubmitButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                mwIdTB.Enabled = false;
                mwSubmitButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                string mwString = mwSkillCB.SelectedValue?.ToString();
                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == mwString);

                MeleeWeapon updatedMW = ctx.MeleeWeapons.First(a => a.MeleeWeaponId == mwIdTB.Text);
                updatedMW.DamageAmount = (int)damAmtNB.Value;
                updatedMW.TypeOfDamage = damTypeCB.Text;
                updatedMW.Reach = (int)reachNB.Value;
                updatedMW.AP = (int)apNB.Value;
                updatedMW.skill = newSkill;
                ctx.SaveChanges();

                FormMeleeWeapon NewForm = new FormMeleeWeapon();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                ctx.MeleeWeapons.Remove(ctx.MeleeWeapons.Single(a => a.MeleeWeaponId == mwIdTB.Text));
                ctx.SaveChanges();

                FormMeleeWeapon NewForm = new FormMeleeWeapon();
                NewForm.Show();
                this.Dispose(false);
            }
        }
    }
}
