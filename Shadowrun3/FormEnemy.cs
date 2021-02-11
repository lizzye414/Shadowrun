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
    public partial class FormEnemy : Form
    {
        private NamedEnemy enemy1;

        public FormEnemy()
        {
            InitializeComponent();
        }

        public FormEnemy(NamedEnemy enemy1)
        {
            this.enemy1 = enemy1;
            InitializeComponent();
        }

        private void FormEnemy_Load(object sender, EventArgs e)
        {
            nameLabel.Text = enemy1.NamedEnemyId;




        }

    }
}
