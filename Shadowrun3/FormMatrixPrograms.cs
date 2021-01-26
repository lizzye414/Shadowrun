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
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.MatrixPrograms' table. You can move, or remove it, as needed.
            this.matrixProgramsTableAdapter.Fill(this.shadowrun3ContextDataSet.MatrixPrograms);

            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet.Skills' table. You can move, or remove it, as needed.
            this.skillsTableAdapter.Fill(this.shadowrun3ContextDataSet.Skills);

        }

        MatrixProgram newProgram = new MatrixProgram();
        string newSkillId;

        private void programNameTB_TextChanged(object sender, EventArgs e)
        {
            newProgram.MatrixProgramId = programNameTB.Text;
        }

        private void skillCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            newSkillId = skillCB.SelectedValue?.ToString();

        }


        private void programSubmitButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                Skill newSkill = ctx.Skills.FirstOrDefault(i => i.SkillId == newSkillId);
                newProgram.skill = newSkill;

                try
                {
                    ctx.MatrixPrograms.Add(newProgram);
                    ctx.SaveChanges();

                    FormMatrixPrograms NewForm = new FormMatrixPrograms();
                    NewForm.Show();
                    this.Dispose(false);

                }
                catch
                {
                    MessageBox.Show("That program already exists");
                }
            }
        }


    }
}
