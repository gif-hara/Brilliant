using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// GameSystemHistoryからGameSystemを切り替えるコンポーネント.
	/// </summary>
	public class ChangeGameSystemFromHistory : MonoBehaviour
	{
		public void Change()
		{
			var poppedSystem = GameSystemHolder.Instance.History.Pop;
			Assert.IsNotNull(poppedSystem);
			GameSystemHolder.Change(poppedSystem, false);
		}
	}
}
