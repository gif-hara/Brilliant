using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// IndexHolderからGameSystemを切り替えるコンポーネント.
	/// </summary>
	public class ChangeGameSystemFromIndexHolder : MonoBehaviour
	{
		[SerializeField]
		private IndexHolder indexHolder;

		[SerializeField]
		private List<GameObject> systemObjects;

		[SerializeField]
		private bool addHistory;

		public void Change()
		{
			GameSystemHolder.Change(this.systemObjects[this.indexHolder.Index], this.addHistory);
		}
	}
}
