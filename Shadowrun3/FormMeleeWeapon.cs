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


    }
}
