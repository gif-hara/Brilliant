using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// OnEnableのタイミングでViewを切り替えるコンポーネント.
	/// </summary>
	public class OnEnableChangeView : MonoBehaviour
	{
		[SerializeField]
		private GameDefine.ViewType viewType;

		void OnEnable()
		{
			GameView.Change(this.viewType);
		}
	}
}
