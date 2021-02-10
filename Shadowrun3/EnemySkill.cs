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

        public virtual Skill Skill { get; set; }
        public virtual EnemyType EnemyType { get; set; }

    }
}
