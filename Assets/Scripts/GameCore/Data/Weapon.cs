using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// 武器マスターデータ.
	/// </summary>
	[System.Serializable]
	public class Weapon
	{
		public string Name{ get{ return this.name; } }
		[SerializeField]
		private string name;

		public int Strength{ get{ return this.strength; } }
		[SerializeField]
		private int strength;

		[SerializeField]
		private List<Skill> skills;
	}
}
