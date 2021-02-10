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
    public partial class FormEncounter : Form
    {
        public FormEncounter()
        {
            InitializeComponent();
        }

        private void FormEncounter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.NamedEnemies' table. You can move, or remove it, as needed.
            this.namedEnemiesTableAdapter.Fill(this.shadowrun3ContextDataSet1.NamedEnemies);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.Encounters' table. You can move, or remove it, as needed.
            this.encountersTableAdapter.Fill(this.shadowrun3ContextDataSet1.Encounters);

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                try
                {
                    Encounter enc = new Encounter();
                    enc.EncounterId = nameTB.Text;
                    ctx.Encounters.Add(enc);
                    ctx.SaveChanges();

                    ResetForm();
                }
                catch
                {
                    MessageBox.Show("That encounter already exists");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                DataGridViewRow enc = dataGridView1.CurrentRow;
                string encString = enc.Cells[0].Value.ToString();
                Encounter encounter = ctx.Encounters.FirstOrDefault(i => i.EncounterId == encString);

                string neString = neCB.SelectedValue.ToString();
                NamedEnemy ne = ctx.NamedEnemys.FirstOrDefault(i => i.NamedEnemyId == neString);

                ne.Encounter = encounter;

                ctx.SaveChanges();

                ResetForm();

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetForm()
        {
            FormEncounter NewForm = new FormEncounter();
            NewForm.Show();
            this.Dispose(false);
        }


        private void newRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (newRB.Checked)
            {
                nameTB.Enabled = true;
                submitButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void updateRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (updateRB.Checked)
            {
                nameTB.Enabled = false;
                submitButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow enc = dataGridView1.CurrentRow;
            string encString = enc.Cells[0].Value.ToString();

            DisplayNamedEnemies(encString);
        }

        private void DisplayNamedEnemies(string enc)
        {
            List<string> neList = new List<string>();

            using (var ctx = new Shadowrun3Context())
            {
                foreach (NamedEnemy eachNE in ctx.NamedEnemys.Where(a => a.Encounter.EncounterId == enc))
                {
                    neList.Add(eachNE.NamedEnemyId);
                }
            }

            neLB.DataSource = neList;
        }


    }
}
