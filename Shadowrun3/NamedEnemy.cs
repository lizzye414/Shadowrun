using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class NamedEnemy
    {
        public string NamedEnemyId { get; set; }
        public int CurrentHP { get; set; }
        public int CurrentStun { get; set; }
        public int CurrentMatrix { get; set; }
        public int CurrentAmmo { get; set; }
        public int CurrentEdge { get; set; }
        public bool DeadOrAlive { get; set; }
        public int CommRating { get; set; }

        //Foreign keys
        public virtual EnemyType EnemyType { get; set; }
        public virtual Encounter Encounter { get; set; }

    }

}
