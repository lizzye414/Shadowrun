using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class MeleeWeapon
    {
		public MeleeWeapon()
		{

			this.EnemyTypes = new HashSet<EnemyType>();

		}

		public string MeleeWeaponId { get; set; }
		public int DamageAmount { get; set; }
		public int Reach { get; set; }
		public MeleeDamageType TypeOfDamage { get; set; }
		public int AP { get; set; }

		public virtual ICollection<EnemyType> EnemyTypes { get; set; }

	}

	public enum MeleeDamageType
	{
		P,
		S
	}

}
