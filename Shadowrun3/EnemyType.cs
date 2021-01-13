﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class EnemyType
    {
		public EnemyType()
		{
			this.Spells = new HashSet<Spell>();
			this.RangedWeapons = new HashSet<RangedWeapon>();
			this.MeleeWeapons = new HashSet<MeleeWeapon>();
		}


		public string EnemyTypeId { get; set; }
		public MagicUserType TypeOfMagicUser { get; set; }
		public int Ballistic { get; set; }
		public int Impact { get; set; }
		public int Agility { get; set; }
		public int Body { get; set; }
		public int Reaction { get; set; }
		public int Strength { get; set; }
		public int Charisma { get; set; }
		public int Intuition { get; set; }
		public int Logic { get; set; }
		public int Edge { get; set; }
		public int Essence { get; set; }
		public int Magic { get; set; }
		public int Resonance { get; set; }

		public virtual ICollection<Spell> Spells { get; set; }
		public virtual ICollection<RangedWeapon> RangedWeapons { get; set; }
		public virtual ICollection<MeleeWeapon> MeleeWeapons { get; set; }

	}

	public enum MagicUserType
	{
		Mage,
		Shaman,
		Other,
		None
	}

}