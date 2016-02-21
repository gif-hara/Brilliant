using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// Viewを切り替えるコンポーネント.
	/// </summary>
	public class ChangeView : MonoBehaviour
	{
		[SerializeField]
		private GameDefine.ViewType viewType;

		public void Change()
		{
			GameView.Change(this.viewType);
		}
	}
}
