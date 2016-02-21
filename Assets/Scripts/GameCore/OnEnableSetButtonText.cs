using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// OnEnableのタイミングでBrilliantButtonのボタンテキストを設定するコンポーネント.
	/// </summary>
	public class OnEnableSetButtonText : MonoBehaviour
	{
		[SerializeField]
		private GameDefine.ButtonType buttonType;

		[SerializeField]
		private string text;

		void OnEnable()
		{
			GameController.Get(this.buttonType).SetText(this.text);
		}
			
	}
}
