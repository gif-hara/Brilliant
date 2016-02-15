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
	public class BrilliantButton : MonoBehaviour
	{
		public EventTrigger EventTrigger{ private set; get; }

		void Awake()
		{
			this.EventTrigger = GetComponent<EventTrigger>();
		}
	}
}
