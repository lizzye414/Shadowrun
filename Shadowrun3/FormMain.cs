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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRangedWeapon rwForm = new FormRangedWeapon();
            rwForm.Show();

        }

        private void meleeWeapons_Click(object sender, EventArgs e)
        {
            FormMeleeWeapon mwForm = new FormMeleeWeapon();
            mwForm.Show();
        }

        private void encounter_Click(object sender, EventArgs e)
        {
            FormEncounter eForm = new FormEncounter();
            eForm.Show();
        }

        private void enemyType_Click(object sender, EventArgs e)
        {
            FormEnemyType etForm = new FormEnemyType();
            etForm.Show();
        }

        private void matrixPrograms_Click(object sender, EventArgs e)
        {
            FormMatrixPrograms mpForm = new FormMatrixPrograms();
            mpForm.Show();
        }

        private void namedEnemies_Click(object sender, EventArgs e)
        {
            FormNamedEnemy neForm = new FormNamedEnemy();
            neForm.Show();
        }

        private void spells_Click(object sender, EventArgs e)
        {
            FormSpells sForm = new FormSpells();
            sForm.Show();
        }
    }
}
