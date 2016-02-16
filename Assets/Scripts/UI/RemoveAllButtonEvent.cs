using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// ボタン類のイベント全てを削除するコンポーネント.
	/// </summary>
	public class RemoveAllButtonEvent : MonoBehaviour
	{
		void OnEnable()
		{
			Buttons.List.ForEach(b => b.EventTrigger.triggers.RemoveAll(i => true));
		}
	}
}
