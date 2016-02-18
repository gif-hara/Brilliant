using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// スキル.
	/// </summary>
	public class Skill : ScriptableObject
	{
		[SerializeField]
		private List<SkillData> database;
	}
}
