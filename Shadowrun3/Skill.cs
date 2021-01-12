using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class Skill
    {
        public string SkillId { get; set; }
        public string Attribute { get; set; }

        public SkillGroup SkillGroup { get; set; }

    }
}
