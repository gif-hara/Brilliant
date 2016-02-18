using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// このゲームのボタンを制御するコンポーネント.
	/// </summary>
	[RequireComponent(typeof(EventTrigger))]
	[RequireComponent(typeof(UnityEngine.UI.Button))]
	public class BrilliantButton : MonoBehaviour
	{
		public EventTrigger EventTrigger{ private set; get; }

		public UnityEngine.UI.Button Button{ private set; get; }

		[SerializeField]
		private UnityEngine.UI.Text text;

		void Awake()
		{
			this.EventTrigger = GetComponent<EventTrigger>();
			this.Button = GetComponent<UnityEngine.UI.Button>();
		}

		public void SetText(string text)
		{
			this.text.text = text;
		}
	}
}
