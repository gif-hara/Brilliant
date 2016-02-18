using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// BrilliantButtonのボタンテキストを設定するコンポーネント.
	/// </summary>
	public class SetButtonText : MonoBehaviour
	{
		[SerializeField]
		private GameDefine.ButtonType buttonType;

		[SerializeField]
		private string text;

		void OnEnable()
		{
			Buttons.Get(this.buttonType).SetText(this.text);
		}
			
	}
}
