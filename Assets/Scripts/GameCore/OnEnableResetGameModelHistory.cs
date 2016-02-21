using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// OnEnableのタイミングでGameModelの履歴をリセットするコンポーネント.
	/// </summary>
	public class OnEnableResetGameModelHistory : MonoBehaviour
	{
		[SerializeField]
		private GameObject systemObject;

		void OnEnable()
		{
			GameModel.Instance.History.ToRoot(this.systemObject);
		}
	}
}
