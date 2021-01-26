﻿using System;
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
            newRW.TypeOfDamage = DamTypeCB.Text;
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


    }
}
