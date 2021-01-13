using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class EnemySkillGroup
    {
        public int EnemySkillGroupId { get; set; }
        public int Rank { get; set; }

        //Foreign keys
        public virtual EnemyType EnemyType { get; set; }
        public virtual SkillGroup SkillGroup { get; set; }

    }
}
