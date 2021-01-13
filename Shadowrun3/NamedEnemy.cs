using System;
using System.Collections.Generic;
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
        public IsDead DeadOrAlive { get; set; }

        //Foreign keys
        public EnemyType EnemyType { get; set; }
        public Encounter Encounter { get; set; }

    }

    public enum IsDead
    {
        Y,
        N
    }

}
