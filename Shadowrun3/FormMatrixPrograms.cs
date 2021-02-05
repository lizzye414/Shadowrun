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
    public partial class FormMatrixPrograms : Form
    {

        public FormMatrixPrograms()
        {
            InitializeComponent();
            
        }


        private void FormMatrixPrograms_Load(object sender, EventArgs e)
        {

            FillSkillsCB();

            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.MatrixPrograms' table. You can move, or remove it, as needed.
            this.matrixProgramsTableAdapter.Fill(this.shadowrun3ContextDataSet1.MatrixPrograms);

        }

        MatrixProgram newProgram = new MatrixProgram();
        string skillString;

        private void programNameTB_TextChanged(object sender, EventArgs e)
        {
            newProgram.MatrixProgramId = programNameTB.Text;
        }

        private void skillCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            skillString = skillCB.SelectedValue?.ToString();

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

                skillCB.DataSource = skillDS.Tables["sdt"].DefaultView;
                skillCB.DisplayMember = "SkillId";
                skillCB.BindingContext = this.BindingContext;
            }

        }


        private void programSubmitButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == skillString);
                newProgram.skill = newSkill;

                try
                {
                    ctx.MatrixPrograms.Add(newProgram);
                    ctx.SaveChanges();

                    ResetForm();

                }
                catch
                {
                    MessageBox.Show("That program already exists");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var ctx = new Shadowrun3Context())
            {

                ctx.MatrixPrograms.Remove(ctx.MatrixPrograms.Single(a => a.MatrixProgramId == programNameTB.Text));
                ctx.SaveChanges();

                ResetForm();
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                string skillString = skillCB.SelectedValue?.ToString();
                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == skillString);

                MatrixProgram updatedProg = ctx.MatrixPrograms.First(a => a.MatrixProgramId == programNameTB.Text);
                updatedProg.skill = newSkill;
                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {

            if(newRB.Checked)
            {
                programNameTB.Enabled = true;
                programSubmitButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }

        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {

            if(updateRB.Checked)
            {
                programNameTB.Enabled = false;
                programSubmitButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }

        }

        private void ResetForm()
        {
            FormMatrixPrograms NewForm = new FormMatrixPrograms();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
