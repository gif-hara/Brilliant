using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// BrilliantButtonにイベントをアタッチするコンポーネント.
	/// </summary>
	public class AttachButtonEventTrigger : MonoBehaviour
	{
		[SerializeField]
		private GameDefine.ButtonType buttonType;

		[SerializeField]
		private EventTriggerType triggerType;

		[SerializeField]
		private UnityEvent otherEvent;

		void OnEnable()
		{
			var entry = new EventTrigger.Entry();
			entry.eventID = this.triggerType;
			entry.callback = new EventTrigger.TriggerEvent();
			entry.callback.AddListener(new UnityAction<BaseEventData>((b) => this.otherEvent.Invoke()));
			Buttons.Get(this.buttonType).EventTrigger.triggers.Add(entry);
		}
	}
}
