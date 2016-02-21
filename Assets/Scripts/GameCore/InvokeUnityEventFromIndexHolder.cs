using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// IndexHolderからUnityEventを実行するコンポーネント.
	/// </summary>
	public class InvokeUnityEventFromIndexHolder : MonoBehaviour
	{
		[SerializeField]
		private IndexHolder indexHolder;

		[SerializeField]
		private List<UnityEvent> otherEvents;

		public void Invoke()
		{
			this.otherEvents[this.indexHolder.Index].Invoke();
		}
	}
}
