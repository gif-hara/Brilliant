using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// GameSystemを切り替えるコンポーネント.
	/// </summary>
	public class ChangeGameSystem : MonoBehaviour
	{
		[SerializeField]
		private GameObject systemObject;

		[SerializeField]
		private bool addHistory;

		public void Change()
		{
			GameModel.Change(this.systemObject, this.addHistory);
		}
	}
}
