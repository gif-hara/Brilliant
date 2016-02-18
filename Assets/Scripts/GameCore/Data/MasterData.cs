using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// マスターデータ.
	/// </summary>
	public class MasterData : ScriptableObject
	{
		public List<Weapon> Weapon{ get{ return this.weapon; } }
		[SerializeField]
		private List<Weapon> weapon;

		public List<Item> Item{ get{ return this.item; } }
		[SerializeField]
		private List<Item> item;


	}
}
