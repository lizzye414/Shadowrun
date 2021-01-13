using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class EnemySkill
    {
        public int EnemySkillId { get; set; }
        public int EnemySkillRank { get; set; }

        public Skill Skill { get; set; }
        public EnemyType EnemyType { get; set; }

    }
}
