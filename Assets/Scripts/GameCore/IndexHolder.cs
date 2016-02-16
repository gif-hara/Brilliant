using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// 単純なIndex値のみ保持するコンポーネント.
	/// </summary>
	public class IndexHolder : MonoBehaviour
	{
		public int Index{ get{ return this.index; } }
		[SerializeField]
		private int index;

		[SerializeField]
		private int max;

		[SerializeField]
		private bool isLoop;

		[SerializeField]
		private GameObject modifiedIndexReceiver;

		public void Add(int value)
		{
			this.index += value;

			if(this.isLoop)
			{
				this.index = this.index < 0 ? this.max : this.index;
				this.index = this.index > this.max ? 0 : this.index;
			}
			else
			{
				this.index = this.index < 0 ? 0 : this.index;
				this.index = this.index > this.max ? this.max : this.index;
			}

			ExecuteEvents.Execute<IReceiveModifiedIndexHolderIndex>(this.modifiedIndexReceiver, null, (handler, eventData) => handler.OnModifiedIndex(this.index));
		}
	}
}
