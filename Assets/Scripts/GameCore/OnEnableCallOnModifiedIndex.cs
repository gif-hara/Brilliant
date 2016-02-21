using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// OnEnableのタイミングでOnModifiedIndexを実行するコンポーネント.
	/// </summary>
	public class OnEnableCallOnModifiedIndex : MonoBehaviour
	{
		[SerializeField]
		private IndexHolder indexHolder;

		[SerializeField]
		private List<MonoBehaviour> receivers;

		void OnEnable()
		{
			this.receivers.ForEach(r =>
			{
				(r as IReceiveModifiedIndexHolderIndex).OnModifiedIndex(this.indexHolder.Index);
			});
		}
	}
}
