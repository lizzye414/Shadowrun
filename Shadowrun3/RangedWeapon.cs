using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class RangedWeapon
    {
		public RangedWeapon()
		{

			this.EnemyTypes = new HashSet<EnemyType>();

		}

		public string RangedWeaponId { get; set; }
		public int DamageAmount { get; set; }
		public string TypeOfDamage { get; set; }
		public string ModeOfFire { get; set; }
		public string AmmoType { get; set; }
		public int AP { get; set; }

		public Skill skill { get; set; }

		public virtual ICollection<EnemyType> EnemyTypes { get; set; }

	}

}
