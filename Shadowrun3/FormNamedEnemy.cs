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
    public partial class FormNamedEnemy : Form
    {
        public FormNamedEnemy()
        {
            InitializeComponent();
        }

        private void FormNamedEnemy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.EnemyTypes' table. You can move, or remove it, as needed.
            this.enemyTypesTableAdapter.Fill(this.shadowrun3ContextDataSet1.EnemyTypes);
            // TODO: This line of code loads data into the 'shadowrun3ContextDataSet1.NamedEnemies' table. You can move, or remove it, as needed.
            this.namedEnemiesTableAdapter.Fill(this.shadowrun3ContextDataSet1.NamedEnemies);

        }

        private void enemyTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitSpell_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                try
                {
                    //Create new named enemy
                    NamedEnemy ne = new NamedEnemy();
                    ne.NamedEnemyId = nameTB.Text;

                    //Find out the enemy type for the enemy to be based on
                    string etString = enemyTypeCB.Text;
                    EnemyType et = ctx.EnemyTypes.FirstOrDefault(i => i.EnemyTypeId == etString);
                    ne.EnemyType = et;

                    //Work out the starting HP (8 + body/2 rounded up)
                    int body = 0;
                    if(et.Body%2 == 0)
                    {
                        body = et.Body/2;
                    }
                    else
                    {
                        body = (et.Body/2) + 1;
                    }

                    ne.CurrentHP = 8 + body;

                    //Work out the starting stun (8 + will/2 rounded up)
                    int will = 0;
                    if(et.Willpower%2 == 0)
                    {
                        will = et.Willpower/2;
                    }
                    else
                    {
                        will = (et.Willpower/2) + 1;
                    }

                    ne.CurrentStun = 8 + will;

                    //Work out the starting matrix (8 + sys/2 rounded up)
                    int sys = 0;
                    if(et.SystemRating%2 == 0)
                    {
                        sys = et.SystemRating/2;
                    }
                    else
                    {
                        sys = (et.SystemRating/2) + 1;
                    }

                    ne.CurrentMatrix = 8 + sys;

                    //Get the starting edge and comm rating from enemy type
                    ne.CurrentEdge = et.Edge;
                    ne.CommRating = et.SystemRating;

                    //Add the current ammo from user input
                    ne.CurrentAmmo = (int)AmmoNB.Value;

                    //Start the named enemy as alive
                    ne.DeadOrAlive = false;

                    ctx.NamedEnemys.Add(ne);
                    ctx.SaveChanges();

                    ResetForm();

                }
                catch
                {
                    MessageBox.Show("That named enemy already exists");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {

                NamedEnemy ne = ctx.NamedEnemys.First(a => a.NamedEnemyId == nameTB.Text);
                ne.CurrentHP = (int)HPNB.Value;
                ne.CurrentStun = (int)StunNB.Value;
                ne.CurrentMatrix = (int)MatrixNB.Value;
                ne.CurrentEdge = (int)EdgeNB.Value;
                ne.CurrentAmmo = (int)AmmoNB.Value;
                ne.CommRating = (int)SysRatingNB.Value;

                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new Shadowrun3Context())
            {
                ctx.NamedEnemys.Remove(ctx.NamedEnemys.Single(a => a.NamedEnemyId == nameTB.Text));
                ctx.SaveChanges();

                ResetForm();
            }
        }

        private void newRB_CheckedChanged(object sender, EventArgs e)
        {
            nameTB.Enabled = true;
            submitButton.Enabled = true;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            HPNB.Enabled = false;
            StunNB.Enabled = false;
            MatrixNB.Enabled = false;
            SysRatingNB.Enabled = false;
            EdgeNB.Enabled = false;
            enemyTypeCB.Enabled = true;
        }

        private void updateRB_CheckedChanged(object sender, EventArgs e)
        {
            nameTB.Enabled = false;
            submitButton.Enabled = false;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            HPNB.Enabled = true;
            StunNB.Enabled = true;
            MatrixNB.Enabled = true;
            SysRatingNB.Enabled = true;
            EdgeNB.Enabled = true;
            enemyTypeCB.Enabled = false;
        }

        private void ResetForm()
        {
            FormNamedEnemy NewForm = new FormNamedEnemy();
            NewForm.Show();
            this.Dispose(false);
        }

    }
}
