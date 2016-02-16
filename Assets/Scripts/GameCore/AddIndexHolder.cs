using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// IndexHolderのAdd関数を実行するコンポーネント.
	/// </summary>
	public class AddIndexHolder : MonoBehaviour
	{
		[SerializeField]
		private IndexHolder indexHolder;

		[SerializeField]
		private int value;

		public void Add()
		{
			this.indexHolder.Add(this.value);
		}
	}
}
