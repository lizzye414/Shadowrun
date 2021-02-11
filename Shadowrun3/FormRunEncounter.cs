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
    public partial class FormRunEncounter : Form
    {
        public FormRunEncounter()
        {
            InitializeComponent();
        }

        private void FormRunEncounter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.Encounters' table. You can move, or remove it, as needed.
            this.encountersTableAdapter.Fill(this.shadowrun3ContextDataSet1.Encounters);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow enemy = enemyDGV.CurrentRow;
            string enemyString = enemy.Cells[0].Value.ToString();

            using (var ctx = new Shadowrun3Context())
            {
                NamedEnemy enemy1 = ctx.NamedEnemys.FirstOrDefault(i => i.NamedEnemyId == enemyString);
                FormEnemy fe = new FormEnemy(enemy1);
                fe.Show();
            }

        }

        private void encounterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string enc = encounterCB.SelectedValue.ToString();
                DisplayEnemies(enc);
            }
            catch
            {
                encounterCB.SelectedIndexChanged -= encounterCB_SelectedIndexChanged;
            }
        }

        private void DisplayEnemies(string enc)
        {
            using (var ctx = new Shadowrun3Context())
            {

                DataSet eDS = new DataSet();

                DataTable eDT = new DataTable("eDT");
                DataColumn eDC = new DataColumn("Enemy", typeof(string));
                eDT.Columns.Add(eDC);
                DataColumn deadDC = new DataColumn("Dead?", typeof(bool));
                eDT.Columns.Add(deadDC);

                foreach (NamedEnemy neE in ctx.NamedEnemys.Where(a => a.Encounter.EncounterId == enc))
                {
                    DataRow eDR = eDT.NewRow();
                    eDR["Enemy"] = neE.NamedEnemyId;
                    eDR["Dead?"] = neE.DeadOrAlive;
                    eDT.Rows.Add(eDR);
                }

                eDS.Tables.Add(eDT);

                enemyDGV.DataSource = eDS.Tables["eDT"].DefaultView;
                enemyDGV.BindingContext = this.BindingContext;

            }
        }


    }
}
