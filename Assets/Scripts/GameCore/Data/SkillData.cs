using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// スキルデータ.
	/// </summary>
	[System.Serializable]
	public class SkillData
	{
		public string Name{ get{ return this.name; } }
		[SerializeField]
		private string name;

		public float Value{ get{ return this.value; } }
		[SerializeField]
		private float value;
	}
}
