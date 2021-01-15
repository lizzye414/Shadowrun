using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class Spell
    {
		public Spell()
		{

			this.EnemyTypes = new HashSet<EnemyType>();

		}

		public string SpellId { get; set; }
		public string TypeOfSpell { get; set; }
		public string CategoryOfSpell { get; set; }

		public string RangeOfSpell { get; set; }
		public string DamageOfSpell { get; set; }
		public string DurationOfSpell { get; set; }
		public int DVMod { get; set; }

		public virtual ICollection<EnemyType> EnemyTypes { get; set; }

	}

	/*
	public enum SpellType
	{
		P,
		M
	}

	public enum SpellCategory
	{
		Combat,
		Detection,
		Health,
		Illusion,
		Manipulation
	}

	public enum SpellRange
	{
		Touch,
		LOS,
		LOSArea
	}

	public enum SpellDamage
	{
		P,
		S,
		NA
	}

	public enum SpellDuration
	{
		Instant,
		Sustained,
		Permanent
	}*/

}
