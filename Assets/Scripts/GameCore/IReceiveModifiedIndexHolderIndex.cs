using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// IndexHolderのIndexの値が変更された際のイベントをフックするインターフェイス.
	/// </summary>
	public interface IReceiveModifiedIndexHolderIndex : IEventSystemHandler
	{
		void OnModifiedIndex(int index);
	}
}
