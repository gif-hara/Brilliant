using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// アイテムデータ.
	/// </summary>
	[System.Serializable]
	public class Item
	{
		[SerializeField]
		private string name;
	}
}
